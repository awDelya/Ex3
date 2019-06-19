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
        private static double x, y;//координаты точки
        private static bool Rezult()//для результата
        {
            bool ok = false;
            if (y - x / 2 <= 0 && x * x + y * y <= 1)
                ok = true;
            return ok;
        }
        static void Main()
        {
            Color.Print("\n Введите координаты точки:\n", ConsoleColor.Green);
            Color.Print(" X = ", ConsoleColor.Yellow);
            x = Number.Check(-100.0, 100.0);
            Color.Print(" Y = ", ConsoleColor.Yellow);
            y = Number.Check(-100.0, 100.0);
            if (Rezult())
                Color.Print(" Точка " + "(" + x + " ; " + y + ") принадлежит области." + "\n u = -3", ConsoleColor.Green);
            else
                Color.Print(" Точка " + "(" + x + " ; " + y + ") не принадлежит облатси. \n u = " + y * y, ConsoleColor.Red);
            Text.GoBackMenu();
        }
    }
}
