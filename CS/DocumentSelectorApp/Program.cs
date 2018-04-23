using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;

namespace DevExpress.Samples.DocumentSelector {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}