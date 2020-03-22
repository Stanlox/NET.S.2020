using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2020._04.GreatestCommonDivisor
{
    /// <summary>
    /// Contains methods for finding Greatest Common Divisor
    /// </summary>
    public partial class FindGCD
    {
        /// <summary>
        /// Calculates the greatest common divisor using the algorithm Euclid with two input parameters.
        /// </summary>
        /// <param name="x">First element</param>
        /// <param name="y">Second element</param>
        /// <returns>Greatest common divisor</returns>
        public static int GCDUseEuclideanAlgorithm(int x, int y)
        {
            if (x == 0) return y;
            if (y == 0) return x;
            else if (x == y) return x;

            if (x < 0 || y < 0)
            {
                throw new ArgumentException();
            }


            while (x != y)
            {
                if (x > y)
                {
                    ExchangeOfPlaces(ref x, ref y);
                }
                y = y - x;
                ExchangeOfPlaces(ref x, ref y);
            }
            return x;
        }

        public static void ExchangeOfPlaces(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        /// <summary>
        /// Calculates the greatest common divisor using the algorithm Euclid with an array of input parameters.
        /// </summary>
        /// <param name="array">Input array</param>
        /// <exception cref="ArgumentException">Not enough number of arguments</exception>
        /// <returns>Greatest common divisor</returns>
        public static int GCDUseEuclideanAlgorithm(int[] numbers)
        {
            if (numbers.Length < 2)
                throw new ArgumentException();

            int GCDIteartedArray = GCDUseEuclideanAlgorithm(numbers[0], numbers[1]);

            for (int i = 2; i < numbers.Length; i++)
            {
                GCDIteartedArray = GCDUseEuclideanAlgorithm(GCDIteartedArray, numbers[i]);
            }
            return GCDIteartedArray;
        }

        /// <summary>
        /// Calculates the greatest common divisor using the binary algorithm Steina with an array of input parameters.
        /// </summary>
        /// <param name="x">First element</param>
        /// <param name="y">Second element</param>
        /// <returns>Greatest common divisor</returns>
        public static int GCDUseSteinaAlgorithm(int x, int y)
        {
            if (x == 0) return y;
            if (y == 0) return x;
            else if (x == y) return x;

            if (x < 0 || y < 0)
            {
                throw new ArgumentException();
            }

            int IntermidiateRezult;

           
            

            if ((x & 1) == 0)
            {
                IntermidiateRezult = ((y & 1) == 0) ? GCDUseSteinaAlgorithm(x >> 1, y >> 1) << 1 : GCDUseSteinaAlgorithm(x >> 1, y);
            }
            else
            {
                IntermidiateRezult = ((y & 1) == 0) ? GCDUseSteinaAlgorithm(x, y >> 1) : GCDUseSteinaAlgorithm(y, x > y ? x - y : y - x);
            }
            return IntermidiateRezult;
        }


        /// <summary>
        /// Calculates the greatest common divisor using the binary algorithm Steina with an array of input parameters.
        /// </summary>
        /// <param name="array">Input array</param>
        /// <exception cref="ArgumentException">Not enough number of arguments</exception>
        /// <returns>Greatest common divisor</returns>
        public static int GCDUseSteinaAlgorithm(int[] numbers)
        {
            if (numbers.Length < 2)
                throw new ArgumentException();

            int GCDIteartedArray = GCDUseSteinaAlgorithm(numbers[0], numbers[1]);

            for (int i = 0; i < numbers.Length; i++)
            {
                GCDIteartedArray = GCDUseSteinaAlgorithm(GCDIteartedArray, numbers[i]);
            }
            return GCDIteartedArray;
        }


        /// <summary>
        /// Calculate GCD of 2, 3 and more numbers by Euclidean algorithm and show time
        /// </summary>
        /// <param name="number">Input array</param>
        /// <returns>GCD of 2, 3 and more numbers</returns>
        public static (int correctGCD, TimeSpan time) EuclideanGCDTime(params int[] number)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int result = GCDUseEuclideanAlgorithm(number);
            timer.Stop();
            var time = timer.Elapsed;
            var ExitParameters = (result, time);
            return ExitParameters;
        }

        /// <summary>
        /// Calculate GCD of 2, 3 and more numbers by Euclidean algorithm and show time
        /// </summary>
        /// <param name="number">Input array</param>
        /// <returns>GCD of 2, 3 and more numbers</returns>
        public static (int correctGCD, TimeSpan time) SteinaGCDTime(params int[] number)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int result = GCDUseSteinaAlgorithm(number);
            timer.Stop();
            var time = timer.Elapsed;
            var ExitParameters = (result, time);
            return ExitParameters;
        }
    }
}
    