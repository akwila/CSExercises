using System;
namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.Write("Input a positive number : "); int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                if (n == 1)
                    Console.WriteLine("Not Prime");
                else if (n == 2)
                    Console.WriteLine("Prime");
                else
                {
                    int start = Convert.ToInt32(Math.Pow(n, 0.5));
                    int primeStatus = 1;
                    for(int a = start; a > 1; a--)
                    {
                        if(n%a == 0)
                        {
                            primeStatus = 0;
                        }
                    }
                    if(primeStatus == 0)
                        Console.WriteLine("Not Prime");
                    else
                        Console.WriteLine("Prime");

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
