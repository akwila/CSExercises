using System;
namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("X        Y");
            Console.WriteLine("----------------");
            for(int a=-5; a<=5; a++)
            {
                int y = 2 * a * a - 4 * a + 3;
                //Console.WriteLine("{0:0.0}\t{1:0.0}", a, y); // this is for option a
                for (int b = 0; b < y; b++) // this is for option b
                {
                    Console.Write("*");
                } Console.WriteLine(" ");
            }
            string exit = Console.ReadLine();
        }
    }
}
