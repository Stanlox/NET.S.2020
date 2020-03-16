using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace NET.S._2020._02
{
    /// <summary>
    /// Contains static method <see cref="FindNextBiggerNumberTimer"/>.
    /// </summary>
    public class Task3
    {
        /// <summary>
        /// Returns next bigger number that consists of the same digits as specified number.
        /// Also the time spent on the calculation
        /// </summary>
        /// <param name="num">Target Number</param>
        /// <returns>Next bigger number if it exists and the run time of finding the next bigger number</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="num"/> is less than or equal 0</exception>
        public static (int correctNumber, TimeSpan time) FindNextBiggerNumberTimer(int num)
        {
                if (num <= 0) throw new ArgumentOutOfRangeException();
                Stopwatch sw = new Stopwatch();
                sw.Start();
                num = Task2.FindNextBiggerNumber(num);
                sw.Stop();
                var time = sw.Elapsed;
                var rezult = (num, time);
                return rezult;
             
        }
     }
}

