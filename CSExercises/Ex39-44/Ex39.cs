using System;

namespace CSExercises
{
    public class Ex39
    {
        public static double Factorial(double x)
        {
            double result = 1;
            for (int a = 1; a <= x; a++)
            {
                result *= a;
            }
            return result;
        }
        public static void Main(string[] args)
        {
            Console.Write("Input a number : ");
            double basket = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Factorial Result : " + Factorial(basket));
            string exit = Console.ReadLine();
        }
    }
}
