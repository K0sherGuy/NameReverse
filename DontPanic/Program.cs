using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "K33p C4lm";

            phrase = phrase.Replace('3','e');
            phrase = phrase.Replace('4', 'a');

            Console.WriteLine(phrase);
        }
    }
}
