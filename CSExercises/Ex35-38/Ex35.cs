using System;

namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase : ");
            string teks = Console.ReadLine();
            teks = teks.ToLower();
            int jumlah = teks.Length;
            //int total = 0; // this is part a
            int a = 0; int i = 0; int u = 0; int e = 0; int o = 0; // this is part b
            for (int b = 0; b < jumlah; b++)
            {
                //if (teks[b] == 'a') { total++; } // this is part a
                //if (teks[b] == 'i') { total++; } // this is part a
                //if (teks[b] == 'u') { total++; } // this is part a
                //if (teks[b] == 'e') { total++; } // this is part a
                //if (teks[b] == 'o') { total++; } // this is part a

                if (teks[b] == 'a') { a++; } // this is part b
                if (teks[b] == 'i') { i++; } // this is part b
                if (teks[b] == 'u') { u++; } // this is part b
                if (teks[b] == 'e') { e++; } // this is part b
                if (teks[b] == 'o') { o++; } // this is part b
            }

            //Console.WriteLine("Total number of vowels : " + total); // this is part a
            Console.WriteLine("Number of a:" + a); // this is part b
            Console.WriteLine("Number of i:" + i); // this is part b
            Console.WriteLine("Number of u:" + u); // this is part b
            Console.WriteLine("Number of e:" + e); // this is part b
            Console.WriteLine("Number of o:" + o); // this is part b
            string exit = Console.ReadLine();
        }
    }
}
