using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;    // GetProperties() method

using OOP.Animals;
using OOP.Geometry;
using OOP.Others;

namespace OOP {
    public class SortCatsAge : IComparer {
        public int Compare(object x, object y) {
            Cat cat1 = x as Cat;
            Cat cat2 = y as Cat;

            if (cat1 == null || cat2 == null)
                throw new InvalidOperationException();
            if (cat1.Age > cat2.Age)
                return 1;
            if (cat1.Age == cat2.Age)
                return 0;
            return -1;
        }
    }

    class Program {
        static void Main(string[] args) {
            #region Student with static method
            //Student student = new Student();
            //Student.MathScore = 15;
            //Student.LiteratureScore = 7;
            //Student.PhysicsScore = 5;
            //Console.WriteLine(Student.CalculateAverageScore());
            #endregion

            #region Geometry
            //GeometryCalculator calculator;

            //calculator = new Rectangle(5, 3);
            //calculator.CalculateArea();
            //calculator.CalculatePerimeter();
            //Console.WriteLine(calculator.ToString());

            //calculator = new Circle(5);
            //calculator.CalculateArea();
            //calculator.CalculatePerimeter();
            //Console.WriteLine(calculator.ToString());
            #endregion

            #region Animal
            //arrayListCat.Sort(new SortCatsAge());
            //SortedList sortedListCat = new SortedList();

            //List<Cat> cats = new List<Cat>();
            //cats.Add(new Cat(15, 30, 15, "Home Cat"));
            //cats.Add(new Cat(25, 20, 50, "Mike Cat"));
            //cats.Add(new Cat(10, 50, 10, "Blue Cat"));
            //cats.Add(new Cat(35, 40, 25, "Awww Cat"));
            //cats.Add(new Cat(65, 90, 55, "This Cat"));
            //cats.Add(new Cat(90, 65, 30, "Good Cat"));

            //foreach (DictionaryEntry item in sortedListCat) {
            //    Console.WriteLine("   " + item.Key.ToString() + "   " + item.Value.ToString());
            //}

            //for (int i = 0; i < cats.Count; i++) {
            //    Console.WriteLine(cats[i]);
            //}
            #endregion

            #region Tuple
            //var tuple = new Tuple<int, Cat>(2, new Cat(15, 30, 15, "Home Cat"));
            //var tuple2 = Tuple.Create(new Cat(25, 20, 50, "Mike Cat"), new Cat(15, 30, 15, "Home Cat"));
            //Console.WriteLine($"1 con meo: {tuple.Item2}\nmeo thu 2, 2 con meo: {tuple2.Item2}");
            #endregion

            #region get all attribute in a class
            //Animal animal = new Animal(15, 20);
            //PropertyInfo[] propInfos = animal.GetType().GetProperties();
            //Console.WriteLine(propInfos[0].GetValue(animal));
            //foreach (var propInfo in propInfos) {
            //    bool readable = propInfo.CanRead;
            //    bool writable = propInfo.CanWrite;
            //    Console.WriteLine("Read: {0}", readable);
            //    Console.WriteLine("Write: {0}", writable);
            //    Console.WriteLine(propInfo.GetValue(animal));
            //}
            #endregion

            Console.ReadKey();
        }

    }
}
