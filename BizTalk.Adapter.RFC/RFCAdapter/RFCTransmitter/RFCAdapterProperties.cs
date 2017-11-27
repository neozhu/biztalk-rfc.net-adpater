//---------------------------------------------------------------------
// File: HttpAdapterProperties.cs
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
using System.Net;

using Microsoft.XLANGs.BaseTypes;
using Microsoft.BizTalk.Message.Interop;
using Microsoft.Samples.BizTalk.Adapter.Common;

namespace Microsoft.Samples.BizTalk.Adapters.RFCTransmitter
{
    /// <summary>
    /// This class maintains send port properties associated with a message. These properties
    /// will be extracted from the message context for static send ports.
    /// </summary>
    public class RFCAdapterProperties : ConfigProperties
    {
       
        private static string protocolAlias = "RFC.NET://";

        

        // Handler properties...
        private static int                handlerTimeout    = 120000;

        // Endpoint properties...
        private string appServerHost;
        private string destinationName;
        private string client;
        private string systemNumber;
        private string language;
        private string user;
        private string password;
        private string poolSize;
        private string peakConnectionsLimit;
        private string connectionIdleTimeout;
        private string programId;
        private string schemaAssembly;
        private string requestSchemaType;
        private string reponseSchemaType;



        private string uri;
        public string Uri { get { return uri; } }

        private static PropertyBase isSolicitResponseProp = new BTS.IsSolicitResponse();

        // If we needed to use SSO we will need this extra property. It is set in the
        // LocationConfiguration method below.
        // Additionally:
        //   TransmitLocation.xsd in the design-time project must also be edited to
        //   expose the necessary SSO properties.
        //   DotNetFileAsyncTransmitterBatch.cs within the run-time project must be
        //   edited to retrieve and populate the SSOResult class.
        //private string ssoAffiliateApplication;
        //public string AffiliateApplication { get { return ssoAffiliateApplication; } }

        private bool _isTwoWay;

        public bool IsTwoWay { get { return _isTwoWay; } }

        public string AppServerHost
        {
            get
            {
                return appServerHost;
            }

           
        }

        public string DestinationName
        {
            get
            {
                return destinationName;
            }

             
        }

        public string Client
        {
            get
            {
                return client;
            }

             
        }

        public string SystemNumber
        {
            get
            {
                return systemNumber;
            }

            
        }

        public string Language
        {
            get
            {
                return language;
            }

            
        }

        public string User
        {
            get
            {
                return user;
            }

            
        }

        public string Password
        {
            get
            {
                return password;
            }

            
        }

        public string PoolSize
        {
            get
            {
                return poolSize;
            }

             
        }

        public string PeakConnectionsLimit
        {
            get
            {
                return peakConnectionsLimit;
            }

            
        }

        public string ConnectionIdleTimeout
        {
            get
            {
                return connectionIdleTimeout;
            }

            
        }

        public string SchemaAssembly
        {
            get
            {
                return schemaAssembly;
            }

            
        }

        public string RequestSchemaType
        {
            get
            {
                return requestSchemaType;
            }

             
        }

        public string ReponseSchemaType
        {
            get
            {
                return reponseSchemaType;
            }

             
        }

        public string ProgramId
        {
            get
            {
                return programId;
            }

             
        }

        public RFCAdapterProperties(IBaseMessage message, string propertyNamespace)
        {
            XmlDocument locationConfigDom = null;

            //  get the adapter configuration off the message
            string config = (string) message.Context.Read("AdapterConfig", propertyNamespace);
            this._isTwoWay = (bool) message.Context.Read(isSolicitResponseProp.Name.Name, isSolicitResponseProp.Name.Namespace);

            //  the config can be null all that means is that we are doing a dynamic send
            if (null != config)
            {
                locationConfigDom = new XmlDocument();
                locationConfigDom.LoadXml(config);

                //  For Dynamic Sends the Location config can be null
                //  Location properties - possibly override some handler properties
                this.LocationConfiguration(locationConfigDom);
            }
        }

        public RFCAdapterProperties(string uri)
        {
            this.uri = uri;
            UpdateUriForDynamicSend();
        }

         

        public static void TransmitHandlerConfiguration (XmlDocument configDOM)
        {
            // Handler properties
            RFCAdapterProperties.handlerTimeout = ExtractInt(configDOM, "/Config/timeout");
        }

        public void LocationConfiguration(XmlDocument configDOM)
        {
            // Uri must exist (all static send port scenarios!)
            this.uri = Extract(configDOM, "Config/uri", null);

            this.appServerHost = IfExistsExtract(configDOM, "/Config/appServerHost", "");
            this.destinationName = IfExistsExtract(configDOM, "/Config/destinationName", "DTM");
            this.client = IfExistsExtract(configDOM, "/Config/client", "212");
            this.systemNumber = IfExistsExtract(configDOM, "/Config/systemNumber", "00");
            this.language= IfExistsExtract(configDOM, "/Config/language", "ZH");
            this.user= IfExistsExtract(configDOM, "/Config/user", "soapcall");
            this.password = IfExistsExtract(configDOM, "/Config/password", "soapcall") ;
            this.poolSize= IfExistsExtract(configDOM, "/Config/poolSize", "5");
            this.peakConnectionsLimit= IfExistsExtract(configDOM, "/Config/peakConnectionsLimit", "10");
            this.connectionIdleTimeout= IfExistsExtract(configDOM, "/Config/connectionIdleTimeout", "500");
            this.schemaAssembly = IfExistsExtract(configDOM, "/Config/schemaAssembly", "");
            this.requestSchemaType = IfExistsExtract(configDOM, "/Config/requestSchemaType", "");
            this.reponseSchemaType = IfExistsExtract(configDOM, "/Config/reponseSchemaType", "");
            this.programId = IfExistsExtract(configDOM, "/Config/programId", "");

        }
        public void UpdateUriForDynamicSend()
        {
            // Strip off the adapters alias
            if ( this.uri.StartsWith(protocolAlias, StringComparison.OrdinalIgnoreCase))
            {
                string newUri = this.uri.Substring(protocolAlias.Length);
                this.uri = newUri;
            }
        }
    }
}
