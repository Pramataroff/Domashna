using System;

namespace Zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Semeistvo myFamily = new Semeistvo();
            myFamily.FamilyName = "Pramatarovi";
            Console.Write("Enter how many members: ");
            int count = int.Parse(Console.ReadLine());
            int total = 0;

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter {i + 1} member: ");
                Person current = new Person();
                Console.Write($"Enter name of {i + 1} member: ");
                current.Name = Console.ReadLine();
                Console.Write($"Enter age of {i + 1} person: ");
                current.Age = int.Parse(Console.ReadLine());
                myFamily.Members.Add(current);
            }

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - 1; j++)
                {
                    if (myFamily.Members[j].Age > myFamily.Members[j + 1].Age)
                    {
                        Person temp = myFamily.Members[j];
                        myFamily.Members[j] = myFamily.Members[j + 1];
                        myFamily.Members[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine();

            //a)
            Person oldest = myFamily.Members[count - 1];
            Person youngest = myFamily.Members[0];
            Console.Write("Oldest: ");
            oldest.PrintOldestAndYoungest();
            Console.Write("Youngest: ");
            youngest.PrintOldestAndYoungest();


            //b)
            foreach (Person member in myFamily.Members)
            {
                total += member.Age;
            }

            Console.WriteLine();

            //Pechat
            myFamily.PrintAll();
            Console.WriteLine();
            Console.WriteLine($"Sum of the years: {total}");
        }
    }
}