using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    class extra
    {
        static int[,] trap = new int[,]{{1,38},{4,14},{9,31},{17,7},{21,42},{28,84},
                                        {51,67},{54,34},{64,60},{71,91},{80,100},
                                        {87,24},{93,73},{95,75},{98,79}};

        protected static int snakeLadder(int iinput)
        {
            int panjang = trap.GetLength(0);
            int a = 0; bool trapDetected = false;
            for (a = 0; a < panjang; a++)
            {
                if (iinput == trap[a, 0])
                {
                    if (trap[a, 0] > trap[a, 1])
                    {
                        Console.WriteLine("Oh No! Snake!!");
                    }
                    else
                    {
                        Console.WriteLine("Yes! I found a ladder");
                    }
                    trapDetected = true;
                    break;
                }
            }
            if (trapDetected == true)
                return trap[a, 1];
            else
                return 0;
        }

        public static void Main(string[] args)
        {
            Console.Write("How many players will play this game? ");
            int player = Convert.ToInt32(Console.ReadLine());

            int[] position = new int[player];
            for (int a = 0; a < player; a++) // player position start from 1
                position[a] = 1;

            bool repeat = true;
            int playerTurn = 1; //playerTurn is what player that play this game right now.
            Random rnd = new Random();

            while(repeat)
            {
                Console.WriteLine("\nNow is player {0} turn",playerTurn);
                Console.Write("Please press any key to roll the dice");
                Console.ReadLine();
                int dice = rnd.Next(1, 6);
                position[playerTurn-1] += dice; // move position if player

                Console.WriteLine("Player {0} get {1}. ", playerTurn, dice);

                int temp = snakeLadder(position[playerTurn - 1]);
                if (temp > 0)
                    position[playerTurn - 1] = temp;

                if (position[playerTurn - 1] >= 100)
                {
                    Console.WriteLine("\nCongratulation to player {0}. You win!", playerTurn);
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("His position now is {0}", position[playerTurn - 1]);
                    playerTurn++;
                    if (playerTurn > player)// if all player rolled the dice, back to player 1
                        playerTurn = 1;
                }
            }

            string exit = Console.ReadLine();
        }
    }
}
