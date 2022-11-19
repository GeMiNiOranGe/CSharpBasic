using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;               //Stopwatch
using System.Text.RegularExpressions;   //Regex

//.NET Framework 4.8.1
namespace CSharpBasic {
    class Program {
        static void Main(string[] args) {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            //a = double.Parse(Console.ReadLine());
            //b = double.Parse(Console.ReadLine());
            //a = Convert.ToInt32(Console.ReadLine());
            //b = Convert.ToInt32(Console.ReadLine());
            xuLyChuanHoaChuoiVaTaoEmail();

            Console.ReadKey();
        }
        #region object co the luu bat ki kieu du lieu nao
        //object[] vs = new object[10];
        //string str1 = "asdasd";
        //int iTemp = 1;
        //float fTemp = 1.5F;
        //vs[0] = str1;
        //    vs[1] = iTemp;
        //    vs[2] = fTemp;
        //    for (int i = 0; i< 10; i++) {
        //        Console.WriteLine(vs[i]);
        //    }
        #endregion

        #region kiểu dữ liệu struct
        struct SV {
            public string MASV;
            public double diemTB;
        }
        static void nhapSV(out SV svTemp) {
            svTemp.MASV = Console.ReadLine();
            svTemp.diemTB = double.Parse(Console.ReadLine());
        }
        static void xuatSV(SV svTemp) {
            Console.WriteLine(svTemp.MASV);
            Console.WriteLine(svTemp.diemTB);
        }
        #endregion

        #region check speed code
        /*Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        //check speed some code in here

        stopwatch.Stop();
        Console.WriteLine();
        Console.Write("{0:00} Day, {1:00} Hour, {2:00} Minute, {3:00} Second, {4:000} MiliSecond, {5:00000} Tick",
            stopwatch.Elapsed.Days, stopwatch.Elapsed.Hours, stopwatch.Elapsed.Minutes,
            stopwatch.Elapsed.Seconds, stopwatch.Elapsed.Milliseconds, stopwatch.Elapsed.Ticks);*/
        #endregion

        #region Baitap2
        static void phuongTrinhBat1() {
            Console.WriteLine("nhập hệ số phương trình ax + b = 0");
            double a = 0, b = 0;
            input(ref a, ref b);
            if (a == 0)
                if (b == 0)
                    Console.WriteLine("vô số nghiệm");
                else
                    Console.WriteLine("vô nghiệm");
            else {
                double x = -b / a;
                Console.WriteLine($"phương trình có nghiệm x = {x.ToString()}");
            }
        }
        static void input(ref double a, ref double b) {
            a = checkInput();
            b = checkInput();
        }
        static double checkInput() {
            double tempNumber;
            Console.Write("số được nhập là: ");
            for (; !double.TryParse(Console.ReadLine(), out tempNumber);) {
                Console.WriteLine("đây không phải là số, mời nhập lại");
                Console.Write("số được nhập là: ");
            }
            return tempNumber;
        }
        #endregion

