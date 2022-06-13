/*
This is a simple program that guess the random number and ask the user to
make a random guess and tell the user if their guess is correct or not...

*/
using System;
//namespace
namespace NumGuess
{
    //main class
    class Program
    {
        //entry point method
        static void Main(string[] args)
        {
            //Run GetAppInfo function
            GetAppInfo();

            //Ask Users name and greet
            GreetUser();

            
            while(true){

                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //init guess variable
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //while guess is not correct
                while (guess != correctNumber)
                {
                    //get users input
                    string input = Console.ReadLine();

                    //checking if the input is number
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please enter the actual number");

                        //keep going
                        continue;
                    }

                    //cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");    
                    }
                }

                //output success msg

                //Change text color
                Console.ForegroundColor = ConsoleColor.Green;

                //tell user it is the right number
                Console.WriteLine("CORRECT!!!");

                //Reset text color
                Console.ResetColor();

                //Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                //Get answer
                string ans = Console.ReadLine().ToUpper();

                if(ans == "Y")
                {
                    continue;
                }
                else if(ans == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            //set app variables
            string appName = "NumGuess";
        string appVersion = "1.0.0";
        string appAuthor = "Uvesh Bariwala";

        //Change text color
        Console.ForegroundColor = ConsoleColor.Cyan;

            //Write app information
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            //Ask users name
            Console.WriteLine("Enter your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);

        }

        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;

            //Tell user the number is wrong
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }
    }
}