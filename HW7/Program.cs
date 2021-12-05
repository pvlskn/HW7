using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Два треугольника заданы длинами своих сторон. 
 * Определить, площадь какого из них больше (создать метод для вычисления  площади  треугольника по длинам его сторон).  
 * Для решения задачи можно использовать формулу Герона */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите длины трёх сторон первого треугольника: ");
        double a1 = Convert.ToDouble(Console.ReadLine());
        double b1 = Convert.ToDouble(Console.ReadLine());
        double c1 = Convert.ToDouble(Console.ReadLine());
        double S1 = TriangleSqu(a1, b1, c1);
        Console.WriteLine("Введите длины трёх сторон второго треугольника: ");
        double a2 = Convert.ToDouble(Console.ReadLine());
        double b2 = Convert.ToDouble(Console.ReadLine());
        double c2 = Convert.ToDouble(Console.ReadLine());
        double S2 = TriangleSqu(a2, b2, c2);
        if (S1 > S2)
        {
            Console.WriteLine("Площадь первого треугольника больше.");
        }
        else if (S2 > S1)
        {
            Console.WriteLine("Площадь второго треугольника больше.");
        }
        else if (S2 == S1)
        {
            Console.WriteLine("Площади треугольников равны.");
        }
        Console.WriteLine("Нажмите любую клавишу для выхода.");
        Console.ReadKey();
    }
    static double TriangleSqu(double a, double b, double c)
    {
        double P = 0.5 * (a + b + c);
        double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
        return S;
    }
}
