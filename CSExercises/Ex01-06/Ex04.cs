﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            string basket = Console.ReadLine();

            double value;
            if (double.TryParse(basket, out value))
            {
                double number1 = Convert.ToDouble(basket);
                double result = Math.Pow(number1, 0.5);
                Console.Write("Your Result : {0}", result);
            }
            else
            {
                Console.Write("Please input only number");
            }
            string exit = Console.ReadLine();
        }
    }
}
