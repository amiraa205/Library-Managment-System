using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mangment_System
{
    public abstract class Person
    {
        public string Name { get; set; }
        private int Id;
        public Person(string name, int id)
        {
            Name = name;
            SetID(Id);
            
        }
        private void SetID(int id)
        { 
            this.Id = id;
        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}\nID: {Id}");
        }
    }
}
