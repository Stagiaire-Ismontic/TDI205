using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace zakatp1
{
    public class Library 
    {
        private string libraryname;
        private List<Book> books;
        private List<Customer> customers;

        

        public List<Book> Books
        {
            get
            {
                return books;
            }

            set
            {
                books = value;
            }
        }

        public string Libraryname
        {
            get
            {
                return libraryname;
            }

            set
            {
                libraryname = value;
            }
        }

        public List<Customer> Customers
        {
            get
            {
                return customers;
            }

            set
            {
                customers = value;
            }
        }

        public Library(string libraryname)
        {
            this.Libraryname = libraryname;
            this.Books = new List<Book>();
            this.Customers = new List<Customer>();
        }
        



       
        public void AddBook(int id, string name, string author, DateTime dor)
        {
            foreach (Book book in this.Books)
            {
                if(book.Id == id)
                    throw new Exception("this book is alredy added");
            }
            this.Books.Add(new Book(id, name, author, dor));
        }

        public Book isAvailable(int id)
        {
            foreach (Book book in this.Books)
            {
                if (book.Id == id)
                {
                    return book;
                }

            }
            return null;
        }

        public Customer CustomerAvailable(int id)
        {
            foreach(Customer customer in this.Customers)
            {
                if (customer.Id == id)
                    return customer;
            }
            return null;
        }

        public void RemoveBook(int id)
        {
            var book = isAvailable(id);
            if (book == null)
                throw new Exception("this book doesn't exist");
            else
            {
                this.books.Remove(book);
            }
            
        }

        public void ModifyBook(int id, string name, string author, DateTime dor)
        {
            
            if (isAvailable(id) == null)
                throw new Exception("this book doesn't exist to modify!!");
            

            foreach(Book bk in this.Books)
            {
                if(bk.Id == id)
                {
                    bk.Name = name;
                    bk.Author = author;
                    bk.Dateofrelease = dor;
                }
            }
        }

        public void AddCustomer(int id, string fullname, DateTime dob)
        {
            foreach(Customer customer in this.customers)
            {
                if (customer.Id == id)
                    throw new Exception("this customer is already added");
            }
            this.customers.Add(new Customer(id, fullname, dob));
        }

        public void RemoveCustomer(int id)
        {
            var c = CustomerAvailable(id);
            if (c == null)
                throw new Exception("this customer doesn't exist");
            this.Customers.Remove(c);
        }

        public void ModifyCustomer(int id, string fullname, DateTime dob)
        {
            if (CustomerAvailable(id) == null)
                throw new Exception("this customer doesn't exist");
            foreach(Customer customer in this.Customers)
            {
                if(customer.Id == id)
                {
                    customer.Fullname = fullname;
                    customer.Dob = dob;
                }
            }
        }
    }
}
