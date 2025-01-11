﻿// See https://aka.ms/new-console-template for more information



using System;

namespace Calculator
{
    class Program {
        static void Main(string[] args){
            Console.WriteLine("Calculator");
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the operator[+,-,x,/]: ");
            string op = Console.ReadLine();
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            if (op == "+"){
                Console.WriteLine(Add(num1, num2));
            } else if (op == "-"){
                Console.WriteLine(Subtract(num1, num2));
            } else if (op == "x"){
                Console.WriteLine(Multiply(num1, num2));
            } else if (op == "/"){
                Console.WriteLine(Divide(num1, num2));
            } else {
                Console.WriteLine("Invalid operator");
            }
        }

        public static double Add(double num1, double num2){
            return num1 + num2;
        }
        public static double Subtract(double num1, double num2){
            return num1 - num2;
        }
        public static double Multiply(double num1, double num2){
            return num1 * num2;
        }
        public static double Divide(double num1, double num2){
            if (num2 == 0){
                return 0;
            }
            return num1 / num2;
        }
    }
    
}






