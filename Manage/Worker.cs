using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mangment_System
{
    public class Worker: Person
    {
        public Worker(string name, int Id): base(name, Id) 
        {
        }
        public void Check(Books book, Customer customer)
        {
            if (book.Available)
            {
                Console.WriteLine($"Librarian {Name} checked book '{book.Title}' to Customer {customer.Name}.");
                book.Available = false;
                
            }
            else
            {
                Console.WriteLine($"Sorry, '{book.Title}' is not available for check.");
            }

        }
        public void AddBook(Books book)
        {
            if (book.Available)
            {
                Console.WriteLine($"{Name} has added: {book} ");
            }
        }
        public void RemoveBook(Books book)
        {
            if (book.Available)
            {
                Console.WriteLine($"{Name} has removed: {book} ");
            }
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"Librarian Name: {Name} has ckecked");
        }



    }
}
