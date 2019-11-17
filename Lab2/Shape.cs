using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2 
{
    public abstract class Shape : IPrint, IComparable
    {
        public virtual double GetSquare() { return 0; }
        public Shape() { }
        public virtual void Print() {
            Console.Write("; его площадь - " + Convert.ToString(this.GetSquare()) + System.Environment.NewLine);
        }
        public int CompareTo(object obj) {
            Shape shape = (Shape) obj;
            if (this.GetSquare() > shape.GetSquare()) return 1;
            else if (this.GetSquare() == shape.GetSquare()) return 0;
            else return -1;
        }

        public override string ToString()
        {
            return Convert.ToString(this.GetSquare());
        }
    }
}
