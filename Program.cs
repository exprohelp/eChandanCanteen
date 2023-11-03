using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace eChandanCanteen
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
            //Application.Run(new Canteen.HIS_Doctor());
            //Application.Run(new eChandanCanteen.Canteen.TATReport());
            Application.Run(new main());
        }
    }
}
