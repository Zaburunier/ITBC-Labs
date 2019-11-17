using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Забурунов Леонид, РТ5-31Б";
            char ending;
            do
            {
                Figures();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Если хотите продолжить, введите 1: ");
                Console.ResetColor();
                ending = Convert.ToChar(Console.ReadLine());
            } while (ending == '1');
            Console.ReadKey();
        }

        static void Figures() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Нажмите 1 для работы с прямоугольником, 2 - для работы с квадратом, 3 - для работы с кругом: ");
            char choose = Convert.ToChar(Console.ReadLine());
            Console.ResetColor();
            switch (choose)
            {
                case '1':
                    Rectangle R = new Rectangle();
                    Console.WriteLine("Введите стороны прямоугольника: ");
                    double w = Convert.ToDouble(Console.ReadLine()), h = Convert.ToDouble(Console.ReadLine());
                    R.Width = w;
                    R.Height = h;
                    Console.ForegroundColor = ConsoleColor.Green;
                    R.Print();
                    Console.ResetColor();
                    break;
                case '3': 
                    Circle C = new Circle();
                    Console.WriteLine("Введите радиус круга: ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    C.Radius = r;
                    Console.ForegroundColor = ConsoleColor.Green;
                    C.Print();
                    Console.ResetColor();
                    break;
                case '2': 
                    Square S = new Square();
                    Console.WriteLine("Введите сторону квадрата: ");
                    double l = Convert.ToDouble(Console.ReadLine());
                    S.Width = l;
                    Console.ForegroundColor = ConsoleColor.Green;
                    S.Print();
                    Console.ResetColor();
                    break;
            }

        }
    }

}
