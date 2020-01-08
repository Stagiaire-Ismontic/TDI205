using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syndic.NewFolder1;


namespace Syndic
{
    
    static class Program
    {
        public static AppContext context = new AppContext();
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
       
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NewFolder1.Menu());
        }
    }
}
