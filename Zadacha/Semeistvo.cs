using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}