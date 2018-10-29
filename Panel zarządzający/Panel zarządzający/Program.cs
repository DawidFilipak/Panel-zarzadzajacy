using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Panel_zarządzający.Bazydanych;


namespace Panel_zarządzający
{
    static class Program
    {
       

        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Logowanie());
            
        }
    }
}
