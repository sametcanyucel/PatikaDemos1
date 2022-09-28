using System;

namespace drawATringle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value of tringle");
            int value = Convert.ToInt32(Console.ReadLine());
            drawTringle(value);
        }

        public static void drawTringle(int value)
        {
            for (int i = 1; i < value; i++)
            {
                for (int k = value; k > i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < i*2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
