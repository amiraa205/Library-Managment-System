using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mangment_System
{
    public class Customer: Person
    {
        private List<Books> _BorrowedBooks {  get; set; }
        public Customer(string name, int id): base(name,id)
        {
            _BorrowedBooks = new List<Books>();
        }
        public void Borrow(Books book)
        {
            if (book.Available)
            {
                _BorrowedBooks.Add(book);
                Console.WriteLine($"{Name} has borrowed the book: {book.Title}");
                book.Available = false;
            }
            else
            {
                Console.WriteLine($"Sorry, {book.Title} is not available for borrowing.");
            }
            
            
        }
        public void Return(Books book)
        {
            if (_BorrowedBooks.Contains(book))
            {
                _BorrowedBooks.Remove(book);
                Console.WriteLine($"{Name} has returned the book: {book.Title}");
                book.Available = true;

            }
            
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"Customer Name: {Name}\n is borrowing or returning the book.");
        }
    }
}
