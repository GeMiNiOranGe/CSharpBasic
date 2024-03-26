using System;

namespace OOP.Geometry {
    public class Circle : GeometryCalculator {
        private double radius;

        public Circle(double radius = 0) {
            this.radius = radius;
        }

        public double Radius {
            get => radius;
            set {
                if (value >= 0)
                    radius = value;
                else
                    throw new Exception("Ban kinh khong duoc am");
            }
        }

        public override double CalculateArea() => Area = Math.Pow(Radius, 2) * Math.PI;
        public override double CalculatePerimeter() => Perimeter = Radius * 2 * Math.PI;
        public override string ToString() => $"R = {Radius}; {base.ToString()}";
    }

}
