using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator {
    internal class MainClass {
        public static void Main() {
            Console.WriteLine("Welcome to a simple calculator");


            bool num1Valid = false;
            int num1 = 0; 

            do {
                Console.Write("Enter Number 1: ");
                try {
                    num1 = Convert.ToInt32(Console.ReadLine());
                    num1Valid = true;
                } catch (FormatException) {
                    Console.WriteLine("Number is invalid!");
                }
            } while (num1Valid == false);

            Console.Write("Enter number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("1) +\n2) -\n3) /\n4) *\nSelect Operator: ");
            int selected = Convert.ToInt32(Console.ReadLine());

            switch (selected) {
                case 1: {
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                }
                case 2: {
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                }
                case 3: {
                    if (num2 == 0) {
                        Console.WriteLine("Can not divide by 0");
                    } else {
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");  
                    }
                    break;
                }
                case 4: {
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                }
            }
        }
    }
}