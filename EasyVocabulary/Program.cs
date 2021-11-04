using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EasyVocabulary
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string strEdit = "";
        public static string ConnectString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.IO.Directory.GetCurrentDirectory() + @"\Database\Database.accdb" + ";Jet OLEDB:Database Password=13F91pTL";
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
