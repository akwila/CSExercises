using System;

namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            int[] store = new int[10];

            for(int a=0; a<50; a++)
            {
                Random rnd = new Random();
                int temp = rnd.Next(0, 9);
                switch(temp)
                {
                    case 0: store[0] += 1; break;
                    case 1: store[1] += 1; break;
                    case 2: store[2] += 1; break;
                    case 3: store[3] += 1; break;
                    case 4: store[4] += 1; break;
                    case 5: store[5] += 1; break;
                    case 6: store[6] += 1; break;
                    case 7: store[7] += 1; break;
                    case 8: store[8] += 1; break;
                    case 9: store[9] += 1; break;
                }
            }

            Console.WriteLine("{0}\t{1}","Number","Count");
            for (int a = 0; a <= 9; a++ )
                Console.WriteLine("{0}\t{1}",a,store[a]);

            string exit = Console.ReadLine();
        }
    }
}
