//Most of the comments are in english, I however write test dialogues in French my personal understanding.
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Variable : camelCase
            int number = 1;
            //Constant : PascalCase
            const float Pi = 3.14f;

            Console.WriteLine(number);
            Console.WriteLine(Pi);
            //String template filled with variables
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            
            //Basic test of overflowing a variable
            try
            {
                checked
                {
                    byte maxByte = byte.MaxValue;
                    maxByte++;
                    Console.WriteLine(maxByte);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception volontaire : " + e.Message);
                // Removed throw; to avoid catch stopping the script
            }
            
            //Simple console prompt asking users' name
            Console.WriteLine("\nQuel est votre nom ?");
            string userName = Console.ReadLine();
            
            //More complex console prompt using switch cases
            Console.WriteLine("\nBonjour, {0} !", userName);
            Console.WriteLine("\nQuel est votre genre ?");
            Console.WriteLine("\n1. HOMME");
            Console.WriteLine("\n2. FEMME");
            Console.WriteLine("\n3. HELICO DE COMBAT");
            string userGender = Console.ReadLine();
            switch (userGender)
            {
                case "1":
                    Console.WriteLine("Bonjour MONSIEUR.");
                    break;
                case "2":
                    Console.WriteLine("Bonjour MADAME.");
                    break;
                case "3":
                    Console.WriteLine("Bonjour HELICO.");
                    break;
            }

        }

    }
}