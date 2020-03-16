using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2020._02
{
    /// <summary>
    /// Contains static method <see cref="FilterDigit/>.
    /// </summary>
    public class Task4
    {
        /// <summary>
        /// Returns list with only numbers that contains <paramref name="number"/> digit.
        /// </summary>
        /// <param name="number">The digit to be found in numbers</param>
        /// <param name="array">The list with numbers </param>
        /// <exception cref="ArgumentNullException">Array is empty</exception>
        /// <exception cref="ArgumentOutOfRangeException">Negative argument</exception>
        /// <returns>List with only numbers that contains specified digit</returns>
        public static List<int> FilterDigit(int number,  int[] array)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Еhe argument can't be negative");
            }
            if (array == null)
            {
                throw new ArgumentNullException("Array is empty");
            }
            string numberView = number.ToString();
            List<int> listContainingNumber = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                string arrayView = array[i].ToString();
                if (arrayView.Contains(numberView))
                    listContainingNumber.Add(array[i]);
            }
            return listContainingNumber;
        }
    }
}
