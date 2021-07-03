using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract
{
    class Class1
    {
        public static BinaryInterface BinarySwitch(int count)
        {
            switch (count)
            {
                case 0:
                    return new Plus();

                case 1:
                    return new Minus();

                case 2:
                    return new Multiply();

                case 3:
                    return new Share();

                default:
                    return new Plus();
            }
        }
    }

    interface BinaryInterface
    {
        double Calculate(double firstValue, double secondValue);
    }

    class Plus : BinaryInterface
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
    }
    class Minus : BinaryInterface
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }
    class Multiply : BinaryInterface
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
    }
    class Share : BinaryInterface
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue / secondValue;
        }
    }
}

