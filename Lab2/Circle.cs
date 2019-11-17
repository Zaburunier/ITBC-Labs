using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Circle : Shape
    {
        private double radius;

        public double Radius {
            get { return this.radius; }
            set { this.radius = value; }
        }
        public Circle() { }
        public Circle(double R) : base() { this.Radius = R; }

        public override double GetSquare() {
            return Math.Round(this.Radius * this.Radius * Math.PI, 2);
        }

        public override void Print() {
            Console.Write("Радиус круга: " + this.Radius);
            base.Print();
        }

    }
}
