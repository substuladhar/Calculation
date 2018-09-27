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
            Console.WriteLine("SUM = {0}", sum);
            Console.WriteLine("DIFFERENCE = {0}", difference);
            Console.WriteLine("PRODUCT = {0}", product);
            Console.WriteLine("Division={0}", divide);
            double power = pow(3, 2);
            Console.WriteLine("POWER = {0}", power);
            greatest(a, b);
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
        static void greatest(double a,double b)
        {
            Console.WriteLine("greatest number={0}",(Math.Max(a, b)));
        }
    }   

}
