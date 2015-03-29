using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;


namespace eMediVision
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmAddDoctor("AddDoctor;add"));
            //Application.Run(new MDIParent1());
            //Application.Run(new frmAddCategory(";add"));
                Application.Run(new frmVoucherEntryPurchase());
          //Application.Run(new SoftwareLock());
            }
            catch (Exception e)
            {
                //using (StreamWriter sw=new StreamWriter(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location+"\\Error.txt"),true))
                //{
                //    sw.WriteLine("error-" + DateTime.Now.ToString() + ":" + e.Message);    
                //}

                MessageBox.Show(e.Message);
            }
        }
    }
}
