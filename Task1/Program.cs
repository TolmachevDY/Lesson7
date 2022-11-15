using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static double TriangleS(int a, int b, int c)
        {
            //Console.WriteLine("Пришли {0} {1} {2}",a,b,c);
            double p = (a + b + c) / 2.0;            
            if (p * (p - a) * (p - b) * (p - c) <= 0) Console.WriteLine("Ошибка в вводе данных");
            return Math.Pow(p * (p - a) * (p - b) * (p - c), 0.5);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три стороны первого треугольника:");
            int[] t1 = new int[3];
            t1[0] = Convert.ToInt32(Console.ReadLine());
            t1[1] = Convert.ToInt32(Console.ReadLine());
            t1[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Площадь первого треугольника: {0:0.00}", TriangleS(t1[0], t1[1], t1[2]));

            Console.WriteLine("\nВведите три стороны второго треугольника:");
            int[] t2 = new int[3];
            t2[0] = Convert.ToInt32(Console.ReadLine());
            t2[1] = Convert.ToInt32(Console.ReadLine());
            t2[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Площадь второго треугольника: {0:0.00}", TriangleS(t2[0], t2[1], t2[2]));

            double st1, st2;
            st1 = TriangleS(t1[0], t1[1], t1[2]);
            st2 = TriangleS(t2[0], t2[1], t2[2]);
            if (st1 > st2) Console.WriteLine("\nПлощадь первого треуголька больше");
            else if (st1 < st2) Console.WriteLine("\nПлощадь второго треуголька больше");
            else Console.WriteLine("Площади треугольников равны");
            Console.ReadKey();
        }
    }
}
