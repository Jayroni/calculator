using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
           
            int num1;
            while (true)
            {
                Console.Write("Enter the first number: ");
                if (int.TryParse(Console.ReadLine(), out num1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a whole number.");
                }
            }

           
            int num2;
            while (true)
            {
                Console.Write("Enter the second number: ");
                if (int.TryParse(Console.ReadLine(), out num2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a whole number.");
                }
            }

            
            char operation;
            while (true)
            {
                Console.Write("Enter operation (+, -, *, /, %, =): ");
                string input = Console.ReadLine();
                if (input.Length == 1 && "+-*/%=".Contains(input))
                {
                    operation = input[0];
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect Operation Used, please try again");
                }
            }

            
            if (operation == '=')
            {
                break;
            }

            
            object result = Calculator(num1, num2, operation);

            
            if (result != null)
            {
                Console.WriteLine($"Result: {result}");
            }

            
        }
    }﻿//write your console display in here
