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
            double difference = subtract(a,b);
            Console.WriteLine("SUM = {0}", sum);
            Console.WriteLine("DIFFERENCE = {0}", difference);
            Console.ReadKey();
        }
          
        static double add(double a, double b)
        {
            return (a + b);
        }

        static double subtract(double a,double b)
        {
            return (a - b);
        }
    
    }
}
