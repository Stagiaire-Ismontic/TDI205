using Q1.Tp2.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Q1.Tp2
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeTableAdapter Emp = new EmployeTableAdapter();
            // ajouter un Employe 
            Emp.Insert(114, "rajae","lll","azerty");
            // modifier un Employe
            DataSet1.EmployeDataTable Empl = new DataSet1.EmployeDataTable();
            Emp.Fill(Empl);
            DataSet1.EmployeRow E = Empl.FindByid(14);
            E.Nom = "Amine";
            Emp.Update(E);
        }
    }
}
