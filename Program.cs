using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Variable Declarations
            string userInput1;
            string userInput2;
            string userInput3;
            double num1;
            double num2;
            string[] acceptableInputs = { "add", "subtract", "multiply", "divide", "+", "-", "*", "x", "/"};
            bool isValid = false;
            
            // Main Body
            Console.WriteLine("Calculator operational and accepting input.");
            Console.WriteLine("Please input your first number...");
            userInput1 = Console.ReadLine();
            Console.WriteLine("Please input your second number...");
            userInput2 = Console.ReadLine();
            Console.WriteLine("Please input how you would like to calculate the numbers...");
            Console.WriteLine("Acceptable inputs are: add, subtract, multiply, divide.");
            userInput3 = Console.ReadLine();
            userInput3.ToLower();

            // Check if userInput3 is a valid input
            while (!isValid)
            {
                foreach (string inputs in acceptableInputs)
                {
                    if (userInput3 == inputs)
                    {
                        isValid = true;
                        break;
                    }
                }
                if (!isValid)
                {
                    Console.WriteLine("Your input was not valid.");
                    Console.WriteLine("Acceptable inputs are: add, subtract, multiply, divide.");
                    userInput3 = Console.ReadLine();
                    userInput3.ToLower();
                }
            }

            // Converts the user's input into a useable number
            num1 = Convert.ToDouble(userInput1);
            num2 = Convert.ToDouble(userInput2);

            //Output
            Console.WriteLine($"Your first input was: {userInput1}");
            Console.WriteLine($"Your second input was: {userInput2}");
            Console.WriteLine($"Your final number is {Calculate(num1, num2, userInput3)}");


            // Debugging: Console.WriteLine($"\nnum1 = {num1}");
            // Debugging: Console.WriteLine($"num2 = {num2}");
            // Debugging: Console.WriteLine(isValid);
        }
        // Method to calculate num1 and num2 based on the inputed operator
        static double Calculate(double num1, double num2, string operate)
        {
            switch (operate)
            {
                case "add":
                    return num1 + num2;
                case "+":
                    return num1 + num2;
                case "subtract":
                    return num1 - num2;
                case "-":
                    return num1 - num2;
                case "multiply":
                    return num1 * num2;
                case "*":
                    return num1 * num2;
                case "x":
                    return num1 * num2;
                case "divide":
                    return num1 / num2;
                case "/":
                    return num1 / num2;
                default:
                    return 0;
            }
        }
    }
}