        #region dùng foreach để duyệt mảng
        // Mang 1 chieu voi foreach
        static void showArray1DWithForeach() {
            int[] arrayTemp = { 1, 5, 2, 9, 4, 4, 8 };
            Console.WriteLine("Mảng đã được xử lý");
            foreach (var item in arrayTemp) {
                Console.Write("{0,-2}", item);
            }

        }
        // Mang 2 chieu voi foreach
        static void showArrayZigZacWithForeach() {
            int[][] arrayTemp = {
                new int[] { 1, 5, 2, 9, 4, 4 },
                new int[] { 1, 2, 4, 7, 7, 6, 2, 9, 3, 5 },
                new int[] { 9, 2, 4 }
            };
            Console.WriteLine("Mảng đã được xử lý");
            foreach (int[] element in arrayTemp) {
                foreach (var item in element) {
                    Console.Write("{0,-2}", item);
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region Baitap3
        //  Mang 1 chieu
        static void sumArray1D() {
            Console.Write("Nhập số lượng phần tử của mảng: ");
            int length = int.Parse(Console.ReadLine());
            int tong = 0;
            int[] temp = new int[length];
            for (int i = 0; i < temp.GetLength(0); i++) {
                Console.Write("Nhập phần tử vị trí {0}: ", i);
                temp[i] = int.Parse(Console.ReadLine());
                tong += temp[i];
            }
            Console.WriteLine("Tổng của mảng là: {0}", tong);
        }
        //  Mang 2 chieu
        static void sumArray2D() {
            Console.Write("Nhập số dòng của mảng: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột của mảng: ");
            int column = int.Parse(Console.ReadLine());
            int[,] arrayTemp = new int[row, column];
            int tong = 0;
            for (int i = 0; i < arrayTemp.GetLength(0); i++) {
                for (int j = 0; j < arrayTemp.GetLength(1); j++) {
                    Console.Write("Nhập phần tử vị trí {0} - {1}: ", i, j);
                    arrayTemp[i, j] = int.Parse(Console.ReadLine());
                    tong += arrayTemp[i, j];
                }
            }
            Console.WriteLine("Mảng đã được nhập vào:");
            for (int i = 0; i < arrayTemp.GetLength(0); i++) {
                for (int j = 0; j < arrayTemp.GetLength(1); j++) {
                    Console.Write("{0,-2}", arrayTemp[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Tổng của mảng 2 chiều là: {0}", tong);
        }
        #endregion

        #region Baitap4 chuẩn hóa chuỗi để tạo email
        static void xuLyChuanHoaChuoiVaTaoEmail() {
            //Console.Write("Nhập họ và tên: ");
            //string fullName = Console.ReadLine();
            string fullName = "          ngUYễn       PhẠm    tHỊ    văN      bÉ         BỐn     ";
            Console.WriteLine("Chuỗi gốc: " + fullName);

            //Chuan hoa chuoi va viet hoa ky tu dau moi tu
            string result = CapitalizeEachWord(Regex.Replace(fullName.Trim(), @"\s+", " ").ToLower());
            Console.WriteLine("Chuẩn hóa và viết hoa chữ cái đầu: " + result);

            //Cat chuoi thanh tung tu
            MatchCollection nameCollection = Regex.Matches(result, @"\b\w+");

            //Tach tung phan cua chuoi ten day du thanh: ho, ten dem, ten
            string lastName = nameCollection[0].ToString();
            StringBuilder middleName = new StringBuilder();
            for (int i = 1; i < nameCollection.Count - 1; i++) {
                middleName.Append(nameCollection[i] + " ");
            }
            string firstName = nameCollection[nameCollection.Count - 1].ToString();

            //Xuat cac phan duoc tach
            Console.WriteLine($"Họ: {lastName}");
            Console.WriteLine($"Tên đệm: {middleName}");
            Console.WriteLine($"Tên: {firstName}");

            //Xuat email duoc tao
            Console.WriteLine("Email: {0}", CreateEmail(nameCollection));
        }

        private static string CreateEmail(MatchCollection nameCollection) {
            StringBuilder strBDTemp = new StringBuilder($"{nameCollection[nameCollection.Count - 1]}");
            for (int i = 0; i < nameCollection.Count - 1; i++) {
                strBDTemp.Append($"{nameCollection[i]}"[0]);
            }
            strBDTemp.Append("@email.com");
            return ConvertToNonAccentVietnamese(strBDTemp.ToString().ToLower());
        }

        public static string ConvertToNonAccentVietnamese(string strInput) {
            return Regex.Replace(strInput.Normalize(NormalizationForm.FormD), @"\p{IsCombiningDiacriticalMarks}+", String.Empty)
                .Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        public static string CapitalizeEachWord(string input) {
            return Regex.Replace(input, @"\b\w", (Match match) => match.Value.ToString().ToUpper());
        }
        #endregion
    }
}
