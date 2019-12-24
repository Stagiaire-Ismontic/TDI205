using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFW1
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            using (var ctx = new PharmacieContext())
            {
                var Med = new Medicament() { Nom = "jk" };

                ctx.medicaments.Add(Med);
                ctx.SaveChanges();
            }






            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());




        }
    }
}
