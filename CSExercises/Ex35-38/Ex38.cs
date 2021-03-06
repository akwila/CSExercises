using System;
namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[] name = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] score = new int[] { 63, 29, 75, 82, 55 };
            int jumlah = score.Length;

            // this is part a
            Console.WriteLine("Report a");
            for (int a = 0; a < jumlah - 1; a++)
            {
                int savepointer = -1;
                for (int b = a + 1; b < jumlah; b++)
                {
                    if (score[b] < score[a])
                    {
                        if (savepointer == -1)
                        {
                            savepointer = b;
                        }
                        else
                        {
                            if (score[b] < score[savepointer])
                                savepointer = b;
                        }
                    }
                }
                if (savepointer >= 0)
                {
                    int temp = score[a];
                    score[a] = score[savepointer];
                    score[savepointer] = temp;

                    string strtemp = name[a];
                    name[a] = name[savepointer];
                    name[savepointer] = strtemp;
                }
            }
            for (int c = 0; c < jumlah; c++)
            {
                Console.WriteLine(name[c] + " " + score[c]);
            }
            Console.WriteLine("");

            // this is part b
            Console.WriteLine("Report b");
            for (int a = 0; a < jumlah - 1; a++)
            {
                int savepointer = -1;
                for (int b = a + 1; b < jumlah; b++)
                {
                    int asdf = name[b].ToLower().CompareTo(name[a].ToLower());
                    if (asdf < 0)
                    {
                        if (savepointer == -1)
                        {
                            savepointer = b;
                        }
                        else
                        {
                            int asd = name[b].ToLower().CompareTo(name[savepointer].ToLower());
                            if (asd < 0)
                                savepointer = b;
                        }
                    }
                }
                if (savepointer >= 0)
                {
                    int temp = score[a];
                    score[a] = score[savepointer];
                    score[savepointer] = temp;

                    string strtemp = name[a];
                    name[a] = name[savepointer];
                    name[savepointer] = strtemp;
                }
            }

            for (int c = 0; c < jumlah; c++)
            {
                Console.WriteLine(name[c] + " " + score[c]);
            }

            string exit = Console.ReadLine();
        }
    }
}
