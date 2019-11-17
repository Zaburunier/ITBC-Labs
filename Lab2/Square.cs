using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Square : Rectangle
    {
        public Square() : base() { }
        public Square(double W): base() {
            this.Width = W;
        }
        public override double GetSquare(){
 	        return Math.Round(this.Width * this.Width, 2);
        }
        public override void Print() {
            Console.Write("Сторона квадрата: " + this.Width);
            Console.Write("; его площадь - " + Convert.ToString(this.GetSquare()) + System.Environment.NewLine);
            
        }
    }
}