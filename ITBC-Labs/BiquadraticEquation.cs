using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class BiquadraticEquation
    {
        private int A, B, C;
        private double[] solution;
        public BiquadraticEquation(int[] values)
        {
            this.A = values[0];
            this.B = values[1];
            this.C = values[2];
        }
        public void SolveEquation()
        {
            if (this.CheckForLackOfSolutions())//Проверка на наличие решений
            {//Если их нет
                this.solution = null;
            } else {//Если они есть
                if (this.A == 0 || this.B == 0 || this.C == 0) this.IncompleteEquation();
                //Если хотя бы один из коэффицентов занулён, то решение уравнения сводится к поиску корней в обход дискриминанта
                else this.CompleteEquation();
            }
        }

        private bool CheckForLackOfSolutions()//Возвращает истину, если решений уравнения нет
        {
            if (this.A > 0 && this.B > 0 && this.C > 0) return true;
            if (this.A < 0 && this.B < 0 && this.C < 0) return true;
            //Если все коэффиценты имеют одинаковый знак, то действительных решений у такого биквадратного уравнения не существует из-за чётности степеней аргумента
            if (this.A == 0 && this.B == 0 && this.C != 0) return true;
            //1 уравнение, 0 переменных => решений нет
            return false;
        }

        private void IncompleteEquation()//Решение неполного уравнения, где хотя бы один коэффицент - ноль
        {
            if (this.A == 0 && this.B != 0 && this.C != 0)
            {//B * x^2 + C = 0
                double temp = (double)C / -B;//Значение x^2
                if (temp > 0) {
                    this.solution = new double[2] { Math.Sqrt(temp), -Math.Sqrt(temp) };
                } else this.solution = null;
                return;
            }

            if (this.C == 0 && (this.A == 0 || this.B == 0))
            {//B * x^2 = 0 или A * x^4 = 0
                this.solution = new double[1] { 0 };
                return;
            }

            if (this.A != 0 && this.B != 0 && this.C == 0)
            {//A * x^4 + B * x^2 = 0
                double temp = (double)B / -A;
                if (temp > 0)
                {
                    this.solution = new double[3] { 0, Math.Sqrt(temp), -Math.Sqrt(temp)};
                } else
                {
                    this.solution = new double[1] { 0 };
                }
                return;
            }

            if (this.A != 0 && this.B == 0 && this.C != 0)
            {//A * x^4 + C = 0
                double temp = (double)C / -A;
                if (temp > 0)
                {
                    this.solution = new double[2] { Math.Sqrt(Math.Sqrt(temp)), -Math.Sqrt(Math.Sqrt(temp)) };
                } else this.solution = null;
                return;
            }
        }

        private void CompleteEquation()//Решение полного уравнения
        {
            double dscr = this.Discriminant();
            double t1 = (-this.B + Math.Sqrt(dscr)) / (2 * this.A),
                   t2 = (-this.B - Math.Sqrt(dscr)) / (2 * this.A);
            if (t1 > 0)
            {
                if (t2 > 0)
                {
                    this.solution = new double[4] { Math.Sqrt(t1), -Math.Sqrt(t1), Math.Sqrt(t2), -Math.Sqrt(t2) };
                    return;
                }

                if (t2 == 0)
                {
                    this.solution = new double[3] { Math.Sqrt(t1), -Math.Sqrt(t1), 0 };
                    return;
                }

                if (t2 < 0)
                {
                    this.solution = new double[2] { Math.Sqrt(t1), -Math.Sqrt(t1) };
                    return;
                }
            }

            if (t1 == 0)
            {
                if (t2 > 0)
                {
                    this.solution = new double[3] { Math.Sqrt(t2), -Math.Sqrt(t2), 0 };
                    return;
                }

                if (t2 <= 0)
                {
                    this.solution = new double[1] { 0 };
                    return;
                }
            }

            if (t1 < 0)
            {
                if (t2 > 0)
                {
                    this.solution = new double[2] { Math.Sqrt(t2), -Math.Sqrt(t2) };
                    return;
                }

                if (t2 == 0)
                {
                    this.solution = new double[1] { 0 };
                    return;
                }

                if (t2 < 0)
                {
                    this.solution = null;
                    return;
                }
            }
        }


        private float Discriminant()
        {
            return this.B * this.B - 4 * this.A * this.C;
        }

        public void Answer()
        {
            if (this.solution == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Данное уравнение не имеет действительных решений. ");
                Console.ResetColor();
                return;
            }

            Console.WriteLine("Список решений для уравнения: ");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < this.solution.Length; i++)
            {
                Console.WriteLine(this.solution[i]);
            }
            Console.ResetColor();
        }
    }
}
