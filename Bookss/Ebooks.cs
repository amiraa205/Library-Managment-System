using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mangment_System
{
    public class Ebooks : Books
    {
        public Ebooks(string title, string author, string isbn, int publication, int pages,bool available)
            : base(title, author, isbn, publication, pages, available)
        {
        }

        public void Borrow()
        {
            Console.WriteLine($"Ebook'{Title}' has been borrowed.");
        }

        public void Return()
        {
            Console.WriteLine($"Ebook '{Title}' has been returned.");
        }

        public void PrintPages(int startPage, int endPage)
        {
            int pageDifference = endPage - startPage;
            int maxPage = 1000;
            if (pageDifference < maxPage && endPage > Pages)
            {
                Console.WriteLine($"Printing from pages {startPage} to {endPage} of the textbook: {Title}");
                // Additional logic for printing the specified pages
            }
            else
            {
                Console.WriteLine("Error: Cannot print more than 1000 pages.");
            }
        }
    }
}
