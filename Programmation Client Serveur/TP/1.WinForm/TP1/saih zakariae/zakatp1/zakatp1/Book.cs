using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zakatp1
{
    public class Book
    {
        private int id;
        private string name;
        private string author;
        private DateTime dateofrelease;
        

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

        public DateTime Dateofrelease
        {
            get
            {
                return dateofrelease;
            }

            set
            {
                dateofrelease = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
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

        public Book(int id, string name, string author, DateTime dor)
        {
            this.Id = id;
            this.Name = name;
            this.Author = author;
            this.Dateofrelease = dor;
        }
    }
}
