using System;
namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter A : "); int temp1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B : "); int temp2 = Convert.ToInt32(Console.ReadLine());
            int angka1 = temp1; int angka2 = temp2;

            while(angka1 != angka2)
            {
                if (angka1 > angka2)
                {
                    angka1 = angka1 - angka2;
                }
                else
                {
                    angka2 = angka2 - angka1;
                }
            }
            int hcf = angka1;
            int lcm = temp1 * temp2 / angka1;

            Console.WriteLine("HCF : " + hcf);
            Console.WriteLine("LCM : " + lcm);

            string exit = Console.ReadLine();
        }
    }
}
