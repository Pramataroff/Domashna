using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha
{
    public class Person
    {
        private string name;
        private int age;

        public string Name { get { return name; } set { this.name = value; } }



        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 117)
                {
                    Console.WriteLine("Invalid years!");
                    this.age = 0;
                }
                else
                {
                    this.age = value;
                }

            }
        }

        public void Intruduce()
        {
            Console.WriteLine($"I am {this.name} and I am {this.age} old.");
        }
        public void PrintOldestAndYoungest()
        {
            Console.WriteLine($"Name: {Name}, Years: {Age}");
            Console.WriteLine();
        }
    }
}