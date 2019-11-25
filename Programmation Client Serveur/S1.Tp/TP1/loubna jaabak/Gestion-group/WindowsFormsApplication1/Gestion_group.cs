using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Gestion_group:Group
    {
       public int nbStg;
        int i;
        List<Gestion_group> listGroup = new List<Gestion_group>();

        public int NbStg
        {
            get
            {
                return nbStg;
            }

            set
            {
                nbStg = value;
            }
        }

        public List<Gestion_group> ListGroup
        {
            get
            {
                return listGroup;
            }

            set
            {
                listGroup = value;
            }
        }

        public Gestion_group() { }

        public Gestion_group(int numero,string nom,int nbStg):base(numero,nom)
        {
            this.nbStg = nbStg;
        }

        public void Ajouter(Gestion_group Gg)
        {
            ListGroup.Add(Gg);
        }

        public int rechercher(int idG)
        {
            int nb=0;
            
            for(i=0;i<listGroup.Count;i++)
            {
                if (listGroup[i].Numero == idG)
                {
                    nb = i;
                }
               
            }

            return nb;
        }

        public void modifier(int idG,int num,string nom)
        {
            int nb = rechercher(idG);
            if (nb != 0)
            {

                listGroup[nb].Numero = num;
                listGroup[nb].Nom = nom;
                MessageBox.Show("la modification terminer avec succes");

            }
            else
            {
                MessageBox.Show("le Group n'existe pas !!!!!");
            }

        }


        public void supprimer(int idG)
        {
            int nb = rechercher(idG);
            if (nb != 0)
            {

                listGroup[nb] = listGroup[nb + 1];
            
                MessageBox.Show("la suppression terminer avec succes");

            }
            else
            {
                MessageBox.Show("le Group est deja supprimer !!!!!");
            }

        }




    }
}
