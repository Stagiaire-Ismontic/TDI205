using Microsoft.VisualStudio.TestTools.UnitTesting;
using GestionStagiaires.PackageGroupes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStagiaires.PackageGroupes.Tests
{
    [TestClass()]
    public class GestionGroupesTests
    {
        [TestMethod()]
        public void AjouterTest()
        {
            GestionGroupes gestionGroupes = new GestionGroupes();
            Groupe g = new Groupe();
            g.Nom = "Groupe 1";
            g.Id = 1;

            int nombre_ligne = gestionGroupes.Ajouter(g);

            //if (nombre_ligne == 0)
            //    throw new Exception();

            Assert.AreEqual(nombre_ligne, 1);
             
        }
    }
}