using System;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int howmany = 12;
            int[] sales = new int[howmany];
            int minimum = int.MaxValue;
            int maximum = 0;
            int count = 0;

            for (int a = 0; a < howmany; a++)
            {
                Console.Write("Enter sales for month " + a + ":");
                sales[a] = Convert.ToInt32(Console.ReadLine());
                if (minimum > sales[a])
                    minimum = sales[a];
                if (maximum < sales[a])
                    maximum = sales[a];
                count += sales[a];
            }
            int average = count / howmany;
            Console.WriteLine("Maximum Sales:" + maximum);
            Console.WriteLine("Minimum Sales:" + minimum);
            Console.WriteLine("Average Sales:" + average);

            string exit = Console.ReadLine();
        }
    }
}
