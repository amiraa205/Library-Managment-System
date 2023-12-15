using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mangment_System
{
    public class Books
    {
        private string _title;
        private string _author;
        private string _isbn;
        private int _publication;
        private int _pages;
        private bool _available;


        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        public string Isbn
        {
            get { return _isbn; }
            private set { _isbn = value; }
        }
        public int Publication
        {
            get { return _publication; }
            set { _publication = value; }

        }
        public int Pages
        {
            get { return _pages; }
            set { _pages = value; }
        }
        public bool Available
        {
            get { return _available; }
            set { _available = value; }
        }
        public Books(string title, string author, string isbn, int publication, int pages, bool available)
        {
            this.Title = title;
            this.Author = author;
            this.Isbn = isbn;
            this.Publication = publication;
            this.Pages = pages;
            this.Available = available;
        }
        public void Availability(bool status)
        {
            this.Available = status;
            Console.WriteLine($"Availablitity of {this.Title} is {(status ? "available" : "not available")}");
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title: {this.Title} Author: {this.Author} ISBN: {this.Isbn} Publication: {this.Publication} IsAvailable: {(this.Available ? "Yes" : "Not")}\n");
        }
        

    }
}
