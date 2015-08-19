using System;
namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.Write("Please Enter Your Name : ");
            string name = Console.ReadLine();
            Console.Write("Please Enter Your Gender (M/F) : ");
            string tempgender = Console.ReadLine();
            Console.Write("Please Enter Your Age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            string gender = "";
            if (tempgender == "M") {
                if (age >= 40) { Console.WriteLine("Good morning Uncle " + name); }
                else { Console.WriteLine("Good morning Mr. " + name); }
            } else if(tempgender == "F") {
                if (age >= 40) { Console.WriteLine("Good morning Aunty " + name); }
                else { Console.WriteLine("Good morning Ms. " + name); }
            }
            else { Console.WriteLine("Gender is not recognize"); }
            string exit = Console.ReadLine();
        }
    }
}