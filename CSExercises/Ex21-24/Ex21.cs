using System;
namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            
            int angka = 0;
            do {
                Console.Write("Please Enter a Number : ");
                angka = Convert.ToInt32(Console.ReadLine());
            } while(angka != 88);
            Console.WriteLine("Lucky you...");
            string exit = Console.ReadLine();
        }
    }
}
