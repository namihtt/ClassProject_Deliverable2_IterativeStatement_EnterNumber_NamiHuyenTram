using System;

namespace ClassProject_Deliverable2_IterativeStatement_EnterNumber_NamiHuyenTram
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Programmer: (Nami) Huyen Tram
             Date: 9/12/2019
             Comments: ISM 4300.001F19 - Class Project - Deliverable 2 - Iterative Statement
            */

            // declare variables
            string responde;
            int input;
            int i = 1;

            // Ask user for a Yes/No question
            Console.Write("Would you like to see something cool? ");

            // take user input
            responde = Console.ReadLine();

            // conditional statements based on user input
            if (responde == "Yes")
            {
                Console.WriteLine("Cool! Let's do it!");
            }
            else if (responde == "No")
            {
                Console.Write("I've just asked to be polite. You don't have a choice here! ");
            }
            else
            {
                Console.WriteLine("Is that how you say Yes in your language? Cool! Let's do it!");
            }

            // try catch to keep the program not crash with invalid input from the user
            try
            {

                // ask for user input
                Console.Write("Enter a number between 1 and 100: ");

                // take user input and converse string type to integer type
                input = int.Parse(Console.ReadLine());

                // call custom method DisplayInput
                DisplayInput();

                // this custom method make sure the number fall into the range of 1 to 100
                void DisplayInput ()
                {
                    // conditional statement to make sure user input fall in the range of 1 to 100.
                    if (input >= i && input <= 100)
                    {
                        // for loop to repeat the message
                        for (i = 1; input >= i && input <= 100; i++)
                        {
                            Console.WriteLine("You have entered " + input.ToString() +
                                " .This is the current integer value in the loop: " + i);
                        }
                    }

                    // if user input fall out of the range, ask for another input
                    else
                    {
                        Console.Write("Please only enter number from 1 to 100: ");

                        // read the new input and converse data type
                        input = int.Parse(Console.ReadLine());

                        // call DisplayInput to recheck and display accordingly
                        DisplayInput();
                    }
                }
            } // end of try
            catch
            {
                Console.WriteLine("Your input was invalid. Please run the program again and only enter number from 1 to 100!");
            } // end of catch

            // Instruct user to close the window
            Console.WriteLine("Now press any key to exit.");

            // keep the program not stopping and wait for user input to close the window
            Console.ReadKey(true);
        }
    }
}
