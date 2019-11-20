using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;
using Tp1.BL;

namespace Tp1
{
    
     public class ListeStagiare: IInstitut<Stagiare>
    {
         public static List<Stagiare> lst1;
        public int Count { get { return lst1.Count; } }
        public ListeStagiare()
        {
            lst1 = new List<Stagiare>();
        }

        public void Ajouter (Stagiare s)
        {
            lst1.Add(s);
           
        }
         public void suprimer (int num)
        {

          lst1.Remove(rechercher(num));
        }

        public void update (Stagiare st,int num)
        {

            var stg = lst1.SingleOrDefault(s => s.NumStagiare == num);
            stg = st;
           
        }

        public Stagiare rechercher(int num)
        {
            return lst1.SingleOrDefault(s => s.NumStagiare == num);
        }

     
      
    }
}
