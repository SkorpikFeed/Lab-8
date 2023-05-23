using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_8_C_
{
    internal class Expression
    {
        private double a;
        private double b; 
        private double c; 
        private double d;
        public Expression(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public double A { get { return a; } set { a = value; } }
        public double B { get { return b; } set { b = value; } }
        public double C { get { return c; } set { c = value; } }
        public double D { get { return d; } set { d = value; } }
        public string Calculate()
        {
            try
            {
                double res = (Math.Log((4 * b) - c) * a) / (b + (c / d) - 1);
                if (d == 0) 
                {
                    throw new Exception("Operand d cannot be 0");
                }
                if ((4 * b) - c == 0) 
                {
                    throw new Exception("The logarithm argument cannot be 0");
                }
                if ((4 * b) - c < 0) 
                {
                    throw new Exception("The logarithm argument cannot be negative");
                }
                if (b + (c / d) - 1 == 0) 
                {
                    throw new Exception("You cannot divide by 0");
                }
                return res.ToString();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ResetColor();
                return "Your expression doesn`t make any sence";
            }
        }
        public void Print()
        {
            Console.WriteLine("Result: " + Calculate());
        }
    }
}
