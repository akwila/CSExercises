using System;
namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.Write("Input a number : "); int n = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            /*for (int a = 1; a <= n; a++) // increment version
            { 
                result *= a;
            }*/
            for (int b = n; b >= 1; b--) // decrement version
            {
                result *= b;
            }
                Console.WriteLine("The result is : " + result);
            string exit = Console.ReadLine();
        }
    }
}
