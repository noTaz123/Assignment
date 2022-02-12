using System;

namespace RectangularCalculations
{
    class Rectangular
    {
        public int width, height;



        public Rectangular(int x, int y)
        {
            width = x;
            height = y;
        }

    }

    class Utility
    {
        public int area, perimeter;

        public int CalcArea(int m, int n)
        {
            area = m * n;
            return area;
        }

        public int CalcPerimeter(int m, int n)
        {
            perimeter = 2 * (m + n);
            return perimeter;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            string smaxH, smaxW, sminH, sminW;
            int minW, maxW, minH, maxH, x, y;
            Console.Write("Please enter the Rectangular maximum value for length: ");
            smaxW = Console.ReadLine();

            Console.Write("Please enter the Rectangular minimum value for length: ");
            sminW = Console.ReadLine();

            Console.Write("Please enter the Rectangular maximum value for width: ");
            smaxH = Console.ReadLine();

            Console.Write("Please enter the Rectangular minimum value for width: ");
            sminH = Console.ReadLine();

            System.Console.WriteLine("\nRESULTS\n");

            minW = int.Parse(sminW);
            minH = int.Parse(sminH);
            maxW = int.Parse(smaxW);
            maxH = int.Parse(smaxH);

            MakeTriangle(minW, maxW, minH, maxH, out x, out y);
            Rectangular p = new Rectangular(x, y); //creating an instance
            Utility val = new Utility(); //creating an instance
            int areaRec = val.CalcArea(p.width, p.height);
            int perimeterRec = val.CalcPerimeter(p.width, p.height);

            System.Console.WriteLine("Length of the rectangle is: " + p.height);
            System.Console.WriteLine("Width of the rectangle is: " + p.width);
            System.Console.WriteLine("Area of the rectangle is: " + areaRec);
            System.Console.WriteLine("Perimeter of the rectangle is: " + perimeterRec);
            System.Console.WriteLine("\n\n");

        }

        public static void MakeTriangle(int minWidth, int maxWidth, int minHeight, int maxHeight, out int len, out int wid)
        {
            Random rnd = new Random();
            wid = rnd.Next(minWidth, maxWidth + 1); // creates a number between minWidth and maxWidth included.
            len = rnd.Next(minHeight, maxHeight + 1); // creates a number between minHeight and maxHeight included.
        }
    }
}