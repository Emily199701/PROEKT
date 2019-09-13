using System;

namespace ПРОЕКТ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name:");
            string firsName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Hello, {0} {1} ", firsName, lastName);
            Console.ReadKey();
        }
    }
}
