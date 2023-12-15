using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mangment_System
{
    public class Library
    {
        private List<Books> _books;
        private List<Person> _persons;

        public List<Books> Books
        {
            get { return _books; }
        }

        public List<Person> Persons
        {
            get { return _persons; }
        }

        public Library()
        {
            _books = new List<Books>();
            _persons = new List<Person>();
        }

        public void AddBook(Books book)
        {
            if (IsUniqueISBN(book.Isbn))
            {
                _books.Add(book);
                Console.WriteLine($"Book added successfully: {book.Title}");
            }
            else
            {
                Console.WriteLine("A book with the same ISBN already exists in the library.");
            }
        }

        public void RemoveBook(Books book)
        {
            if (_books.Contains(book))
            {
                _books.Remove(book);
                Console.WriteLine($"Book removed: {book.Title}");
            }
            else
            {
                Console.WriteLine("Book not found in the library.");
            }
        }

        public void BorrowBook(Books book, Person person)
        {
            Console.WriteLine($"{person.Name} borrowed the book: {book.Title}");
        }

        public void ReturnBook(Books book, Person person)
        {
            Console.WriteLine($"{person.Name} returned the book: {book.Title}");
        }

        public void PrintBooks()
        {
            foreach (var book in _books)
            {
                book.DisplayInfo();
                Console.WriteLine();
            }
        }

        private bool IsUniqueISBN(string isbn)
        {
            foreach (Books book in _books)
            {
                if (book.Isbn == isbn)
                {
                    return false;
                }
            }
            return true;
        }

        public void AddPerson(Person person)
        {
            _persons.Add(person);
            Console.WriteLine($"Person added: {person.Name}");
        }

        public void RemovePerson(Person person)
        {
            if (_persons.Contains(person))
            {
                _persons.Remove(person);
                Console.WriteLine($"Person removed: {person.Name}");
            }
            else
            {
                Console.WriteLine("Person not found in the library.");
            }

        }

       
    }

}
