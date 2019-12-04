using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entite
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SchoolEntities db = new SchoolEntities())
            {
                List<Student> lst = db.Students.ToList();

                //////Insert into Table Student
                //using (var context = new SchoolEntities())
                //{
                //   Student st= new Student() { IdStudent = 5, NomS = "koko", GroupeId = 1 };
                //    context.Students.Add(st);
                //    context.SaveChanges();
                //}


                ////Delete from table Student
                //using (var context = new SchoolEntities())
                //{
                //    var st = context.Students.SingleOrDefault(s => s.IdStudent == 5);
                //    context.Students.Remove(st);
                //    context.SaveChanges();
                //}


                ////Update into table Student
                //using (var context = new SchoolEntities())
                //{
                //    var st = context.Students.SingleOrDefault(s => s.IdStudent == 1);
                //    st.Groupe = null;
                //    st.GroupeId = 1;
                //    st.NomS = "mohamed";
                //    context.SaveChanges();
                    
                //}

                ////Select from Table Student
                //foreach (var I in lst)
                //{
                //    Console.WriteLine(I.NomS);
                //}
                Console.ReadKey();
            }
        }
    }
}
