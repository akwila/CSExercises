using System;
namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int mind = rnd.Next(0, 9);
            int correct = 0;
            int attempt = 0;
            while(correct == 0)
            {
                Console.Write("My Guess : "); int guess = Convert.ToInt32(Console.ReadLine());
                attempt++;

                if (guess == mind)
                    correct = 1;
                else
                    Console.WriteLine("Try again");
            }
            switch(attempt)
            {
                case 1:
                case 2: 
                    Console.WriteLine("You are a Wizard!");
                    break;
                case 3:
                case 4:
                case 5: 
                    Console.WriteLine("You are a good guess!");
                    break;
                default: 
                    Console.WriteLine("You are lousy!");
                    break;
            }
            string exit = Console.ReadLine();
        }
    }
}
