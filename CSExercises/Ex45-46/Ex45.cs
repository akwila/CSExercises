using System;

namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the amount : ");
            double basket = Convert.ToDouble(Console.ReadLine());
            basket *= 100; // multiply by 100 to make everything easy
            while(basket>=5)
            {
                if(basket >= 100)
                {
                    Console.WriteLine("100c");
                    basket -= 100;
                }
                else if (basket >= 50)
                {
                    Console.WriteLine("50c");
                    basket -= 50;
                }
                else if (basket >= 20)
                {
                    Console.WriteLine("20c");
                    basket -= 20;
                }
                else if (basket >= 10)
                {
                    Console.WriteLine("10c");
                    basket -= 10;
                }
                else if (basket >= 5)
                {
                    Console.WriteLine("5c");
                    basket -= 5;
                }
            }

            string exit = Console.ReadLine();
        }
    }
}
