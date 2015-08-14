using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            string basket = Console.ReadLine();

            int value;
            if (int.TryParse(basket, out value))
            {
                int number1 = Convert.ToInt32(basket);
                double result = Math.Pow(number1, 2);
                Console.Write("Your Result : {0}",result);
            }
            else
            {
                Console.Write("Please input only number");
            }
            string exit = Console.ReadLine();
        }
    }
}
