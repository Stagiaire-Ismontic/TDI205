using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_stagiaire_tp1
{
    public class GestionSt
    {
        public static List<Stagiaire> lstStagiaire = new List<Stagiaire>();

        public Stagiaire Rechercher(string cin)
        {
            foreach (Stagiaire St in lstStagiaire)
            {
                if (St.Cin == cin)
                {
                    return St;
                }
            }
            return null;
        }

        public bool Ajouter(Stagiaire st)
        {
            Stagiaire s = this.Rechercher(st.Cin);
            if (s == null)
            {
                lstStagiaire.Add(st);
                return true;
            }
            return false;
        }

        public bool Supprimer(Stagiaire st)
        {
            Stagiaire s = this.Rechercher(st.Cin);
            if (s != null)
            {
                lstStagiaire.Remove(s);
                return true;
            }
            return false;
        }

        public bool Modifier(Stagiaire St)
        {
            Stagiaire s = this.Rechercher(St.Cin);
            if (s != null)
            {
                s.NomComple = St.NomComple;
                s.Date = St.Date;
                s.Groupe = St.Groupe;
                return true;
            }
            return false;
        }

        public List<Stagiaire> Get()
        {
            return lstStagiaire;
        }

    }
}
