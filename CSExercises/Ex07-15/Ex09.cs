using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            Console.Write("Input a number : ");
            string basket = Console.ReadLine();

            int value;
            if (int.TryParse(basket, out value))
            {
                double number1 = Convert.ToDouble(basket);
                double output1 = 2 * number1 * number1 - 4 * number1 + 3;
                Console.WriteLine("Result : " + output1);
            }
            else
            {
                Console.Write("Please input only number");
            }
            string exit = Console.ReadLine();
        }
    }
}
