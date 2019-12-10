using GestionStagiare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionStagiare
{
   public class GestionStagiare
    {
        public static List<Stagiare> lst = new List<Stagiare>();
         Connection.Connection cn = new Connection.Connection();
        SqlCommand cmd;
        AppContext context = new AppContext();
       
        public GestionStagiare() { }
       public Stagiare Ajouter(Stagiare stagiare)
        {
            

               var p= context.stagiare.Add(stagiare);
                context.SaveChanges();
             
            return p;

        }
        public Stagiare Modifier(Stagiare stagiare)
        {
            var st = context.stagiare.SingleOrDefault(s => s.id == stagiare.id);
            st.CIN = stagiare.CIN;
            st.Nom = stagiare.Nom;
            st.Prenom = stagiare.Prenom;
            context.SaveChanges();
            return st;
        }
        public Stagiare Suprimer(int id)
        {
            var st = context.stagiare.SingleOrDefault(s => s.id == id);
            var stt=context.stagiare.Remove(st);
            context.SaveChanges();
            return stt;
        }
        public List<Stagiare> Afficher()
        {

            return context.stagiare.ToList();
          
        }
    }
}
