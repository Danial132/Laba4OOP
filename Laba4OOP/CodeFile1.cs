using System;

namespace Laba4OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            double max, min, q;
            Console.Write("Enter the x value: ");
            double x = double.Parse((Console.ReadLine()));
            Console.Write("Enter the y value: ");
            double y = double.Parse((Console.ReadLine()));
            Console.Write("Enter the z value: ");
            double z = double.Parse((Console.ReadLine()));
            if (x > y + z)
            {
                min = y + z;
            }
            else
            {
                min = x;
            }
            if (Math.Pow(x, 2) > y)
            {
                max = x;
            }
            else
            {
                max = y;
            }
            q = max + Math.Pow(z, 3);
            if (q == 0)
            {
                Console.WriteLine("Помилка");
            }
            Console.WriteLine("F = " + min / q);
            Console.ReadKey();
        }
    }
}
