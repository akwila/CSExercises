using System;
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Console.Write("Input a number : "); int n = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            double prevGuess = rnd.Next(1, n);
            if (prevGuess * prevGuess == n)
            {
                Console.WriteLine("The square root from " + n + " is {0:0.00000}",prevGuess);
            }
            else
            {
                int status = 0;
                do
                {
                    double nextguess = (prevGuess + n / prevGuess) / 2;
                    double check1 = Math.Round(prevGuess * 100000);
                    double check2 = Math.Round(nextguess * 100000);
                    if (check1 == check2)
                        status = 1;
                    else
                        prevGuess = nextguess;
                } while (status != 1);
                Console.WriteLine("The square root from " + n + " is {0:0.00000}",prevGuess);
            }
            string exit = Console.ReadLine();
        }
    }
}
