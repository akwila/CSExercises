using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Console.Write("input 3 digit number : "); string basket = Console.ReadLine();

            int value;
            if (int.TryParse(basket, out value))
            {
                double number1 = Convert.ToDouble(basket);
                if (number1 > 99 && number1 < 1000)
                {
                    int ia = Convert.ToInt32(Math.Floor(number1 / 100));
                    int ib = Convert.ToInt32(Math.Floor((number1 - (ia*100)) / 10));
                    int ic = Convert.ToInt32(number1 - (ia*100) - (ib*10));

                    double output1 = Math.Pow(ia, 3) + Math.Pow(ib, 3) + Math.Pow(ic, 3);
                    if(number1 == output1)
                        Console.WriteLine("Your number is an armstrong number");
                    else
                        Console.WriteLine("Your number is not an armstrong number");
                }
                else
                {
                    Console.Write("Please input only 3 digit");
                }
            }
            else
            {
                Console.Write("Please input only number");
            }
            string exit = Console.ReadLine();
        }
    }
}