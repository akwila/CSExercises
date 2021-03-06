using System;

namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int[,] score = new int[,]{{56,84,68,29},
                                    {94,73,31,89},
                                    {41,63,36,90},
                                    {99,9,18,17},
                                    {62,3,65,75},
                                    {40,96,53,23},
                                    {81,15,27,30},
                                    {21,70,100,22},
                                    {88,50,13,12},
                                    {48,54,52,78},
                                    {64,71,67,25},
                                    {16,93,46,72}};

            for (int a = 0; a < score.GetLength(0); a++)
            {
                Console.Write("Student {0} : ", a + 1);
                int total = 0;
                for (int b = 0; b < score.GetLength(1); b++)
                {
                    total += score[a, b];
                }
                int rata = total / score.GetLength(1);
                Console.WriteLine(rata);
            }
            Console.WriteLine();

            for (int b = 0; b < score.GetLength(1); b++)
            {
                Console.Write("Subject {0} : ", b + 1);
                int total = 0;
                for (int a = 0; a < score.GetLength(0); a++)
                {
                    total += score[a, b];
                }
                int rata = total / score.GetLength(0);
                Console.Write(rata + ";");

                Console.Write(" Standard Deviation : ");
                int total1 = 0;
                for (int a = 0; a < score.GetLength(0); a++)
                {
                    total1 += Convert.ToInt32(Math.Pow((score[a, b] - rata), 2));
                }
                int stdev = Convert.ToInt32(Math.Sqrt(total1 / score.GetLength(0)));
                Console.WriteLine(stdev);
            }
            Console.WriteLine();

            int total2 = 0;
            for (int a = 0; a < score.GetLength(0); a++)
            {
                for (int b = 0; b < score.GetLength(1); b++)
                {
                    total2 += score[a, b];
                }
            }
            int rata2 = total2 / score.Length;
            Console.WriteLine("Class Average : " + rata2);

            string exit = Console.ReadLine();
        }
    }
}
