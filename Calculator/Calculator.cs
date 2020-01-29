using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorClass
    {
        public static void CalculatorClass()
        {
            Accumulator = 0;
        }

        public static double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }

        public static double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }

        public static double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }

        public static double Divide(double a, double b)
        {
            Accumulator = a / b;
            return Accumulator;
        }

        public static double Power(double a, double b)
        {
            Accumulator = Math.Pow(a, b);
            return Accumulator;
        }

        public double Accumulator { get; private set; }
    }
}
