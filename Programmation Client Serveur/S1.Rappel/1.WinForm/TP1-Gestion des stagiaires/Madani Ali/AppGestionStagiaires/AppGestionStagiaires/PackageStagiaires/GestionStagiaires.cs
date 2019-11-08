using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TP1.PackageGroupes;
namespace AppGestionStagiaires.PackageStagiaires
{
    public class GestionStagiaires
    {
        private static List<Stagiaire> listeStagiaires = new List<Stagiaire>();

        public GestionStagiaires()
        {
            
        }

        public GestionStagiaires(bool Remplissage)
        {
            for (int i = 1; i <= 3; i++)
                GestionGroupes.ListeGroupes.Add(new Groupe(i,"TDI" + i));

            for (int i = 1; i <= 3; i++)
                listeStagiaires.Add(new Stagiaire(i, "Nom Etudiant " + i, "Prenom Etudiant " + i,GestionGroupes.ListeGroupes[i-1]));
        }

        public void Ajouter(Stagiaire s)
        {
            listeStagiaires.Add(s);
        }

        public void Supprimer(int index)
        {
            listeStagiaires.RemoveAt(index);
        }

        public void Modifier(Stagiaire s)
        {
            foreach (Stagiaire sM in listeStagiaires)
            {
                if (sM.Id == s.Id)
                {
                    sM.Nom = s.Nom;
                    sM.Prenom = s.Prenom;
                    sM.Groupe = s.Groupe;
                }
            }
        }


        public List<Stagiaire> Afficher()
        {
            return listeStagiaires;
        }

        public Stagiaire getStagiaire(int index)
        {
            return listeStagiaires.ElementAt(index);
        }

    }
}
