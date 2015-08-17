using System;
namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.Write("Please Enter Your Name : ");
            string name = Console.ReadLine();
            Console.Write("Please Enter Your Gender (M/F) : ");
            string gender = Console.ReadLine();
            if (gender == "M") { Console.WriteLine("Good Morning Mr. " + name); }
            else if (gender == "F") { Console.WriteLine("Good Morning Ms. " + name); }
            else Console.WriteLine("Gender is not recognize");
            string exit = Console.ReadLine();
        }
    }
}