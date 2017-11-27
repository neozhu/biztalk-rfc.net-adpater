using BizTalk.Adapter.DesignTime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var strFullyQualifiedName = "BizTalk.RFC.TM_KSJD_403.Schemas.INPUT.Z2FM_QO_TRQ_GET, BizTalk.RFC.TM_KSJD_403, Version=1.0.0.0, Culture=neutral, PublicKeyToken=65744ac7378603b4";

            AssemblyPopupForm frm = new AssemblyPopupForm(this.textBox1.Text
                );
            var result = frm.ShowDialog();
            if (result == DialogResult.OK) {
                this.textBox1.Text = frm.GetSelectSchemaTypeName();
            }
        }
    }
}
