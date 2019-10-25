using System;

namespace RollTheDice
{
    class Program
    {

        static void Main(string[] args)
        {
            Greeting();
        }

        public static void Greeting()
        {
            Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? (y/n):");
            string greetingInput = Console.ReadLine();

            if (greetingInput == "y")
            {
                Randomizer();
            }
            else {
                Console.WriteLine("Better luck next time");
            }

        }

        public static void Randomizer()
        {
            Console.WriteLine("How many sides on each die?");

            string input = Console.ReadLine();
            int numberOfSides = int.Parse(input);

            Random rnd = new Random();
            int random1 = rnd.Next(1, numberOfSides);
            int random2 = rnd.Next(1, numberOfSides);

            if (random1 == 1 && random2 == 1)
            {
                Console.WriteLine("Snake eyes!");
            }
            if (random1 == 6 && random2 == 6)
            {
                Console.WriteLine("Boxcars!");
            }
                Console.WriteLine("You Rolled:");
                Console.WriteLine(random1);
                Console.WriteLine(random2);



            Console.WriteLine("Would you like to play again? Y/N");
            string playAgain = Console.ReadLine();

            if (playAgain == "y")
            {
                Randomizer();
            }
            else {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
