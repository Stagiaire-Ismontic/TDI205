using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sqlConnexion_et_sqlCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Person;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[tblPerson]", conn);
                using (SqlDataReader Reader = cmd.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        Console.WriteLine(Reader[0] + "\t" + Reader[1] + "\t" + Reader[2] + "\t" + Reader[3] + "\t" + Reader[4]);
                    }
                }
            }


            //SqlConnection cnn = new SqlConnection("Data Source=.;Initial Catalog=Person;Integrated Security=True");
            //cnn.Open();
            //SqlCommand cmd = new SqlCommand("insert into tblPerson(ID,Name,Email,GenderID,age )values(12,'hmed','h@H.COM',2,22)", cnn);
            //cmd.ExecuteNonQuery();
            //Console.WriteLine("khdem");
            //cnn.Close();
            //Console.ReadKey();

            //Console.WriteLine("-------------------");
            //int ID = int.Parse(Console.ReadLine());
            //string Name= Console.ReadLine();
            //string Email = Console.ReadLine();
            //int GenderID =int.Parse(Console.ReadLine());
            //int age = int.Parse(Console.ReadLine());
            //using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Person;Integrated Security=True"))
            //{
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand($"Update tblPerson set Name='{Name}',Email='{Email}',GenderID={GenderID},age={age} where ID = {ID}", con);
            //    cmd.ExecuteNonQuery();
            //    Console.WriteLine("khdem");
            //}

            Console.WriteLine("-------------------");
            int ID = int.Parse(Console.ReadLine());
            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Person;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"delete from tblPerson where ID = {ID}", con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("khdem");
            }

            Console.WriteLine("-------------------");
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Person;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[tblPerson]", conn);
                using (SqlDataReader Reader = cmd.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        Console.WriteLine(Reader[0] + "\t" + Reader[1] + "\t" + Reader[2] + "\t" + Reader[3] + "\t" + Reader[4]);
                    }
                }
            }


            Console.ReadKey();
        }
    }
}
