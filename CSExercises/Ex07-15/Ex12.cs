﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            Console.Write("Taxi km : ");
            string basket = Console.ReadLine();

            double value;
            if (double.TryParse(basket, out value))
            {
                double number1 = Convert.ToDouble(basket);
                double output1 = Math.Round((2.40 + number1 * 0.4),1);
                Console.WriteLine("Total fare : {0:0.00}",output1);
            }
            else
            {
                Console.Write("Please input only number");
            }
            string exit = Console.ReadLine();
        }
    }
}
