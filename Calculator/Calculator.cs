using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorClass
    {
        public CalculatorClass()
        {
            Accumulator = 0;
        }

        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }

        public  double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }

        public  double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }

        public  double Divide(double a, double b)
        {
            Accumulator = a / b;
            return Accumulator;
        }

        public  double Power(double a, double b)
        {
            Accumulator = Math.Pow(a, b);
            return Accumulator;
        }

        public void Clear()
        {
            Accumulator = 0;
        }

        public double Accumulator { get; private set; }
    }
}
