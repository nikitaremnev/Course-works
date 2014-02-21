using System;
namespace Библиотека_классов
{//класс функций 
    public class Functions 
    {
        //делегат для передачи выбранной функции 
        public delegate double FunctionVyb(double x, double y);
        //методы доступных функций
        public static double Function1(double x, double y)
        {
            return x * y;
        }
        public static double Function2(double x, double y)
        {
            return x*x + y * y;
        }
        public static double Function3(double x, double y)
        {
            return Math.Sin(x) + Math.Cos(x) + Math.Sin(y) + Math.Cos(y);
        }
        public static double Function4(double x, double y)
        {
            return x * Math.Cos(y) + y * y * Math.Sin(x);
        }
        public static double Function5(double x, double y)
        {
            return Math.Pow(x + y, 3) - 3 * x * y;
        }
        public static double Function6(double x, double y)
        {
            return (x / 3) + Math.Cos((x + 2 * y) / 7);
        }
        public static double Function7(double x, double y)
        {
            return Math.Pow(Math.Sin(x), 3) + Math.Sin(x) - Math.Cos(y) + Math.Pow(Math.Cos(y), 3);
        }
        public static double Function8(double x, double y)
        {
            return Math.Pow(x, 5) + Math.Pow(y, 2) - 3 * Math.Pow(x, 3) + 7 * Math.Pow(y, 4) - 2 * x * y;
        }
    }
}