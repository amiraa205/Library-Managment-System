using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mangment_System
{
    public class Comic : Books
    {
        public string Artist { get; set; }

        public Comic(string title, string author, string isbn, int publicationYear, int pages, string artist , bool available)
            : base(title, author, isbn, publicationYear, pages, available)
        {
            Artist = artist;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Artist: {Artist}");
        }

        public void Borrow()
        {
            Console.WriteLine($"Comic '{Title}' has been borrowed.");
        }

        public void Return()
        {
            Console.WriteLine($"Comic '{Title}' has been returned.");
        }
    }
}
