using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionOne.Services
{
    public class GestionEtablissement
    {
       
            private List<Etablissement> ListEtabliss = new List<Etablissement>();

        public List<Etablissement> ListEtabliss1
        {
            get
            {
                return ListEtabliss;
            }

            set
            {
                ListEtabliss = value;
            }
        }

        public void ajouter(int id, string nom, string des)
            {
                if (recherche(id) == null)
                ListEtabliss1.Add(new Etablissement(id, nom, des));
                else
                    throw new Exception("id existe deja");
            }
            public void suprimer(int id)
            {
            Etablissement E = recherche(id);
                if (E != null)
                ListEtabliss1.Remove(E);
                else
                    throw new Exception("il n'existe pas");

            }

            public void modifier(int id, string nom, string des)
            {
            Etablissement E = recherche(id);
                if (E == null)
                    throw new Exception("n'existe pas");
                else
                {
                    E.Etabli_Nom1 = nom;
                    E.Etabli_Des1 = des;
                }

            }

            public Etablissement recherche(int id)
            {
                foreach (Etablissement e in ListEtabliss1)
                {
                    if (e.Etabli_Id1 == id)
                    {
                    return e;
                    }
                }
                return null;
            }
        }
    
}
