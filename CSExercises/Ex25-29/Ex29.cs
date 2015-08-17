using System;
namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.Write("Input a positive number : "); int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                if (n < 3)
                    Console.WriteLine("Not Perfect Number");
                else
                {
                    int start = Convert.ToInt32(Math.Pow(n, 0.5));
                    int total = 0;
                    for (int a = start; a > 1; a--)
                    {
                        if (n % a == 0)
                        {
                            total += a;
                            int temp = n / a;
                            total += temp;
                        }
                    }
                    total += 1;
                    if (total == n)
                        Console.WriteLine("Perfect Number");
                    else
                        Console.WriteLine("Not Perfect Number");

                }
            }
            else
            {
                Console.WriteLine("Please input a number more than 0");
            }
            string exit = Console.ReadLine();
        }
    }
}
