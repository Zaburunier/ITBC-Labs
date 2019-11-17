using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Забурунов Леонид, РТ5-31Б";
            ArrayList ArrayListShapes = new ArrayList();
            List<Shape> Shapes = new List<Shape>();
            ArrayListProcessing(ArrayListShapes);
            ListTProcessing(Shapes);
            SparseMatrix<Shape> x = new SparseMatrix<Shape>(4, 3, 3, new Square(0));
            MatrixProcessing(x);
            SimpleStack<Shape> List = new SimpleStack<Shape>();
            StackProcessing(List);
            Console.ReadLine();
            Console.ReadKey();
        }

        static void ArrayListProcessing(ArrayList Shapes)//Обработка первой коллекции
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nРабота с ArrayList:");
            Console.ResetColor();
            Processing(Shapes);
            PrintElements(Shapes);
        }

        static void ListTProcessing(List<Shape> Shapes)//Обработка второй коллекции
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nРабота с List<Shape>:");
            Console.ResetColor();
            Processing(Shapes);
            Sorting(Shapes);
            PrintElements(Shapes);
        }

        static void MatrixProcessing(SparseMatrix<Shape> X)//Обработка разреженной матрицы
        {
            X[0, 0, 1] = new Circle(14);
            X[1, 1, 1] = new Rectangle(6, 12);
            X[1, 2, 2] = new Circle(5);
            X[2, 1, 0] = new Square(14.56);

            try
            {
                X[10, 10, 3] = new Square(30);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Разреженная матрица:");
            Console.ResetColor();
            Console.WriteLine(X);
        }

        static void StackProcessing(SimpleStack<Shape> List)//Обработка стэка
        {
            List.Push(new Circle(30));
            List.Push(new Rectangle(30, 4.5));
            List.Push(new Circle(10.8));
            List.Push(new Square(6.9));
            List.Push(new Rectangle(10.6, 7));
            List.Push(new Square(13));
            int quantity = List.Count;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nСтек:");
            Console.ResetColor();
            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine(List.Pop());
            }
        }

        static void Sorting(IList Shapes)//Сортировка коллекции вставками
        {
            for (int i = 0; i < Shapes.Count; i++)
            {
                Shape temp = (Shape)Shapes[i];
                //Текущий объект записывается в отдельную переменную, чтобы не потерять его при смещении во время циклов
                int j = i;
                while (j >= 1 && temp.CompareTo(Shapes[j - 1]) < 0)
                //Для всех элементов, стоящих ранее текущего, производится проверка по площади: 
                //если площадь объекта, с которым вызывается метод, меньше площади сравниваемого, то происходит смещение
                //сравниваемого объекта на 1 вперёд
                {
                    Shapes[j] = Shapes[j - 1];
                    j--;
                }
                //Как только появляется первое несовпадение с заданным условием, то в место сравниваемого объекта записывается текущий объект
                Shapes[j] = temp;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("List<Shape> отсортирован! \n");
            Console.ResetColor();
        }
        static void Processing(IList Shapes)//Ввод данных
        {
            char ending;
            int counter = 1;
            do
            {
                Console.WriteLine("Элемент #" + counter);
                NewElement(Shapes);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Если хотите продолжить, введите 1: ");
                Console.ResetColor();
                ending = Convert.ToChar(Console.ReadLine());
                counter++;
            } while (ending == '1');
        }
        static void NewElement(IList ShapesList)//Запись данных в новый элемент списка
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Нажмите 1 для добавления в коллекцию прямоугольника, 2 - квадрата, 3 - круга: ");
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
                    ShapesList.Add(R);
                    break;
                case '3':
                    Circle C = new Circle();
                    Console.WriteLine("Введите радиус круга: ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    C.Radius = r;
                    ShapesList.Add(C);
                    break;
                case '2':
                    Square S = new Square();
                    Console.WriteLine("Введите сторону квадрата: ");
                    double l = Convert.ToDouble(Console.ReadLine());
                    S.Width = l;
                    ShapesList.Add(S);
                    break;
            }
        }

        static void PrintElements(IList ShapesList)//Вывод всех полученных и обработанных данных
        {
            Console.WriteLine("\nСписок введённых элементов: \n");
            foreach(Shape E in ShapesList)
            {
                E.Print();
            }
            Console.WriteLine("\n\n");
        }

    }
}
