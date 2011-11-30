using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DataLayer;
using System.Data.Entity;

namespace TeamJ
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.SetInitializer<Context>(new ContextInitializer());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TestForm());
        }
    }
}
