using System;

namespace PatikaDemos
{
    public class reverseString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a text ");
            string text = Console.ReadLine();
           Console.WriteLine(Reverse(text));
        }

        public static string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }
}
