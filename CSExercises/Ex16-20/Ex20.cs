using System;
namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter quantity for TV : ");int tv = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity for DVD : "); int dvd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity for MP3 : "); int mp3 = Convert.ToInt32(Console.ReadLine());

            int pbd = 0; // price before discount
            int pad = 0; // price after discount
            pbd = tv * 900 + dvd * 500 + mp3 * 700;
            if (pbd > 10000) { pad = pbd - (pbd * 15 / 100); }
            else if (pbd > 5000) { pad = pbd - (pbd * 10 / 100); }
            else { pad = pbd; }
            Console.WriteLine("Total price for this order is $" + pad);
            string exit = Console.ReadLine();
        }
    }
}