using System;
namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.Write("Please input your score (0-100) : ");
            int score = Convert.ToInt32(Console.ReadLine());
            string strscore = "";
            if (score >= 0 && score <= 100)
            {
                if (score >= 80) { strscore = "A"; }
                else if (score >= 60) { strscore = "B"; }
                else if (score >= 40) { strscore = "C"; }
                else { strscore = "F"; }

                Console.WriteLine("You scored " + score + " marks which is " + strscore + " grade.");
            }
            else
            {
                Console.WriteLine("Error");
            }
            string exit = Console.ReadLine();
        }
    }
}