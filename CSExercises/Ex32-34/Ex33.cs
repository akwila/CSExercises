using System;

namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] angka = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };
            int jumlah = angka.Length;

            for (int a = 0; a < jumlah - 1; a++)
            {
                for (int c = 0; c < jumlah; c++)
                {
                    Console.Write(angka[c] + " ");
                }
                Console.WriteLine();

                int savepointer = -1;
                for (int b = a + 1; b < jumlah; b++)
                {
                    if (angka[b] < angka[a])
                    {
                        if (savepointer == -1)
                        {
                            savepointer = b;
                        }
                        else
                        {
                            if (angka[b] < angka[savepointer])
                                savepointer = b;
                        }
                    }
                }
                if (savepointer >= 0)
                {
                    int temp = angka[a];
                    angka[a] = angka[savepointer];
                    angka[savepointer] = temp;
                }
            }

            for (int c = 0; c < jumlah; c++)
            {
                Console.Write(angka[c] + " ");
            }

            string exit = Console.ReadLine();
        }
    }
}
