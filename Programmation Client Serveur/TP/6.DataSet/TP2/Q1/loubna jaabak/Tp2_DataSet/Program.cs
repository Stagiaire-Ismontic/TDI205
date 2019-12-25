using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Tp2_DataSet.DataEditeurxsdTableAdapters;


namespace Tp2_DataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            EditeurTableAdapter de = new EditeurTableAdapter();
            //Ajouter un Editeur
             //de.Insert(5,"Madani","hamza");
            //Modifier un Editeur
            DataEditeurxsd.EditeurDataTable set= new DataEditeurxsd.EditeurDataTable();
            de.Fill(set);
            DataEditeurxsd.EditeurRow edit = set.FindByid(10);
            edit.Nom = "Madani";
            edit.Prenom = "Ali";
            de.Update(edit);



        }
    }
}
