using System;

namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            Console.Write("Please input a phrase : ");
            string teks = Console.ReadLine();

            teks = teks.ToLower();
            char[] cutter = new char[] { ' ' };
            string[] temp = teks.Split(cutter, StringSplitOptions.RemoveEmptyEntries);
            int jumlah = temp.Length;
            string finalText = string.Empty;

            for (int a = 0; a < jumlah; a++)
            {
                string pertama = temp[a].Substring(0, 1);
                pertama = pertama.ToUpper();
                string kedua = temp[a].Substring(1);
                temp[a] = pertama + kedua;
                finalText += temp[a];
                if (a < jumlah - 1)
                    finalText += " ";
            }

            Console.WriteLine(finalText);
            string exit = Console.ReadLine();
        }
    }
}
