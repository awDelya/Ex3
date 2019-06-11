using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_methods;

namespace PointOnChart
{
    class Program
    {
        static void Main()
        {
            Color.Print("\n Введите координаты точки:\n", ConsoleColor.Magenta);
            Color.Print(" X = ", ConsoleColor.Green);
            double x = Number.Check(-100.0, 100.0);
            Color.Print(" Y = ", ConsoleColor.Green);
            double y = Number.Check(-100.0, 100.0);
            if (y - x / 2 <= 0 && x * x + y * y <= 1)
                Color.Print(" Зашло" + "(" + x + " ; " + y + ") " + "\n u = -3", ConsoleColor.Green);
            else
                Color.Print(" Вылетела " + "(" + x + " ; " + y + ") u = " + y * y, ConsoleColor.Red);
            Text.GoBackMenu();
        }
    }
}
