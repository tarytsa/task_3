using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExMethod
{
    static class DoubleEx
    {
        public static double Rational(this int a,int b)
        {
            double result = Convert.ToDouble(a)/Convert.ToDouble(b);
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            double result = a.Rational(7);
            Console.WriteLine("{0:f2}",result);
        }
    }
}
