using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2020._04
{
    /// <summary>
    /// Contains extencion method
    /// </summary>
    public static class ConverterToString
    {
        /// <summary>
        /// Implementing binary conversion using bit converter
        /// </summary>
        /// <param name="number">Input number</param>
        /// <returns>String in binary format</returns>
        public static string DoubleNumberConvertToString(this double number)
        {

            if (number == 0.0)
            {
                return Convert.ToString(BitConverter.DoubleToInt64Bits(number), 2).PadLeft(64, '0');
            }
            if (number == Double.Epsilon)
            {
                return Convert.ToString(BitConverter.DoubleToInt64Bits(number), 2).PadLeft(64, '0');
            }
            long bytes = BitConverter.DoubleToInt64Bits(number);
            string result = Convert.ToString(bytes, 2);
            if (number > 0)
            {
                result = 0 + result;
            }
            return result;
        }
    }
}
