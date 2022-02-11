using System;

namespace Car
{
    public class car
    {
        //declaring fields
        public string c1make, c1model, sc1val, c2make, c2model, sc2val, c3make, c3model, sc3val;

    }
    class Program
    {
        static void Main(string[] args)
        {
            //declaring the variables
            string sLval;
            int speedc1, speedc2, speedc3, speedLimit, demeritc1, demeritc2, demeritc3;
            bool issLInt, isSc1Int, isSc2Int, isSc3Int;
            car c = new car(); //creating an instance of the car class

            //Program Description
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("  This Program asks the user to enter the speed limit. \n " +
                              " It then asks the user to enter the make, model and speed of each\n " +
                              " of the three cars. Based on the car's speed relative to the speed\n " +
                              " limit, it assigns each car demerit points. Each 5miles above\n"+
                              "  earns 1 demerit point. The program displays if the results and\n" +
                              "  if the license has been suspended.");
            Console.WriteLine("**********************************************************************");
            //Program instruction
            Console.Write("Please enter the speed limit (mph): ");
            //Reading the user input
            sLval = Console.ReadLine();
            //Testing value to ensure it is an int
            issLInt  = int.TryParse(sLval, out speedLimit);

            if (issLInt == true)
            {
                Console.Write("\n");
                //Entering Data for car 1
                Console.Write("Enter the make of Car 1: ");
                c.c1make = Console.ReadLine();

                Console.Write("Enter the model of Car 1: ");
                c.c1model = Console.ReadLine();

                Console.Write("Enter the speed of Car 1 in mph: ");
                c.sc1val = Console.ReadLine();

                Console.Write("\n");
                //Entering Data for Car 2
                Console.Write("Enter the make of Car 2: ");
                c.c2make = Console.ReadLine();

                Console.Write("Enter the model of Car 2: ");
                c.c2model = Console.ReadLine();

                Console.Write("Enter the speed of Car 2 in mph: ");
                c.sc2val = Console.ReadLine();

                Console.Write("\n");
                //Entering Data for Car 3
                Console.Write("Enter the make of Car 3: ");
                c.c3make = Console.ReadLine();

                Console.Write("Enter the model of Car 3: ");
                c.c3model = Console.ReadLine();

                Console.Write("Enter the speed of Car 3 in mph: ");
                c.sc3val = Console.ReadLine();

                isSc1Int = int.TryParse(c.sc1val, out speedc1);
                isSc2Int = int.TryParse(c.sc2val, out speedc2);
                isSc3Int = int.TryParse(c.sc3val, out speedc3);

                if(isSc1Int == true && isSc2Int == true && isSc3Int == true)
                {
                    demeritc1 = (speedc1 - speedLimit) / 5;
                    demeritc2 = (speedc2 - speedLimit) / 5;
                    demeritc3 = (speedc3 - speedLimit) / 5;
                    Console.Write("\n\nRESULTS\n\n");
                    Console.WriteLine("Speed Limit: " + speedLimit + "mph");
                    Console.WriteLine(" ");
                    Console.Write(String.Format("{0,-12}", c.c1make) + String.Format("{0,-17}", c.c1model)  + String.Format("{0,-10}", speedc1 +"mph: "));
                    if (demeritc1 < 1) { Console.Write(String.Format("{0,-15}", "OK!"));}
                    else { Console.Write(String.Format("{0,-15}", demeritc1 + " demerits")); }
                    if (demeritc1 >= 10) { Console.Write("\t<LICENSE SUSPENDED>\n"); }
                    else Console.WriteLine();

                    Console.Write(String.Format("{0,-12}", c.c2make) + String.Format("{0,-17}", c.c2model) + String.Format("{0,-10}", speedc2 + "mph: "));
                    if (demeritc2 < 1) { Console.Write(String.Format("{0,-15}", "OK!")); }
                    else { Console.Write(String.Format("{0,-15}", demeritc2 + " demerits")); }
                    if (demeritc2 >= 10) { Console.Write("\t<LICENSE SUSPENDED>\n"); }
                    else Console.WriteLine();

                    Console.Write(String.Format("{0,-12}", c.c3make) + String.Format("{0,-17}", c.c3model) + String.Format("{0,-10}",speedc3 + "mph: "));
                    if (demeritc3 < 1) { Console.Write(String.Format("{0,-15}", "OK!")); }
                    else { Console.Write(String.Format("{0,-15}", demeritc3 + " demerits")); }
                    if (demeritc3 >= 10) { Console.Write("\t<LICENSE SUSPENDED>\n"); }
                    else Console.WriteLine();

                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine("\n\nEnter integer values for the speed of each car.");
                }


            }
            else
            {
                Console.WriteLine("\n\nEnter an integer value for the speed Limit.");
            }
        }
    }
}
