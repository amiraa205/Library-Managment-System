using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mangment_System
{
    public class ResearchPaper : Books
    {
        public ResearchPaper(string title, string author, string isbn, int publicationYear, int pages, bool available)
            : base(title, author, isbn, publicationYear, pages, available)
        {
        }

        public void PrintPages(int startPage, int endPage)
        {
            int pageDifference = endPage - startPage;
            int maxPage = 10;
            if (pageDifference < maxPage && endPage > Pages)
            {
                Console.WriteLine($"Printing from pages {startPage} to {endPage} of the textbook: {Title}");
                // Additional logic for printing the specified pages
            }
            else
            {
                Console.WriteLine("Error: Cannot print more than 10 pages.");
            }
        }
    }


}
