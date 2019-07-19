using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_301029474
{
    static class Program
    {
        public static MainForm mainForm;
        public static StartForm startForm;
        public static EndForm endForm;

       /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new MainForm();
            startForm = new StartForm();
            endForm = new EndForm();
            Application.Run(startForm);
        }
    }
}
