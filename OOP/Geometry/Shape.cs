using System;

namespace OOP.Geometry {
    public abstract class GeometryCalculator {
        public double Area {
            get;
            set;
        }
        public double Perimeter {
            get;
            set;
        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
        public override string ToString() => $"S = {Math.Round(Area, 2)}; P = {Math.Round(Perimeter, 2)}";
    }
}
