using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_3
{
    public class GestionnaireControles
    {
        public static int IDCount { get; set; }

        public Controle FindById(int Id)
        {
            using (var context = new Gestion())
            {
                Controle C = context.lst.SingleOrDefault(s=>s.Id==Id);
                return C;
            }
        }

        public bool Insert(Controle C)
        {
            using (var context =new Gestion())
            {
                Controle Cr = FindById(C.Id);
                if (Cr == null)
                {
                    C.Id = ++IDCount;
                    context.lst.Add(C);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public bool Delete(int Id)
        {
            using (var context = new Gestion())
            {
                Controle Cr = FindById(Id);
                if (Cr != null)
                {
                    context.lst.Remove(Cr);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public bool Update(Controle C)
        {
            using (var context = new Gestion())
            {
                Controle Cr = FindById(C.Id);
                if (Cr != null)
                {
                    Cr.Nom = C.Nom;
                    Cr.Note = Cr.Note;
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public List<Controle> Select()
        {
            using (var context = new Gestion())
            {
               return context.lst.ToList();
            }
        }
    }
}
