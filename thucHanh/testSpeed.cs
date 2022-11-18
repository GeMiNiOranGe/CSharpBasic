using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace thucHanh {
    class testSpeed {
        static void Main(string[] args) {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Random random = new Random((int)DateTime.Now.Ticks);

            const int iSize = 20;
            int[] tempArray = new int[iSize];
            List<int> tempList = new List<int>();

            Console.Write("String input: ");
            for (int i = 0; i < iSize; i++) {
                tempArray[i] = random.Next(100);
                Console.Write(tempArray[i] + " ");
            }
            Console.WriteLine();
            
            //List
            //--------------------------------------------------------------------------------------------------------
            //Stopwatch stopwatchArrayList = new Stopwatch();
            //stopwatchArrayList.Start();

            ////check speed some code in here
            //for (int i = 0; i < iSize; i++) {
            //    tempList.Add(tempArray[i]);
            //}
            //tempList.Sort();

            //stopwatchArrayList.Stop();
            //Console.WriteLine("List: {0:00} Day, {1:00} Hour, {2:00} Minute, {3:00} Second, {4:000} MiliSecond, {5:00000} Tick",
            //    stopwatchArrayList.Elapsed.Days, stopwatchArrayList.Elapsed.Hours, stopwatchArrayList.Elapsed.Minutes,
            //    stopwatchArrayList.Elapsed.Seconds, stopwatchArrayList.Elapsed.Milliseconds, stopwatchArrayList.Elapsed.Ticks);
            //--------------------------------------------------------------------------------------------------------

            Console.WriteLine("\nSort String Num");
            foreach (var item in tempList) {
                Console.Write(item + " ");
            }



            Console.ReadKey();
        }
    }
}
