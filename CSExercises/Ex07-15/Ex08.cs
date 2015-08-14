using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.Write("C Temperature : ");
            string basket = Console.ReadLine();

            int value;
            if (int.TryParse(basket, out value))
            {
                double number1 = Convert.ToDouble(basket);
                double output1 = 1.8 * number1 + 32;
                Console.WriteLine("F Temperature : " + output1);
            }
            else
            {
                Console.Write("Please input only number");
            }
            string exit = Console.ReadLine();
        }
    }
}
