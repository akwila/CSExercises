using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.Write("Salary : ");
            string basket = Console.ReadLine();

            int value;
            if (int.TryParse(basket, out value))
            {
                double number1 = Convert.ToDouble(basket);
                double output1 = (Convert.ToDouble(100 + 10 + 3) / 100) * number1;
                Console.Write("I get S$ " + output1);
            }
            else
            {
                Console.Write("Please input only number");
            }
            string exit = Console.ReadLine();
        }
    }
}
