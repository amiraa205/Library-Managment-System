using System;
using Library_Mangment_System;
using Library_Mangment_System;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        Books book1 = new Comic("The Amazing Spider-Man", "Stan Lee", "978-1302920096", 1963, 230, "Steve Ditko", true);
        Books book2 = new Novel("To Kill a Mockingbird", "Harper Lee", "978-0061120084", 1960, 150, "Classic", true);
        Books book3 = new Ebooks("Introduction to Computer Science", "John Smith", "978-0123456789", 2021, 98,false);
        Books book4 = new ResearchPaper("Research Paper on Artificial Intelligence", "Jane Doe", "978-0987654321", 2022, 430, true);

        Person customer1 = new Customer("Ali", 1);
        Person librarian1 = new Worker("Mohammed", 2);

        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);
        library.AddBook(book4);

        Console.WriteLine("Library Contents:");
        library.PrintBooks();

        library.RemoveBook(book2);

        Console.WriteLine("Updated Library Contents:");
        library.PrintBooks();

        library.AddPerson(customer1);
        library.AddPerson(librarian1);

        library.PrintBooks();

        Customer customer = (Customer)customer1;
        customer.Borrow(book2);

        Worker librarian = (Worker)librarian1;
        librarian.RemoveBook(book1);

        Console.WriteLine("Updated Library Contents:");
        library.PrintBooks();

        // Create a TextBook instance
        Ebooks textbook = new Ebooks("Introduction to Computer Science", "John Smith", "978-0123456789", 2021, 530,true);

        // Print pages from 10 to 20
        textbook.PrintPages(11, 20);
        // Should return an error - page limit is 10
        textbook.PrintPages(5, 20);

    }
}