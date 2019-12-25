using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2_DataSet_consoleApplication.DataSet1TableAdapters;

namespace TP2_DataSet_consoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            LivreTableAdapter lv = new LivreTableAdapter();

            // ajouter un livre

                 // lv.Insert(1,"Zigola","Roman","Ana");

            //Modifier les info d'un livre

            DataSet1.LivreDataTable LV_dataset = new DataSet1.LivreDataTable();

            lv.Fill(LV_dataset);

            DataSet1.LivreRow l = LV_dataset.FindByid(1);
            l.nom_auteur = "maxi ana";
            lv.Update(l);

        }
    }
}
