//---------------------------------------------------------------------
// File: HttpAdapterWorkItem.cs
// 
// Summary: Implementation of an adapter framework sample adapter. 
//
// Sample: HTTP Transmit Adapter, demonstrating solicit-response.
//
//
//---------------------------------------------------------------------
// This file is part of the Microsoft BizTalk Server SDK
//
// Copyright (c) Microsoft Corporation. All rights reserved.
//
// This source code is intended only as a supplement to Microsoft BizTalk
// Server release and/or on-line documentation. See these other
// materials for detailed information regarding Microsoft code samples.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
// KIND, WHETHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
// PURPOSE.
//---------------------------------------------------------------------

using System;
using System.IO;
using System.Xml;
using System.Text;
using System.Net;
using System.Collections;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;

using Microsoft.BizTalk.Streaming;
using Microsoft.BizTalk.TransportProxy.Interop;
using Microsoft.BizTalk.Component.Interop;
using Microsoft.BizTalk.Message.Interop;
using Microsoft.Samples.BizTalk.Adapter.Common;
using Microsoft.XLANGs.BaseTypes;
using SAP.Middleware.Connector;
using BizTalk.Adapter.RFC.Core;

namespace Microsoft.Samples.BizTalk.Adapters.RFCTransmitter
{
    /// <summary>
    /// There is one instance of HttpTransmitterEndpoint class for each every static send port.
    /// Messages will be forwarded to this class by AsyncTransmitterBatch (via HttpTransmitAdapterBatch)
    /// </summary>
    internal class RFCTransmitterEndpoint: AsyncTransmitterEndpoint
    {
        private IBaseMessage    solicitMsg                    = null;
        private IBTTransportProxy    transportProxy                = null;
        private AsyncTransmitter    asyncTransmitter            = null;
        private string propertyNamespace;
        private static int IO_BUFFER_SIZE = 4096;

        public RFCTransmitterEndpoint(AsyncTransmitter asyncTransmitter) : base(asyncTransmitter)
        {
            this.asyncTransmitter = asyncTransmitter;
            this.transportProxy = asyncTransmitter.TransportProxy;
        }

        public override void Open(EndpointParameters endpointParameters, IPropertyBag handlerPropertyBag, string propertyNamespace)
        {
            this.propertyNamespace = propertyNamespace;
        }


        /// <summary>
        /// Implementation for AsyncTransmitterEndpoint::ProcessMessage
        /// Transmit the message and optionally return the response message
        /// </summary>
        public override IBaseMessage ProcessMessage(IBaseMessage message)
        {
            this.solicitMsg = message;

            RFCAdapterProperties props = new RFCAdapterProperties(message, this.propertyNamespace);
            IBaseMessage responseMsg = null;
            var outputmessagetype = string.Empty;
            if ( props.IsTwoWay )
            {
                var response = SendRFCRequest(this.solicitMsg, props, out outputmessagetype);
                responseMsg = BuildResponseMessage(response, outputmessagetype);
            }
            else
            {
                var response = SendRFCRequest(this.solicitMsg, props, out outputmessagetype);
                response.Close();
            }

            return responseMsg;
        }

        private IBaseMessage BuildResponseMessage(Stream reponse,string messagetype)
        {
            IBaseMessage btsResponse = null;

            // Get the response stream, create a new message attaching
            // the response stream...
            using (Stream s = reponse)
            {
                reponse.Seek(0, SeekOrigin.Begin);
                // NOTE: 
                // Copy the network stream into a virtual stream stream. If we were
                // to use a forward only stream (as in the response stream) we would 
                // not be able to suspend the response data on failure. The virtual 
                // stream will overflow to disc when it reaches a given threshold
                VirtualStream vs = new VirtualStream();
                int bytesRead = 0;
                byte[] buff = new byte[8 * 1024];
                while ((bytesRead = s.Read(buff, 0, buff.Length)) > 0)
                    vs.Write(buff, 0, bytesRead);

                reponse.Close();

                // Seek the stream back to the start...
                vs.Position = 0;

                // Build BTS message from the stream
                IBaseMessageFactory mf = transportProxy.GetMessageFactory();
                btsResponse = mf.CreateMessage();
                btsResponse.Context.Write("MessageType", "http://schemas.microsoft.com/BizTalk/2003/system-properties", messagetype);
                btsResponse.Context.Promote("MessageType", "http://schemas.microsoft.com/BizTalk/2003/system-properties", messagetype);

                IBaseMessagePart body = mf.CreateMessagePart();
                body.Data = vs;
                btsResponse.AddPart("Body", body, true);
            }

            return btsResponse;
        }

        private Stream SendRFCRequest(IBaseMessage msg, RFCAdapterProperties config,out string outputmessagetype)
        {
            #region SSO Usage Example
            // If we needed to use SSO to lookup the remote system credentials
            /*
            string ssoAffiliateApplication = props.AffiliateApplication;
            if (ssoAffiliateApplication.Length > 0)
            {
                SSOResult ssoResult = new SSOResult(msg, affiliateApplication);
                string userName  = ssoResult.UserName;
                string password  = ssoResult.Result[0];
                string etcEtcEtc = ssoResult.Result[1]; // (you can have additional metadata associated with the login in SSO) 
                    
                // use these credentials to login to the remote system
                // ideally zero off the password memory once we are done
            }                    
            */
            #endregion // SSO Usage Example


            RfcConfigParameters rfc = new RfcConfigParameters();
            rfc.Add(RfcConfigParameters.Name, config.DestinationName);
            rfc.Add(RfcConfigParameters.AppServerHost, config.AppServerHost);
            rfc.Add(RfcConfigParameters.Client, config.Client);
            rfc.Add(RfcConfigParameters.User, config.User);
            rfc.Add(RfcConfigParameters.Password, config.Password);
            rfc.Add(RfcConfigParameters.SystemNumber, config.SystemNumber);
            rfc.Add(RfcConfigParameters.Language, config.Language);
            rfc.Add(RfcConfigParameters.PoolSize, config.PoolSize);
            rfc.Add(RfcConfigParameters.PeakConnectionsLimit, config.PeakConnectionsLimit);
            rfc.Add(RfcConfigParameters.ConnectionIdleTimeout, config.ConnectionIdleTimeout);

            RfcDestination dest = RfcDestinationManager.GetDestination(rfc);

            //AssemblySelector selector = new AssemblySelector(config.SchemaAssembly, config.RequestSchemaType);
            AssemblySelector selector = new AssemblySelector(config.RequestSchemaType);
            XmlDocument doc = new XmlDocument();
            doc.Load(msg.BodyPart.Data);
           

            MessageDisassemblyV2 dis = new MessageDisassemblyV2(selector, dest);
            var fun = dis.Disassemble(doc);
            var inputmsgtype = dis.GetMessageType();
            msg.Context.Write("MessageType", "http://schemas.microsoft.com/BizTalk/2003/system-properties", inputmsgtype);
            msg.Context.Promote("MessageType", "http://schemas.microsoft.com/BizTalk/2003/system-properties", inputmsgtype);
            //AssemblySelector outputselector = new AssemblySelector(config.SchemaAssembly, config.ReponseSchemaType);
            AssemblySelector outputselector = new AssemblySelector(config.ReponseSchemaType);

            MessageGenerator gen = new MessageGenerator(outputselector, fun);
            var stream = gen.CreateInstance();
            outputmessagetype = gen.GetMessageType();


            return stream;
        }
    }
}
