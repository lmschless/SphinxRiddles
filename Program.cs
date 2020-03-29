using System;
using System.Collections.Generic;
namespace SphinxRiddles
{
    class Program
    {
        //public string answerOne = "blue";
        //public string answerTwo = "green";

        static void Main()
        {
            Console.WriteLine("Hello World!");
            RiddleOne();
        }

        // void GetAnswer()
        //{
        //    string guess = Console.ReadLine();
        //    string fixedGuess = guess;
        //}

        public static void RiddleOne()
        {
            Console.WriteLine("What is the color of the sky?");

            string guess = Console.ReadLine();
            while (guess.ToLower() != "blue") {
                Console.WriteLine("You answered incorrectly, try again!");
                Console.WriteLine("What is the color of the sky?");
                guess = Console.ReadLine();
            }
            RiddleTwo();
            
        }

        public static void RiddleTwo()
        {
            Console.WriteLine("What is the color of the grass?");
            string guess = Console.ReadLine();
            if (guess.ToLower() == "green")
            {
                Console.WriteLine("You won! Play Again? (Y,N)?");
                if(Console.ReadLine().ToUpper() == "Y")
                {
                    RiddleOne();
                }
                else
                {
                    Console.WriteLine("Thank you, goodbye.");
                }
            }
            else
            {
                Console.WriteLine("You answered incorrectly, try again!");
            }
        }
    }
}
