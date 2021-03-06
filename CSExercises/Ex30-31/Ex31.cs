using System;
namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            for (int n = 1; n < 1000; n++)
            {
                if (n > 0)
                {
                    if (n >= 3)
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
                            Console.WriteLine(n);
                    }
                }
                else
                {
                    Console.WriteLine("Please input a number more than 0");
                }
            }
            string exit = Console.ReadLine();
        }
    }
}
