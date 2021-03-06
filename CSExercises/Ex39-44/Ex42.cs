using System;

namespace CSExercises
{
    public class Ex42
    {
        public static int FindWord(string s1, string s2)
        {
            int indicator = -1;
            if (s1.Contains(s2))
            {
                indicator = s1.IndexOf(s2);
            }
            return indicator;
        }

        public static void Main(string[] args)
        {
            Console.Write("Input first text : "); string basket1 = Console.ReadLine();
            Console.Write("Input second text : "); string basket2 = Console.ReadLine();

            int temp = FindWord(basket1, basket2);
            if (temp == -1)
                Console.WriteLine("Cannot find second text insite first text");
            else
            {
                Console.WriteLine("Second text is in " + (temp + 1) + " line from first text");
                Console.WriteLine("I assume first word from first text is 1, not 0");
            }
            string exit = Console.ReadLine();
        }
    }
}
