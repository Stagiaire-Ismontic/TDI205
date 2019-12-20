using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZaidKalini.BusnissLayer;
using ZaidKalini.Services;
using System.Data;

namespace ZaidKalini
{
    static class Program
    {

        public static List<Modules> Modules = new List<Modules>();
          

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Presentation.Main());
        }
    }
}
