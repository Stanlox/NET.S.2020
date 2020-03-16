using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2020._02
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tRezult of Task3");
            var tuple1 = Task3.FindNextBiggerNumberTimer(513);
            Console.WriteLine($"Received result: {tuple1.correctNumber} \t Execution time: {tuple1.time}");
            var  tuple2 = Task3.FindNextBiggerNumberTimer(2017);
            Console.WriteLine($"Received result: {tuple2.correctNumber} \t Execution time: {tuple2.time}");
            var tuple3 = Task3.FindNextBiggerNumberTimer(414);
            Console.WriteLine($"Received result: {tuple3.correctNumber} \t Execution time: {tuple3.time}");
            var tuple4 = Task3.FindNextBiggerNumberTimer(144);
            Console.WriteLine($"Received result: {tuple4.correctNumber} \t Execution time: {tuple4.time}");
            var tuple5 = Task3.FindNextBiggerNumberTimer(1234321);
            Console.WriteLine($"Received result: {tuple5.correctNumber} \t Execution time: {tuple5.time}");
            var tuple6 = Task3.FindNextBiggerNumberTimer(3456432);
            Console.WriteLine($"Received result: {tuple6.correctNumber} \t Execution time: {tuple6.time}");
            var tuple7 = Task3.FindNextBiggerNumberTimer(10);
            Console.WriteLine($"Received result: {tuple7.correctNumber} \t Execution time: {tuple7.time}");
            var tuple8 = Task3.FindNextBiggerNumberTimer(20);
            Console.WriteLine($"Received result: {tuple8.correctNumber} \t Execution time: {tuple8.time}");
            Console.WriteLine();
            Console.WriteLine("\tThe results of the other tasks are described in the tests");
            Console.ReadKey();
        }
    }
}

