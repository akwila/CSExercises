using System;

namespace CSExercises
{
    public class Ex44
    {
        public static string Substitute(string s, char c1, char c2)
        {
            s = s.Replace(c1, c2);
            return s;
        }

        public static void Main(string[] args)
        {
            Console.Write("Your text : "); string s = Console.ReadLine();
            Console.Write("Try to replace "); string s1 = Console.ReadLine(); char c1 = s1[0];
            Console.Write("with "); string s2 = Console.ReadLine(); char c2 = s2[0];
            Console.WriteLine("Your result : " + Substitute(s, c1, c2));
            string exit = Console.ReadLine();
        }
    }
}
