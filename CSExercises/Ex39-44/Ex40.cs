using System;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            for(int a=1; a<=25;a++)
            {
                Console.WriteLine("Square root of " + a + " is " + SQT(a));
            }
            string exit = Console.ReadLine();
        }

        public static double SQT(int y)
        {
            double result = Math.Sqrt(y);
            return result;
        }
    }
}
