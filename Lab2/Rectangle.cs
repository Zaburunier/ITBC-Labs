using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Rectangle : Shape
    {
        protected double width;
        private double height;

        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }
        
        public double Height {
            get { return this.height; }
            set { this.height = value; } 
        }

        public Rectangle() { } 
        public Rectangle(double W, double H) {
            this.Width = W;
            this.Height = H;
        }

        public override double GetSquare() { return Math.Round(this.Height * this.Width, 2); }

        public override void Print() {
            Console.Write("Стороны прямоугольника: " + this.Width + ", " + this.Height);
            base.Print();
        }
    }
}
