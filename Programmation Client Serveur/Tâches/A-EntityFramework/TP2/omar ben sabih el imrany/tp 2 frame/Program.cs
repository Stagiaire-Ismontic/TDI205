using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace tp_2_frame
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppContext())
            {
                Console.Write("entrer le nom du client ");
                var name = Console.ReadLine();
                Console.WriteLine("entrer id du client");
                int id = int.Parse(Console.ReadLine());
                var client = new Client { nom = name, id = id };
                db.lst_client.Add(client);
                db.SaveChanges();

                var query = from b in db.lst_client
                            orderby b.nom
                            orderby b.id
                            select b;

                Console.WriteLine("tout les clients presents dans la bdd");
                foreach (var obj in query)
                {
                    Console.WriteLine(obj.nom+" "+obj.id);
                }
                Console.ReadLine();
            }
        }
    }
}
