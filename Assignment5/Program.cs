using System;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            ProblemOne();
            ProblemTwo();
            ProblemThree();
            ProblemFour();
            ProblemFive();
        }

        static void ProblemOne()
        {
            Console.WriteLine("*********************************************************************");
            Console.WriteLine(" A program to count how many numbers between 1 and 100 are divisible");
            Console.WriteLine(" by 3 with no remainder. Display the count on the console.");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("");

            int j = 0;
            for(int i = 1; i<100; i++)
            {
                if (i % 3 == 0)
                    j++;
            }
            Console.WriteLine("There are " + j + " numbers that are divisible by 3.");
            Console.WriteLine("\n");
        }

        static void ProblemTwo()
        {
            Console.WriteLine("Would you like to clear the console 'y' or 'n': ");
            string ans = Console.ReadLine();
            if (ans == "y")
            {
                Console.Clear();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*********************************************************************");
            Console.WriteLine(" A program that continuously asks the user to enter a number or 'ok'");
            Console.WriteLine(" to exit. It calculates the sum of all the previously entered numbers");
            Console.WriteLine(" and displays it on the console.");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("");

            string value = "no";
            bool lcontinue = true;
            int sum = 0;
            
            do
            {
                
                Console.ForegroundColor = ConsoleColor.DarkGreen;
               
                Console.WriteLine("Please enter a number or 'ok' to exit.");
                Console.ForegroundColor = ConsoleColor.White;
                value = Console.ReadLine();

                if (value == "ok" || value == "OK" || value == "Ok" || value == "oK")
                {
                    lcontinue = false;
                  
                }

                else if(int.TryParse(value, out int num))
                {
                    sum += num;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Please read the instructions carefully");
                    lcontinue = false;
                }
            } while(lcontinue == true);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The sum of numbers you entered is: " + sum);
            Console.WriteLine("\n");
               

        }

        static void ProblemThree()
        {
            Console.WriteLine("Would you like to clear the console 'y' or 'n': ");
            string ans = Console.ReadLine();
            if (ans == "y")
            {
                Console.Clear();
            }
            Console.WriteLine("*********************************************************************");
            Console.WriteLine(" A program that asks the user to enter a number. It then computes the");
            Console.WriteLine(" factorial of the number. and print it on the console. For example, if");
            Console.WriteLine(" the user enters 5, the program calculates 5 x 4 x 3 x 2 x 1 and ");
            Console.WriteLine(" displays it as 5! = 120.");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("");

            int factorial = 1;
            
            Console.WriteLine("Please enter a number: ");
            string val = Console.ReadLine();
            if(int.TryParse(val, out int num))
            {
                while(num > 0)
                {
                    //Console.WriteLine(num);
                    factorial *= num;
                    num--;
                }

                
            }

            else
            {
                Console.WriteLine("Please read the instructions carefully!");
            }

            Console.WriteLine(val + "! = " + factorial);
        }

        static void ProblemFour()
        {
            Console.WriteLine("Would you like to clear the console 'y' or 'n': ");
            string ans = Console.ReadLine();
            if (ans == "y")
            {
                Console.Clear();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*********************************************************************");
            Console.WriteLine(" A program that picks a random number between 1 and 10. The user has ");
            Console.WriteLine(" 4 chances to guess the number. If the user guesses the number, the");
            Console.WriteLine(" program displays \"You won\" otherwise, program displays \"You lost\"");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("");

            int num, guessLeft = 4;
            string val;
            bool myGuess = false;

            Random rand = new Random();
            num = rand.Next(1, 10);
           
            while(guessLeft > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have "+ guessLeft + " guess!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Guess the number between 1 and 10, generated by the computer.: ");
                val = Console.ReadLine();

                if (int.TryParse(val, out int guess))
                {
                    if (guess == num)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You Won!");
                        myGuess = true;
                        guessLeft = 0;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Please read the instructions carefully!");
                    break;
                }
                guessLeft--;
            }

            if (myGuess == false)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Game Over!");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("You Lost ...");
            }
            
        }

        static void ProblemFive()
        {
            Console.WriteLine("Would you like to clear the console 'y' or 'n': ");
            string ans = Console.ReadLine();
            if (ans == "y")
            {
                Console.Clear();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*********************************************************************");
            Console.WriteLine(" A program that picks a random number between 1 and 10. The user has ");
            Console.WriteLine(" 4 chances to guess the number. If the user guesses the number, the");
            Console.WriteLine(" program displays \"You won\" otherwise, program displays \"You lost\"");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("");
            int max;
            Console.Write("Enter a series of numbers separated by commas: ");
            string numArray = Console.ReadLine();

            string[] result = numArray.Split(',');
            
            int[] numbers = new int[result.Length];
            for(int i=0; i<numbers.Length; i++)
            {
                numbers[i] = int.Parse(result[i]);
                
            }
            max = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("The maximum number of the group is: " + max);

        }
    }
}
