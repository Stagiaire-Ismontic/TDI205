using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;

namespace connecter56
{
    class Program
  
    {
            static void Main(string[] args)
            {
            //Isert
            Console.WriteLine("entrer votre id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("entrer votre Nom");
            string nom = Console.ReadLine();


            SqlConnection con = new SqlConnection("server=DESKTOP-DVUEC26;Database=ConnectionDb;integrated security=true");
            con.Open();
            SqlCommand cmmd = new SqlCommand($"insert into Test values({id},'{nom}')", con);
            Console.WriteLine("khdm");

      
            con.Close();
            Console.ReadKey();

        }

        
        
    }
    
}
