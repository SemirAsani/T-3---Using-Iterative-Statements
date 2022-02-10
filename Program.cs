using System;

namespace T_3___Using_Iterative_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user for input between the 5 and 25 range
            Console.WriteLine("Enter a value between 5 and 25 to see conversions");
            string input = Console.ReadLine();
            int inputVal = int.Parse(input);
            //condition for the user input value to be between 5 and 25
            if ((inputVal > 5) && (inputVal < 25))
            {
                //display the first line of the table
                Console.WriteLine("0 CAD = 0 USD");
                //while loop to prevent iterations from exceeding 200
                while (inputVal <= 200)
                {
                    //conversion to American dollars from Canadian
                    double usd = inputVal * 0.792367;
                    Console.WriteLine(inputVal.ToString() + " CAD = " + usd + " USD");
                    //increments CAD table by 10
                    inputVal += 10;
                }
            }
            //else statement for any input scenario that is not a valid number between 5 and 25
            else
            {
                Console.WriteLine("Enter a valid number");
            }
        }
    }
}