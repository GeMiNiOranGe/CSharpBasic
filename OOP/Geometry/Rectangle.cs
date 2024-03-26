using System;

namespace OOP.Geometry {
    public class Rectangle : GeometryCalculator {
        private double length;
        private double width;

        public Rectangle(double length = 1, double width = 0.5) {
            this.length = length;
            this.width = width;
        }

        public double Length {
            get => length;
            set {
                if (value >= 0)
                    length = value;
                else
                    throw new Exception("length cannot be negative");
            }
        }
        public double Width {
            get => width;
            set {
                if (value >= 0)
                    width = value;
                else
                    throw new Exception("width cannot be negative");
            }
        }

        public override double CalculateArea() => Area = Length * Width;
        public override double CalculatePerimeter() => Perimeter = (Length + Width) * 2;
        public override string ToString() => $"L = {Length}; W = {Width}; {base.ToString()}";
    }
}
