using System;

namespace Remove_vowel_alphapitic_from_word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your word : ");
            string[] word = new string[1];                    // To available turn it to char array
            word[0] = Console.ReadLine();
            
           char[]  X = word[0].ToCharArray();           // Turn string array to char array

            for (int i=0; i < X.Length; i++)                   // X.Length: is a number of characters 
            {
                if (X[i] == 'a' || X[i] == 'u' || X[i] == 'e' || X[i] == 'i' || X[i] == 'o') // exclude the alphapitic vowels
                {
                    X[i] = '_';
                }
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
 
            for (int j =0; j< X.Length; j++)                 // Display the result
            {
                Console.Write(X[j]);
            }
            Console.WriteLine();
        }
    }
}
