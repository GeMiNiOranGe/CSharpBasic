using System;
using System.Collections;
using System.Reflection;    // GetProperties() method

namespace OOP {
    #region Shape OOP
    public abstract class HinhHoc {
        public double DienTich {
            get;
            set;
        }
        public double ChuVi {
            get;
            set;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();
        public override string ToString() => $"S = {Math.Round(DienTich, 2)}; P = {Math.Round(ChuVi, 2)}";
    }

    public class HinhChuNhat : HinhHoc {
        private double chieuDai;
        private double chieuRong;

        public HinhChuNhat(double _chieuDai = 1, double _chieuRong = 0.5) {
            chieuDai = _chieuDai;
            chieuRong = _chieuRong;
        }

        public double ChieuDai {
            get => chieuDai;
            set {
                if (value >= 0)
                    chieuDai = value;
                else
                    throw new Exception("Chieu dai khong duoc am");
            }
        }
        public double ChieuRong {
            get => chieuRong;
            set {
                if (value >= 0)
                    chieuRong = value;
                else
                    throw new Exception("Chieu Rong khong duoc am");
            }
        }

        public override double GetArea() => DienTich = ChieuDai * ChieuRong;
        public override double GetPerimeter() => ChuVi = (ChieuDai + ChieuRong) * 2;
        public override string ToString() => $"L = {ChieuDai}; W = {ChieuRong}; {base.ToString()}";
    }

    public class HinhTron : HinhHoc {
        private double banKinh;

        public HinhTron(double _banKinh = 0) {
            banKinh = _banKinh;
        }

        public double BanKinh {
            get => banKinh;
            set {
                if (value >= 0)
                    banKinh = value;
                else
                    throw new Exception("Ban kinh khong duoc am");
            }
        }

        public override double GetArea() => DienTich = Math.Pow(BanKinh, 2) * Math.PI;
        public override double GetPerimeter() => ChuVi = BanKinh * 2 * Math.PI;
        public override string ToString() => $"R = {BanKinh}; {base.ToString()}";
    }
    #endregion

    #region Animal non-static
    interface ICalculate {
        double GetRatio();
    }

    class Animal {
        private double weight, height;

        public Animal(double _weight = 0, double _height = 0) {
            this.weight = _weight;
            this.height = _height;
        }
        public Animal(Animal animal) {
            this.weight = animal.weight;
            this.height = animal.height;
        }

        public double Weight {
            get => this.weight;
            set => this.weight = value;
        }
        public double Height {
            get => this.height;
            set => this.height = value;
        }

        public override string ToString() {
            return "Weight: " + Weight + " | Height: " + Height;
        }

    }

    class Cat : Animal, ICalculate {
        private string species;
        private int age;

        public Cat(double _weight = 0, double _height = 0, int _age = 0, string _species = "") : base(_weight, _height) {
            this.age = _age;
            this.species = _species;
        }
        public Cat(Cat cat) : base(cat) {
            this.age = cat.age;
            this.species = cat.species;
        }

        public string Species {
            get => this.species;
            set => this.species = value;
        }
        public int Age {
            get => this.age;
            set => this.age = value;
        }

        public override string ToString() {
            return base.ToString() + " | Species: " + Species + " | Age: " + Age;
        }

        public double GetRatio() {
            return Weight * Height * Age;
        }
    }

    public class SortCatsAge : IComparer {
        public int Compare(object x, object y) {
            Cat cat1 = x as Cat;
            Cat cat2 = y as Cat;

            if (cat1 == null || cat2 == null) throw new InvalidOperationException();
            if (cat1.Age > cat2.Age) return 1;
            if (cat1.Age == cat2.Age) return 0;
            return -1;
        }
    }
    #endregion

    #region SinhVien static
    class SinhVien {
        private string maSV, ten;
        private static double diemToan, diemVan, diemLy;

        public SinhVien(string _MASV = "", string _Ten = "", double _diemToan = 0, double _diemVan = 0, double _diemLy = 0) {
            maSV = _MASV;
            Ten = _Ten;
            diemToan = _diemToan;
            diemVan = _diemVan;
            diemLy = _diemLy;
        }

        public string MaSV {
            get => maSV;
            set => maSV = value;
        }
        public string Ten {
            get => ten;
            set => ten = value;
        }
        public static double DiemToan {
            get => diemToan;
            set {
                if (0 <= value && value <= 10) {
                    diemToan = value;
                }
            }
        }
        public static double DiemVan {
            get => diemVan;
            set {
                if (0 <= value && value <= 10) {
                    diemToan = value;
                }
            }
        }
        public static double DiemLy {
            get => diemLy;
            set {
                if (0 <= value && value <= 10) {
                    diemToan = value;
                }
            }
        }

        public static double TinhDiemTrungBinh() {
            return (DiemToan + DiemVan + DiemLy) / 3;
        }
    }
    #endregion

    class Program {
        static void Main(string[] args) {
            #region Animal and SinhVien, learn OOP C#
            //SinhVien svTemp = new SinhVien();
            //SinhVien.DiemToan = 15;
            //SinhVien.DiemVan = 7;
            //SinhVien.DiemLy = 5;
            //Console.WriteLine(SinhVien.TinhDiemTrungBinh());

            //HinhHoc temp;
            //temp = new HinhChuNhat(5, 3);
            //temp.GetArea();
            //temp.GetPerimeter();
            //Console.WriteLine(temp.ToString());
            //temp = new HinhTron(5);
            //temp.GetArea();
            //temp.GetPerimeter();
            //Console.WriteLine(temp.ToString());
            #endregion

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

            //var tuple = new Tuple<int, Cat>(2, new Cat(15, 30, 15, "Home Cat"));
            //var tuple2 =Tuple.Create(new Cat(25, 20, 50, "Mike Cat"), new Cat(15, 30, 15, "Home Cat"));
            //Console.WriteLine($"1 con meo: {tuple.Item2.ToString()}\nmeo thu 2, 2 con meo: {tuple2.Item2.ToString()}");

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
