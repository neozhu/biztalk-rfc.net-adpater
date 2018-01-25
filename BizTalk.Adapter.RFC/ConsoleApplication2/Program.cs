using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "AAwprPZPHtaU3kpA274q2Q==";
            string d = "AAwprPZPHtaU3kpA274q2Q==";
            string a = DBKeyHelper.DBKey2Hana(s);
            string b = "000C29ACF64F1ED694DE4A40DBBE2AD9";
            string c = "000C29ACF64F1ED694DE4A40DBBE2AD9";
            byte[] ss = b.HexToBytes();
            string x = ss.ToHex();
            string s1 = Convert.ToBase64String(ss);

            //ServiceReference1.BizTalk_RFC_TM_KSJD_101_BizTalkOrchestration_TM_KSJD_101SoapClient client = new ServiceReference1.BizTalk_RFC_TM_KSJD_101_BizTalkOrchestration_TM_KSJD_101SoapClient();
            //ServiceReference1.Z2FM_QO_FWA req = new ServiceReference1.Z2FM_QO_FWA();
            //req.MAXIMUM_ROWS = "10";
            //req.SELECT_OPTIONS = null;
            //var list = client.CALLZ2FM_QO_FWA(req);
            //Console.WriteLine(list.Count());

            //ServiceReference2.BizTalk_RFC_TM_KSJD_401_Orchestration_InboundSoapClient client = new ServiceReference2.BizTalk_RFC_TM_KSJD_401_Orchestration_InboundSoapClient();
            //ServiceReference2.Z2FM_QO_TRQ_CRT req = new ServiceReference2.Z2FM_QO_TRQ_CRT();
            //req.INPUT = new ServiceReference2.Z2FM_QO_TRQ_CRTINPUT();
            //req.INPUT.ROOT = new ServiceReference2.Z2FM_QO_TRQ_CRTINPUTROOT();

            ServiceReference3.BizTalk_RFC_TM_KSJD_101_BizTalkOrchestration_InboundSoapClient client = new ServiceReference3.BizTalk_RFC_TM_KSJD_101_BizTalkOrchestration_InboundSoapClient();
            ServiceReference3.Z2FM_QO_FWA req = new ServiceReference3.Z2FM_QO_FWA();
            req.MAXIMUM_ROWS = "100";
           

            var res= client.Exec(req);
            Console.ReadLine();
        }
    }
}
