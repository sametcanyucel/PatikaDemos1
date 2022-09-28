using System;

namespace algoritmExample
{
    internal class algoritmExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a text as (String),(deleted index)");
            string text=Console.ReadLine();
            Console.WriteLine(removeByIndex(text));
        }
        public static string removeByIndex(string text)
        {
            string[] text1 = text.Split(",");
            string text2 = text1[0];
            int chindex = Convert.ToInt32(text1[1]);
            return text2.Remove(chindex, 1); 
        }
    }
}
