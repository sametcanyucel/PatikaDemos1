using System;

namespace drawACircle
{
    internal class drawACircle
    {
        static void Main(string[] args)
        {
            double radius = 0;
            Console.Write("Please enter radius of circle");
            if (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
            {
                Console.WriteLine("The radius can not be negative");
                return;
            }
            drawCircle(radius);
        }
        static void drawCircle(double radius)
        {

            double thickness = 0.4;
            while (radius <= 0) ;
            Console.WriteLine();
            double rin = radius - thickness, rOut = radius + thickness;

            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rin * rin && value <= rOut * rOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
