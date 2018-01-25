using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace BizTalk.Adapter.DesignTime
{
    /// <summary>  
    /// Customer UITypeEditor that pops up a  
    /// file selector dialog  
    /// </summary>  
    public class AssemblyFileSelectTypeEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            if (context == null || context.Instance == null)
                return base.GetEditStyle(context);
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            var assemblyfullName = string.Empty;
            IWindowsFormsEditorService editorService;

            if (context == null || context.Instance == null || provider == null)
                return value;

            try
            {
                // get the editor service, just like in windows forms  
                editorService = (IWindowsFormsEditorService)
                   provider.GetService(typeof(IWindowsFormsEditorService));

                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "All Files (*.*)|*.*";
                dlg.CheckFileExists = true;

                assemblyfullName = (string)value;
                 

                using (dlg)
                {
                    DialogResult res = dlg.ShowDialog();
                    if (res == DialogResult.OK)
                    {

                        var filename = dlg.FileName;
                        assemblyfullName = Assembly.LoadFile(filename).FullName;
                    }
                }
                return assemblyfullName;

            }
            finally
            {
                editorService = null;
            }
        }
    } // class FileSelectorTypeEditor  
}
