using System;

namespace NameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter Your Name: ");
            name = Console.ReadLine();
            int nameLength = name.Length;

            for (int i = nameLength - 1; i >= 0; i--)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}
