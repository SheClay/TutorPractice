using System;

namespace VowelConsonant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a letter: ");
            string userInput = Console.ReadLine();
            char myLetter = Convert.ToChar(userInput);
        }
    } 

}
