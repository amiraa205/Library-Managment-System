using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mangment_System
{
    public class Novel : Books
    {
        public string Genre { get; set; }

        public Novel(string title, string author, string isbn, int publication, int pages,string genre,bool available)
            : base(title, author, isbn, publication, pages, available)
        {
            Genre = genre;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Genre: {Genre}");
        }

        public void Borrow()
        {
            Console.WriteLine($"Novel '{Title}' has been borrowed.");
        }

        public void Return()
        {
            Console.WriteLine($"Novel '{Title}' has been returned.");
        }
    }

}
