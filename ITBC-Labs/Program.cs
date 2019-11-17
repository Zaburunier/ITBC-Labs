using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа №1. Забурунов Леонид, РТ5-31-2019";
            Console.WriteLine("Данная программа предназначена для решения уравнения вида A * x^4 + B  * x^2 + C = 0. ");
            GetNumbers();
            Console.ReadKey();
            return;
        }

        static void GetNumbers()
        {
            string answer = "1";
            bool error;//Переключатель, отвечающий за наличие ошибки при вводе коэффицентов
            do
            {
                error = false;//Изначальное состояние
                int[] rates = new int[3];//Для хранения коэффицентов
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Введите коэффицент " + Convert.ToChar(65 + i) + ": ");
                    try {
                        rates[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {//Если возникла ошибка ввода, то выбрасывается исключение, переключатель...переключается, и внешний цикл запускается заново
                        Console.WriteLine("Ошибка при вводе коэффицента, введите коэффиценты заново");
                        error = true;
                        break;
                    }
                }
                if (error) continue;
                Solutions(rates);
                Console.WriteLine("Хотите продолжить? (1, если хотите)");
                answer = Console.ReadLine();
            } while (answer == "1");
        }

        static void Solutions(int[] rates)
        {
            BiquadraticEquation equation = new BiquadraticEquation(rates);
            equation.SolveEquation();
            equation.Answer();
        }
    }
}
