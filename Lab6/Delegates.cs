using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public delegate double Del(int num1, int num2, string str);
    class Delegates
    {
        public static double Product(int num1, int num2, string str) //Метод, соответствующий делегату
        {
            double tempRes = num1 * num2 * Convert.ToDouble(str);
            return tempRes;
        }

        public static void ProductGetsDelegate(double ratio, int num1, int num2, string str, Del del) //Метод, принимающий делегат
        {
            Console.WriteLine(ratio * del(num1, num2, str));
        }

        public static void ProductGetsDelegate_Gen(double ratio, int num1, int num2, string str, Func<int, int, string, double> del) //Метод, принимающий делегат
        {
            Console.WriteLine(ratio * del(num1, num2, str));
        }
    }
}
