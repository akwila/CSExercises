using System;
namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.Write("Please input km : ");
            Double km = Convert.ToDouble(Console.ReadLine());
            km = km * 10; km = Math.Round(km); km = km / 10; // round process

            Double charge = 0;
            if (km <= 0.5)
            {
                charge = 2.40;
            }
            else
            {
                charge = 2.40;
                km = km - 0.5;
                if (km <= 8.5)
                {
                    charge += (km * 10 * 0.04);
                }
                else
                {
                    charge += (8.5 * 10 * 0.04);
                    km = km - 8.5;
                    charge += (km * 10 * 0.05);
                }
            }
            Console.WriteLine("Charge : ${0:0.00}",charge);
            string exit = Console.ReadLine();
        }
    }
}