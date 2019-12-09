using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSta
{
    public class Gestionnaire
    {
        public static List<Stagiaire> ListStagiaire = new List<Stagiaire>();
        public static int CountId;

        public Stagiaire Rechercher(string cin)
        {
            foreach(Stagiaire St in ListStagiaire)
            {
                if (St.Cin == cin)
                {
                    return St;
                }
            }
            return null;
        }

        public bool Ajouter(Stagiaire St)
        {
            Stagiaire s = Rechercher(St.Cin);
            if(s==null)
            {
                St.Id = ++CountId;
                ListStagiaire.Add(St);
                return true;
            }
            return false;
        }

        public bool Supprimer(Stagiaire St)
        {
            Stagiaire s = Rechercher(St.Cin);
            if (s != null)
            {
                ListStagiaire.Remove(s);
                return true;
            }
            return false;
        }

        public bool Modifier(Stagiaire St)
        {
            Stagiaire s = Rechercher(St.Cin);
            if (s != null)
            {
                s.Cin = St.Cin;
                s.Nom = St.Nom;
                s.Date = St.Date;
                s.Gr = St.Gr;
                return true;
            }
            return false;
        }

        public List<Stagiaire> Lis()
        {
            return ListStagiaire;
        }
    }
}
