using ConsoleApp1.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployerTableAdapter emp = new EmployerTableAdapter();
            //ajouter un employer
            // emp.Insert("youssra", "amoury", null);
            //modifier un employer
            DataSet1.EmployerDataTable eDataTable = new DataSet1.EmployerDataTable();
            emp.Fill(eDataTable);
            DataSet1.EmployerRow e = eDataTable.FindById(1);
            e.prenom ="karima";
            emp.Update(e);
        }
    }
}
