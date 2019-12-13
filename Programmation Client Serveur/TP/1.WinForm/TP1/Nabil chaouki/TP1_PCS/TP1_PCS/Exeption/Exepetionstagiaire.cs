using System;
using System.Collections.Generic;
using System.Text;

namespace TP1_PCS.Exeption
{
   public class Exepetionstagiaire:Exception
    {
        public Exepetionstagiaire(string message):base(message)
        {
            message = ("error 404");
        }
    }
}
