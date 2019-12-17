using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock
{
    class Article
    {
        private int code_article;
        private string designation;
        private float prix_U;
        private int quantite;

        public int Code_article { get => code_article; set => code_article = value; }
        public string Designation { get => designation; set => designation = value; }
        public float Prix_U { get => prix_U; set => prix_U = value; }
        public int Quantite { get => quantite; set => quantite = value; }

        public Article()
        {

        }
    }
}
