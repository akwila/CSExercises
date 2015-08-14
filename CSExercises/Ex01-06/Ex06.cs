using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            string basket = Console.ReadLine();

            int value;
            if (int.TryParse(basket, out value))
            {
                double number1 = Convert.ToDouble(basket);
                double result = Math.Pow(number1, 0.5);
                Console.Write("Your Result : {0:0.000}", result);
            }
            else
            {
                Console.Write("Please input only number");
            }
            string exit = Console.ReadLine();
        }
    }
}
