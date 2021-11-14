using System;

namespace Laba4OOP
{
    internal class Program1Base
    {
        static void Main(string[] args)
        {
            int N;
            float x, y;
            Console.WriteLine("Enter x:");
            x = float.Parse((Console.ReadLine()));
            Console.WriteLine("Enter y:");
            y = float.Parse((Console.ReadLine()));
            if (Math.Abs(y) > 12 || Math.Abs(x) > 12)
            {
                N = 4;
            }
            else
            {
                if (x == 0 && y == 0)
                {
                    N = 0;
                }
                else if (x > 0)
                {
                    N = y > 0 ? 2 : 3;
                }
                else
                {
                    N = y > 0 ? 1 : 2;
                }
            }
            Console.WriteLine("M = (" + x + ";" + y + ") лежить у межах " + N);
            Console.ReadKey();
        }
    }
}