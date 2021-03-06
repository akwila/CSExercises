using System;
namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" No            INVERSE        SQUARE ROOT      SQUARE ");
            Console.WriteLine("------------------------------------------------------");
            for(int a=1; a<=10; a++)
            {
                double inv = 1.0 / a;
                double ro = Math.Pow(a, 0.5);
                double sq = Math.Pow(a, 2);
                Console.WriteLine("{0:0.0##}\t\t{1:0.0##}\t\t{2:0.0##}\t\t{3:0.0##}", a, inv, ro, sq);
            }
            string exit = Console.ReadLine();
        }
    }
}
