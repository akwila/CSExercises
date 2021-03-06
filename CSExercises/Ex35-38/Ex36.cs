using System;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            // this is part a
            //Console.Write("please input a word : ");
            //string teks = Console.ReadLine();
            //int jumlah = teks.Length;
            //int half = (jumlah + 1) / 2;
            
            //bool palindrome = true;
            //for (int a = 0; a < half; a++)
            //{
            //    if (teks[a] != teks[jumlah - 1 - a])
            //    {
            //        palindrome = false;
            //    }
            //}

            //if (palindrome)
            //    Console.WriteLine("Your word is a palindrome");
            //else
            //    Console.WriteLine("Your word is not a palindrome");

            // this is part b
            Console.Write("please input a word : ");
            string teks = Console.ReadLine();
            teks = teks.ToLower(); // i put all to tolower
            int jumlah = teks.Length; // total from raw text
            string pindah = string.Empty;

            for (int a = 0; a < jumlah; a++)
            {
                if (teks[a] >= 97 && teks[a] <= 122)
                    pindah = pindah + teks[a];
            }
            //Console.WriteLine(pindah);

            jumlah = pindah.Length; // total from final text
            int half = (jumlah + 1) / 2;

            bool palindrome = true;
            for (int a = 0; a < half; a++)
            {
                if (pindah[a] != pindah[jumlah - 1 - a])
                {
                    palindrome = false;
                }
            }

            if (palindrome)
                Console.WriteLine("Your word is a palindrome");
            else
                Console.WriteLine("Your word is not a palindrome");

            string exit = Console.ReadLine();
        }
    }
}
