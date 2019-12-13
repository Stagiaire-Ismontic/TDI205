using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mon_class_connnecion
{
    class Program
    {
        static void Main(string[] args)
        {
            //methode d'ajoute


            Console.WriteLine("Enter your Id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your firstname");
            string nom = Console.ReadLine();
            Console.WriteLine("Enter your lastname");
            string prenom = Console.ReadLine();

            SqlConnection conn = new SqlConnection("server=LENOVO-PC;Initial catalog=mon_class_connecion;integrated security=true");
            conn.Open();
            SqlCommand cmd = new SqlCommand($"insert into  stagiaire values({id},'{nom}','{prenom}')", conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("khdem");

            
            conn.Close();
            Console.ReadLine();
        }
    }
}
