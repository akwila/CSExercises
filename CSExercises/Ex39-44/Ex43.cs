using System;

namespace CSExercises
{
    public class Ex43
    {
        public static string Hex(int i)
        {
            string strFinal = "";
            while(i > 0)
            {
                int temp = i % 16;
                switch(temp)
                {
                    case 0: strFinal = "0" + strFinal; break;
                    case 1: strFinal = "1" + strFinal; break;
                    case 2: strFinal = "2" + strFinal; break;
                    case 3: strFinal = "3" + strFinal; break;
                    case 4: strFinal = "4" + strFinal; break;
                    case 5: strFinal = "5" + strFinal; break;
                    case 6: strFinal = "6" + strFinal; break;
                    case 7: strFinal = "7" + strFinal; break;
                    case 8: strFinal = "8" + strFinal; break;
                    case 9: strFinal = "9" + strFinal; break;
                    case 10: strFinal = "A" + strFinal; break;
                    case 11: strFinal = "B" + strFinal; break;
                    case 12: strFinal = "C" + strFinal; break;
                    case 13: strFinal = "D" + strFinal; break;
                    case 14: strFinal = "E" + strFinal; break;
                    case 15: strFinal = "F" + strFinal; break;
                }

                i = i / 16;
            }
            return strFinal;
        }

        public static void Main(string[] args)
        {
            Console.Write("Input a decimal number : "); int basket = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hexa number : " + Hex(basket));
            string exit = Console.ReadLine();
        }
    }
}
