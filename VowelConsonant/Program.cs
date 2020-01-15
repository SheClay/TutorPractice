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

            //if letter is a,e,i,o,u then it is a vowel.
            //otherwise say it is a consonant.

            if (myLetter == 'a' || myLetter == 'e' || myLetter == 'i' || myLetter == 'o' || myLetter == 'u')
            {
                Console.WriteLine("This is a vowel.");
            }
            else
            {
                Console.WriteLine("This is a consonant.");
            }

                
        
        }
        

    } 

}
