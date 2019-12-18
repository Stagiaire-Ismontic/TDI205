using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zakatp1
{
    public class Customer
    {
        private int id;
        private string fullname;
        private DateTime dob;
        private int age;

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

        public string Fullname
        {
            get
            {
                return fullname;
            }

            set
            {
                fullname = value;
            }
        }

        public DateTime Dob
        {
            get
            {
                return dob;
            }

            set
            {
                dob = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public Customer(int id, string fullname, DateTime dob)
        {
            this.Id = id;
            this.Fullname = fullname;
            this.Dob = dob;
            this.Age = DateTime.Now.Year - this.Dob.Year;
        }

       
    }
}
