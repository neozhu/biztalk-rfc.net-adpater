//---------------------------------------------------------------------
// File: HttpTransmitAdapterBatch.cs
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
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;

using Microsoft.BizTalk.TransportProxy.Interop;
using Microsoft.BizTalk.Message.Interop;
using Microsoft.BizTalk.Component.Interop;
using Microsoft.Samples.BizTalk.Adapter.Common;

namespace Microsoft.Samples.BizTalk.Adapters.RFCTransmitter
{
	/// <summary>
	/// Summary description for HttpTransmitAdapterBatch.
	/// </summary>
	public class RFCTransmitAdapterBatch : AsyncTransmitterBatch
	{
		public RFCTransmitAdapterBatch(int maxBatchSize, string propertyNamespace, IBTTransportProxy transportProxy, 
                    AsyncTransmitter asyncTransmitter) :
			   base(maxBatchSize, typeof(RFCTransmitterEndpoint), propertyNamespace, null, transportProxy, asyncTransmitter)
		{
		}
	}
}
