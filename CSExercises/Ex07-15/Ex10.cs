using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.Write("x1 : "); string sx1 = Console.ReadLine();
            Console.Write("x2 : "); string sx2 = Console.ReadLine();
            Console.Write("y1 : "); string sy1 = Console.ReadLine();
            Console.Write("y2 : "); string sy2 = Console.ReadLine();

            int value;
            if (int.TryParse(sx1, out value) && int.TryParse(sx2, out value) && int.TryParse(sy1, out value) && int.TryParse(sy2, out value))
            {
                double dx1 = Convert.ToDouble(sx1);
                double dx2 = Convert.ToDouble(sx2);
                double dy1 = Convert.ToDouble(sy1);
                double dy2 = Convert.ToDouble(sy2);

                double output1 = Math.Pow((Math.Pow((dx2 - dx1), 2) + Math.Pow((dy2 - dy1), 2)), 0.5);
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
