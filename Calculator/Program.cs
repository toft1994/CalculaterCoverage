using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");

            CalculatorClass Calculator = new CalculatorClass();

            while (true)
            {
                Console.WriteLine("Choose operation:");
                Console.WriteLine("1: Add");
                Console.WriteLine("2: Subtract");
                Console.WriteLine("3: Multiply");
                Console.WriteLine("4: Divide");
                Console.WriteLine("5: Power");

                double switchVar = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("First number:");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Second number:");
                double b = Convert.ToDouble(Console.ReadLine());

                double result;

                switch (switchVar)
                {
                    case 1:
                        result = Calculator.Add(a, b);
                        break;
                    case 2:
                        result = Calculator.Subtract(a, b);
                        break;
                    case 3:
                        result = Calculator.Multiply(a, b);
                        break;
                    case 4:
                        result = Calculator.Divide(a, b);
                        break;
                    case 5:
                        result = Calculator.Power(a, b);
                        break;
                    default:
                        result = 0;
                        break;
                }

                Console.WriteLine("Result: " + result);
                Console.WriteLine();
            }
        }
    }
}
