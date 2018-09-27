using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double a = 2;
            double b = 4;

            double sum = add(a, b);
            double difference = subtract(a, b);
            double product = mul(a, b);
            double divide = division(a, b);
            double power = pow(3, 2);
            double small = smallest(a, b);
            Console.WriteLine("SUM = {0}", sum);
            Console.WriteLine("DIFFERENCE = {0}", difference);
            Console.WriteLine("PRODUCT = {0}", product);
            Console.WriteLine("DIVISION = {0}", divide);
            Console.WriteLine("POWER = {0}", power);
            Console.WriteLine("SMALLEST NUMBER = {0}", small);
            Console.ReadKey();
        }

        static double add(double a, double b)
        {
            return (a + b);
        }

        static double subtract(double a, double b)
        {
            return (a - b);
        }
        static double mul(double a, double b)
        {
            return (a * b);
        }

        static double division(double a, double b)
        {
            return (a / b);
        }

        static double pow(double a, double b)
        {
            return (Math.Pow(a, b));
        }

        static double smallest(double a,double b)
        {
            if (a < b)
                return (a);
            else
                return (b);
        }
    }   

}
