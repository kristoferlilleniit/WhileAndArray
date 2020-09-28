using System;

namespace GuessMyColor
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int computerNumber = rnd.Next(1, 4);
            bool rightGuess = false;

             /*
             * 1 - red
             * 2 - green
             * 3 - blue
             */

            while(!rightGuess)
            {
                Console.WriteLine("What's my color?");
                string userInput = Console.ReadLine().ToLower();

                if(computerNumber == 1 && userInput == "red")
                {
                    Console.WriteLine("You won.");
                    rightGuess = true;
                }else if(computerNumber == 2 && userInput == "green")
                {
                    Console.WriteLine("You won.");
                    rightGuess = true;
                }else if(computerNumber == 3 && userInput == "blue")
                {
                    Console.WriteLine("You won.");
                    rightGuess = true;
                }else
                {
                    Console.WriteLine("That's not a color");
                }
            }
        }
    }
}
