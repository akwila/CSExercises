using System;
namespace CSExercises
{
    public class Ex41
    {
        public static bool InString(string s1, string s2)
        {
            if (s1.Contains(s2))
                return true;
            else
                return false;
        }

        public static void Main(string[] args)
        {
            Console.Write("Input first text : "); string basket1 = Console.ReadLine();
            Console.Write("Input second text : "); string basket2 = Console.ReadLine();

            if (InString(basket1, basket2))
                Console.WriteLine("first text contains second text");
            else
                Console.WriteLine("first text doesn't contain second text");
            string exit = Console.ReadLine();
        }
    }
}
