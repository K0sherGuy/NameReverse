using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string name;
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            int length = name.Length;


            length = rnd.Next(0, length);


            Console.WriteLine(name[length]);
            Console.WriteLine(length + 1);
        }
    }
}
