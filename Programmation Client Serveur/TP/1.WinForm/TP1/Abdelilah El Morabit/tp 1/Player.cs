using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_1
{
    public class Player
    {
        private int id;
        private int number;
        private string name;
        private double salaier;

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public double Salaier
        {
            get
            {
                return salaier;
            }

            set
            {
                salaier = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public Player(int id,string name ,int num,double salaier)
        {

            Id=id;
            Name = name;
            Number = num;
            Salaier = salaier;
        }
    }
}
