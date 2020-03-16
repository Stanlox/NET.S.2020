using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2020._02
{
    /// <summary>
    /// Contains static method <see cref="FindNextBiggerNumber"/>.
    /// </summary>
    public class Task2
    {
        /// <summary>
        /// Returns next bigger number that consists of the same digits as specified number
        /// </summary>
        /// <param name="number">Target number</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="number"/> is less than or equal to 0.</exception>
        /// <returns>Next bigger number if it exists</returns>
        public static int FindNextBiggerNumber(int number)
        {
            if (number <= 0) throw new ArgumentOutOfRangeException();
            int[] arrayNumbers = Array.ConvertAll(number.ToString().ToCharArray(), x => (int)Char.GetNumericValue(x));

            if (HasNoBiggerNumber(arrayNumbers))
            {
                return -1;
            }

            int temp = 0;
            for (int i = arrayNumbers.Length - 1; i > 0; i--)
            {
                if (arrayNumbers[i] > arrayNumbers[i - 1])
                {
                    temp = arrayNumbers[i];
                    arrayNumbers[i] = arrayNumbers[i - 1];
                    arrayNumbers[i - 1] = temp;
                    temp = i;
                    break;
                }
            }

            Array.Sort(arrayNumbers, temp, arrayNumbers.Length - temp);
            int rezult = Convert.ToInt32(String.Join("", arrayNumbers));
            return rezult;

        }

        public static bool HasNoBiggerNumber(int[] array)
        {
            int check = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] >= array[i + 1])
                {
                    check++;
                }
            }

            if (check == array.Length - 1)
            {
                return true;
            }

            return false;
        }
    }
}
