using System;

namespace AspNetCore.UnitTestDemo.Api
{

    public interface ICalculatorService
    {
        double Add(double value1, double value2);
        double Subtract(double value1, double value2);
        double Multiply(double value1, double value2);
        double Divide(double value1, double value2);
    }

    public class Calculator : ICalculatorService
    {
        public double Add(double value1, double value2)
        {
            return value1 + value2;
        }

        public double Subtract(double value1, double value2)
        {
            return value1 - value2;
        }

        public double Multiply(double value1, double value2)
        {
            return value1 * value2;
        }

        public double Divide(double value1, double value2)
        {
            if(value2 == 0)
            {
                throw new InvalidOperationException("Argument can not be zero");
            }
            return value1 / value2;
        }
    }
}