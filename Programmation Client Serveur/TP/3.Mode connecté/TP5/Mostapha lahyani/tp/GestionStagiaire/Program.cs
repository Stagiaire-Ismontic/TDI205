using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStagiaire
{
    class Program
    {
        static void Main(string[] args)
        {

            GestionClientt gs = new GestionClientt();
            List<Client> lst = gs.afficher();


            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");




            bool exit = true;
            do
            {
                int choix;
                Console.WriteLine("1.pour ajouter\n2.pour update\n3.pour delete\n4.pour recherche\n5.pour afficher\n6 pour quitter\n");
                choix = int.Parse( Console.ReadLine());
                switch (choix)
                {
                    case 1:
                        {
                            string cin; int id; string nom; string prenom; int nb_phone; string email;
                            Console.WriteLine("entrer tout les info suivant: ");
                            Console.Write("CIN : ");
                            cin = Console.ReadLine();
                            Console.Write("ID : ");
                            id = int.Parse(Console.ReadLine());
                            Console.Write("Nom : ");
                            nom = Console.ReadLine();
                            Console.Write("PRENOM : ");
                            prenom = Console.ReadLine();
                            Console.Write("NB-Phone: ");
                            nb_phone = int.Parse(Console.ReadLine());
                            Console.Write("Email : ");
                            email = Console.ReadLine();
                            Client c = new Client(cin, id, nom, prenom, nb_phone, email);
                             gs.Ajouter(c);
                            break;
                        }

                    case 2:
                        {
                            string cin;int id; string nom; string prenom; int nb_phone;string email;
                            Console.WriteLine("entrer tout les info suivant: ");
                            Console.Write("CIN : ");
                            cin = Console.ReadLine();
                            Console.Write("ID : ");
                            id = int.Parse(Console.ReadLine());
                            Console.Write("Nom : ");
                            nom = Console.ReadLine();
                            Console.Write("PRENOM : ");
                            prenom = Console.ReadLine();
                            Console.Write("NB-Phone");
                            nb_phone=int.Parse(Console.ReadLine());
                            Console.Write("Email : ");
                            email = Console.ReadLine();
                            Client c = new Client(cin,id,nom, prenom,nb_phone,email);
                            gs.Modifie(c);
                            break;
                        }
                    case 3:
                        {
                            int id;
                            Console.WriteLine("entrer le Id de Client  ");
                            Console.WriteLine("id : ");
                            id = int.Parse(Console.ReadLine());
                            gs.Delete(id);
                            break;
                        }
                    case 4:
                        {
                            int id;
                            Console.WriteLine("entrer le Id de Client  ");
                            Console.WriteLine("id : ");
                            id = int.Parse(Console.ReadLine());
                            gs.affiche2(id);
                            break;
                        }
                    case 5:
                        {
                            foreach (Client st in lst)
                            Console.WriteLine($"CIN :{st.Cin}" + "\t" + $"Id :{st.Id}" + "\t" + $"le nom est : {st.Fname}" + "\t" + $"Prenom : {st.Lname}" + "\t" + $"Nb_phone : {st.Nb_Phone}" + "\t" + $"Email : {st.Email}");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("baaaaaaaaaaaay!!");
                            Environment.Exit(0);
                            break;
                        }
                            default:
                        break;
                        
                }

            } while (exit);
            Console.ReadKey();
        }
    }
}
