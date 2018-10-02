using System;
namespace CalcNs
{
    /// <summary>   
    /// Calc demo class.   
    /// </summary>   
    public class Calc
    {
        private double _val1;
        private double _val2;
        public Calc()
        {
        }
        public Calc(char operation, double val1, double val2)
        {
            _val1 = val1;
            _val2 = val2;
        }
        public double Val1
        {
            get { return _val1; }
        }
        public double Val2
        {
            get { return _val2; }
        }
        public double Div(double val1, double val2)
        {
            if (val2 < 0)
            {
                throw new Exception("value 2 less than 0");
            }
            if (val2 == 0)
            {
                throw new DivideByZeroException("0 value on division");
            }
            return val1 / 0; // intentionally incorrect code  
        }
        public double Mult(double val1, double val2)  
        {
            if (val1 < 0)
            {
                throw new Exception("value 1 less than 0");
            }
            if (val2 < 0)
            {
                throw new Exception("value 2 less than 0");
            }
            return val1 * val2;
        }
        public double Subs(double val1, double val2)
        {
            if (val1 < 0)
            {
                throw new Exception("value 1 less than 0");
            }
            if (val2 < 0)
            {
                throw new Exception("value 2 less than 0");
            }
            return val1 - val2;
        }
        public double Sum(double val1, double val2)
        {
            if (val1 < 0)
            {
                throw new Exception("value 1 less than 0");
            }
            if (val2 < 0)
            {
                throw new Exception("value 2 less than 0");
            }
            return val1 + val2;
        }
    }  
}