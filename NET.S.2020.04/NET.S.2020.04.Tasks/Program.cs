using NET.S._2020._04.GreatestCommonDivisor;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2020._04
{
    class Program
    {
        static void Main(string[] args)
        {       
            var tuple1 = FindGCD.SteinaGCDTime(8, 16);
            Console.WriteLine($"Received result: {tuple1.correctGCD} \t Execution time: {tuple1.time}");
            var tuple2 = FindGCD.SteinaGCDTime(36, 45, 81, 9, 54, 3);
            Console.WriteLine($"Received result: {tuple2.correctGCD} \t Execution time: {tuple2.time}");
            var tuple3 = FindGCD.SteinaGCDTime(14, 28, 56, 112);
            Console.WriteLine($"Received result: {tuple3.correctGCD} \t Execution time: {tuple3.time}");
            var tuple4 = FindGCD.EuclideanGCDTime(8, 16);
            Console.WriteLine($"Received result: {tuple4.correctGCD} \t Execution time: {tuple4.time}");
            var tuple5 = FindGCD.EuclideanGCDTime(36, 45, 81, 9, 54, 3);
            Console.WriteLine($"Received result: {tuple5.correctGCD} \t Execution time: {tuple5.time}");
            var tuple6 = FindGCD.EuclideanGCDTime(14, 28, 56, 112);
            Console.WriteLine($"Received result: {tuple6.correctGCD} \t Execution time: {tuple6.time}");

            Console.ReadKey();

        }
    }
}
