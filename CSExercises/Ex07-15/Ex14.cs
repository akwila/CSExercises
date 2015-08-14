using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            Console.Write("Side a : "); string sa = Console.ReadLine();
            Console.Write("Side b : "); string sb = Console.ReadLine();
            Console.Write("Side c : "); string sc = Console.ReadLine();

            int value;
            if (int.TryParse(sa, out value) && int.TryParse(sb, out value) && int.TryParse(sc, out value))
            {
                double da = Convert.ToDouble(sa);
                double db = Convert.ToDouble(sb);
                double dc = Convert.ToDouble(sc);
                double ds = (da + db + dc) / 2;
                double output1 = Math.Pow((ds*(ds-da)*(ds-db)*(ds-dc)),0.5);
                Console.WriteLine("Area : {0}", output1);
            }
            else
            {
                Console.Write("Please input only number");
            }
            string exit = Console.ReadLine();
        }
    }
}