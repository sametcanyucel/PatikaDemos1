using System;

namespace calculateAverage
{
    internal class calculateAverage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value of fibonacci");
            int fibo=Convert.ToInt32(Console.ReadLine());
            Fibo(fibo);
        }

        public static void Fibo(int fibo)
        {
            
            int number1 = 0, number2 = 1, number3 = 0,average=0;
            int total = number1 + number2;
            Console.Write(number1 + " " + number2 + " ");
            for (int i = 2; i <= fibo; i++)
            {

                number3 = number1 + number2;
                total = total + number3;
                Console.Write(number3 + " ");
                number1 = number2;
                number2 = number3;


            }
            average = total / fibo;
            Console.WriteLine();
            Console.WriteLine("Average of this series :"+average);
            
        }
    }
}
