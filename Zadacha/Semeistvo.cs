using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha
{
    public class Semeistvo
    {
        private string familyName;
        public string FamilyName
        {
            get
            {
                return familyName;
            }
            set
            {
                familyName = value;
            }
        }

        private List<Person> members = new List<Person>();
        public List<Person> Members
        {
            get
            {
                return members;
            }
            set
            {
                members = value;
            }
        }

        public void PrintAll()
        {
            Console.WriteLine($"Family: {this.FamilyName}");
            foreach (Person item in this.Members)
            {
                item.Intruduce();
            }
        }
        public void PrintYoungest()
        {
            int minage = int.MaxValue;
            Person youngest = new Person();
            foreach (Person item in this.Members) 
            {
                if (item.Age < minage)
                {
                    minage = item.Age;
                    youngest = item;
                }
            }
            Console.WriteLine($"Yongest person from the family is ");
            youngest.Intruduce();
        }
        public void PrintOldest()
        {
            int minage = int.MinValue;
            Person youngest = new Person();
            foreach (Person item in this.Members)
            {
                if (item.Age > minage)
                {
                    minage = item.Age;
                    youngest = item;
                }
            }
            Console.WriteLine($"Oldest person in the family is ");
            youngest.Intruduce();
        }
    }
}