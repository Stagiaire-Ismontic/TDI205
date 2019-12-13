using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkVK
{
    class Program
    {
        static void Main(string[] args)
        {
            using (GestionPatientsEntities db = new GestionPatientsEntities())
            {
                List<Patient> lsPatients = db.Patients.ToList();
                foreach( var item in lsPatients)
                {
                    Console.WriteLine(item.Nom);
                }
            }
            using (var context = new GestionPatientsEntities())
            {
                var std = context.Patients.First<Patient>();
                context.Patients.Remove(std);

                context.SaveChanges();
                Console.WriteLine("supprimer avec succes");
            }
            Console.ReadLine();
        }
    }
}
