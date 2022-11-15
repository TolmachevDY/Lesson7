using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void GetParamCube(double a, out double v, out double s)
        {
            v = a * a * a;
            s = a * a * 6;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону куба a");
            double a = Convert.ToDouble(Console.ReadLine());
            double v, s;
            v = s = 0;
            GetParamCube(a, out v, out s);
            Console.WriteLine("\nОбъём куба:{0:f2}\n" +
                                "Площадь куба:{1:f2}", v, s);
            Console.ReadKey();
        }
    }
}
