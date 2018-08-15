﻿using BizTalk.Adapter.DesignTime;
using BizTalk.Adapter.RFC.Core;
using SAP.Middleware.Connector;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Windows;
namespace ConsoleApplication1
{
    class Program
    {
        public static void SaveMemoryStream(MemoryStream ms, string FileName)
        {
            FileStream outStream = File.OpenWrite(FileName);
            outStream.Seek(0, SeekOrigin.Begin);
            ms.WriteTo(outStream);
            outStream.Flush();
            outStream.Close();
        }

        static void Main(string[] args)
        {
            // string assemblyName = "BizTalk.RFC.TM_KSJD_403, Version=1.0.0.0, Culture=neutral, PublicKeyToken=65744ac7378603b4";
            //var _assembly = Assembly.Load(assemblyName);
            // var schemaList = (from type in _assembly.GetTypes()
            //                       where !type.IsAbstract && type.BaseType==typeof(Microsoft.XLANGs.BaseTypes.SchemaBase)


            //                       select type).ToList();



            // var strFullyQualifiedName = "BizTalk.RFC.TM_KSJD_403.Schemas.INPUT.Z2FM_QO_TRQ_GET, BizTalk.RFC.TM_KSJD_403, Version=1.0.0.0, Culture=neutral, PublicKeyToken=65744ac7378603b4";


            // Console.ReadLine();
            // Type t = Type.GetType(strFullyQualifiedName);
            // var obj = Activator.CreateInstance(t);


            RfcConfigParameters rfc = new RfcConfigParameters();
            //rfc.Add(RfcConfigParameters.Name, "PTM");
            //rfc.Add(RfcConfigParameters.AppServerHost, "sapptm01.feili.com");
            //rfc.Add(RfcConfigParameters.Client, "810");
            //rfc.Add(RfcConfigParameters.User, "system_oa");
            //rfc.Add(RfcConfigParameters.Password, "Feiliks.OA.2016");
            //rfc.Add(RfcConfigParameters.SystemNumber, "00");
            //rfc.Add(RfcConfigParameters.Language, "ZH");
            //rfc.Add(RfcConfigParameters.PoolSize, "5");
            //rfc.Add(RfcConfigParameters.PeakConnectionsLimit, "10");
            //rfc.Add(RfcConfigParameters.ConnectionIdleTimeout, "500");



            rfc.Add(RfcConfigParameters.Name, "QTM");
            rfc.Add(RfcConfigParameters.AppServerHost, "sapqtm01.feili.com");
            rfc.Add(RfcConfigParameters.Client, "610");
            rfc.Add(RfcConfigParameters.User, "soapcall");
            rfc.Add(RfcConfigParameters.Password, "soapcall");
            rfc.Add(RfcConfigParameters.SystemNumber, "00");
            rfc.Add(RfcConfigParameters.Language, "ZH");
            rfc.Add(RfcConfigParameters.PoolSize, "5");
            rfc.Add(RfcConfigParameters.PeakConnectionsLimit, "10");
            rfc.Add(RfcConfigParameters.ConnectionIdleTimeout, "500");

            //rfc.Add(RfcConfigParameters.Name, "PS4");
            //rfc.Add(RfcConfigParameters.AppServerHost, "ecc.feili.com");
            //rfc.Add(RfcConfigParameters.Client, "800");
            //rfc.Add(RfcConfigParameters.User, "systemoa");
            //rfc.Add(RfcConfigParameters.Password, "FeiliksOA@2016");
            //rfc.Add(RfcConfigParameters.SystemNumber, "00");
            //rfc.Add(RfcConfigParameters.Language, "ZH");
            //rfc.Add(RfcConfigParameters.PoolSize, "5");
            //rfc.Add(RfcConfigParameters.PeakConnectionsLimit, "10");
            //rfc.Add(RfcConfigParameters.ConnectionIdleTimeout, "500");
            RfcDestination dest = RfcDestinationManager.GetDestination(rfc);

            AssemblySelector selector = new AssemblySelector("D:\\BizTalk.RFC.TM_CRM_701.dll", "BizTalk.RFC.TM_CRM_701.Schemas.INPUT.Z2FM_SQ_FWA_CREATE");
            XmlDocument doc = new XmlDocument();
            doc.Load("d:\\701.xml");

            MessageDisassembly dis = new MessageDisassembly(selector, dest);
            var fun = dis.Disassemble(doc);
            AssemblySelector outputselector = new AssemblySelector("D:\\BizTalk.RFC.TM_CRM_701.dll", "BizTalk.RFC.TM_CRM_701.Schemas.OUTPUT.Z2FM_SQ_FWA_CREATE_RES");

            MessageGenerator gen = new MessageGenerator(outputselector, fun);
            var stream = gen.CreateInstance();

            SaveMemoryStream(stream as MemoryStream, "d:\\output.xml");
        }
    }
}
