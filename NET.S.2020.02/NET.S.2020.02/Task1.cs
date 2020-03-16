using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2020._02
{/// <summary>
/// Contains static method <see cref="InsertNumber"/>.
/// </summary>
    public class Task1
    {
        /// <summary>
        /// Inserts bits of <paramref name="numberin"/> to <paramref name="numberSource"/>
        /// from range [<paramref name="i"/>..<paramref name="j"/>] and returns result value.
        /// </summary>
        /// <param name="numberSource">The bits will be inserted in this number</param>
        /// <param name="numberin">The bits will be taken from this number</param>
        /// <param name="i">Start index of bit</param>
        /// <param name="j">End index of bit</param>
        /// <exception cref="Exception">Invalid data</exception>
        /// <returns>Result of inserting bits of <paramref name="numberIn"/> to <paramref name="numberSource"/></returns>
        public static int InsertNumber(int numberSource, int numberin, int i, int j)
        {
            const int minPosition = 0;
            const int maxPosition = 31;

            if (j < i || i < minPosition || j < minPosition || i > maxPosition || j > maxPosition) throw new Exception("Invalid data");

            uint uNumberin = (uint)numberin;

            // Left shift and restore to cut off the unnecessary data

            int unnecessaryData = maxPosition - (j - i);

            uNumberin = uNumberin << unnecessaryData >> unnecessaryData;

            // Left shift to set the desired length

            uNumberin <<= i;
            return numberSource | (int)uNumberin;
        }
    }
}
