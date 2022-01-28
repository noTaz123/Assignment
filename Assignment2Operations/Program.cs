using System;

namespace Assignment2Operations
{
    /*Your assignment this week is to write a C# program where you create an integer variable, 
       * and use it in the specified operations below. You'll need to print out the results (see 
       * 'Expected Output' below).
          Test data:
          -1 + 4 * myVar
          ( 35+ 5 ) % myVar
          14 + -4 * 6 / 12
          2 + 12 / 6 * 1 - myVar % 2

          Lastly, if the result of 'myVar * myVar' is less than 10, print out "myVar is less than 4"; 
          otherwise, print out "myVar is greater than 4".
          Expected Output(if myVar is 7):
          27
          5
          12
          3
          myVar is greater than 4
          */

    class Program
    {
        static void Main(string[] args)
        {
            //declaring the variables
            string value;
            int myVal;
            bool TestVal;

            //Program Description
            Console.WriteLine("*************************************************************");
            Console.WriteLine("  This Program takes a user entered integer, peforms a \n " +
                              " number of operations and gives the output of operation.\n " +
                              " It then determines if the number entered is greater than.\n " +
                              " less than or equal to 4.");
            Console.WriteLine("*************************************************************");
            //Program instruction
            Console.Write("Please enter an interger value: ");
            //Reading the user input
            value = Console.ReadLine();
            //Testing value to ensure it is an int
            TestVal = int.TryParse(value, out myVal);

            //If user entered value is an integer perform instructions
            if (TestVal == true)
            {
                int val1 = -1 + 4 * myVal;
                int val2 = (35 + 5) % myVal;
                int val3 = 14 + -4 * 6 / 12;
                int val4 = 2 + 12 / 6 * 1 - myVal % 2;
                Console.WriteLine("These are the output:");
                Console.WriteLine(val1 + Environment.NewLine + val2 + Environment.NewLine + val3 + Environment.NewLine + val4 + Environment.NewLine);
                //nestled if statement to determine if user value is greater than, less than or equal to four
                if (myVal * myVal < 10)
                {
                    Console.WriteLine("The magnitude of your number, myVal is less than 4.\nHowever, this program can't determine if it is a positive or negative integer.\n");

                }
                else if (myVal * myVal == 16)
                {
                    Console.WriteLine("The magnitude of your number, myVal is 4.\nHowever, this program can't determine if it is a positive or negative integer.\n");
                }
                else
                {
                    Console.WriteLine("The magnitude of your number, myVal is greater than 4.\nHowever, this program can't determine if it is a positive or negative integer.\n");
                }
            }
            //if user entered value is not an integer, execute this code
            else
            {
                Console.Write("Please read the instructions carefully and try again.\n");
            }
        }
    }
}
