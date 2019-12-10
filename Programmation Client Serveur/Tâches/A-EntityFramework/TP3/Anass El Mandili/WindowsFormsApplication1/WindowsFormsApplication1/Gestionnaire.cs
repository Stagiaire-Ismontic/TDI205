using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public  class Gestionnaire
    {
        public  Model1 DB = new Model1();
       
        public  void UpdateEtudiant(Etudiant E)
        {
            if (DB.Etudiant.Find(E.Id) != null)
            {
                Etudiant Et = DB.Etudiant.Find(E.Id);
                Et.Id = E.Id;
                Et.Etud_Name = Et.Etud_Name;
                Et.Etud_Tel = E.Etud_Tel;
                DB.SaveChanges();
            }
        }
        public  void AddEtudiant(Etudiant E)
        {     
            DB.Etudiant.Add(E);        
            DB.SaveChanges();
         
        }
        public  void DeleteEtudiant( int Id)
        {
            if (DB.Etudiant.Find(Id) != null)
            {
                DB.Etudiant.Remove(DB.Etudiant.Find(Id));
                DB.SaveChanges();
            }
        }
    }
}
