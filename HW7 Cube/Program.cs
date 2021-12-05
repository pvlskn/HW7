using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создать метод для вычисления объема и площади поверхности куба по длине его ребра.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите длину ребра куба: ");
        double a = Convert.ToDouble(Console.ReadLine());
        double S = CubeSqu(a);
        double V = CubeVol(a);
        Console.WriteLine("Площадь поверхности куба равна {0}.", S);
        Console.WriteLine("Объём куба равен {0}.", V);
        Console.WriteLine("Нажмите любую клавишу для выхода.");
        Console.ReadKey();
    }
    static double CubeSqu(double a)
    {
        double S = 6 * a * a;
        return S;
    }
    static double CubeVol(double a)
    {
        double V = a * a * a;
        return V;
    }
}