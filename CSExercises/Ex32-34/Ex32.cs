using System;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int howmany = 12;
            int[] sales = new int[howmany];
            int minimum = int.MaxValue; int minSave = 0;
            int maximum = 0; int maxSave = 0;
            int count = 0;

            for (int a = 0; a < howmany; a++)
            {
                Console.Write("Enter sales for month " + a + ":");
                sales[a] = Convert.ToInt32(Console.ReadLine());
                if (minimum > sales[a])
                {
                    minimum = sales[a]; minSave = a;
                }

                if (maximum < sales[a])
                {
                    maximum = sales[a]; maxSave = a;
                }
                count += sales[a];
            }
            int average = count / howmany;
            Console.WriteLine("Maximum Sales:" + maxSave);
            Console.WriteLine("Minimum Sales:" + minSave);
            Console.WriteLine("Average Sales:" + average);

            string exit = Console.ReadLine();
        }
    }
}
