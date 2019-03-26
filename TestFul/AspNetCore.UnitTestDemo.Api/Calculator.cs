using System;

namespace AspNetCore.UnitTestDemo.Api
{
    public class Calculator
    {
        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        public int Subtract(int value1, int value2)
        {
            return value1 - value2;
        }

        public int Multipy(int value1, int value2)
        {
            return value1 * value2;
        }

        public int Divide(int value1, int value2)
        {
            if(value2 == 0)
            {
                throw new InvalidOperationException("Argument can not be zero");
            }
            return value1 / value2;
        }
    }
}