using System;
using System.Collections.Generic;
using System.Text;

namespace NET.S._2020.Bandaruk._01
{
    /// <summary>
    /// Class contains methods for  merge sorting 
    /// </summary>
    class MergeSort
    {
        /// <summary>
        /// Sorts elements from <paramref name="lowIndex"/> to <paramref name="highIndex"/> in passed array.
        /// </summary>
        /// <param name="array">Target array</param>
        /// <param name="lowIndex">The zero-based position of the start of block part to be sorted</param>
        /// <param name="middleIndex">Element in the centre of array</param>
        /// <param name="highIndex">The zero-based position of the end of block part to be sorted</param>
        public static void Merge(int[] array, int lowIndex, int middleIndex, int highIndex)
        {
            int left = lowIndex;
            int right = middleIndex + 1;
            int[] tempArray = new int[highIndex - lowIndex + 1];
            int index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (array[left] < array[right])
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }

                index++;
            }
            //copying the remaining values to the right part
            for (int i = left; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }
            //copying the remaining values to the left part
            for (int i = right; i <= highIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }
            
            //for (int i = 0; i < tempArray.Length; i++)
            //{
            //    array[lowIndex + i] = tempArray[i];
            //}
            //re-write main array
            Array.Copy(tempArray, 0, array, lowIndex, tempArray.Length);
        }
        /// <summary>
        /// The method calls itself recursively to divide the array in half
        /// </summary>
        /// <param name="array">Target array</param>
        /// <param name="startIndex">The first index of the array </param>
        /// <param name="endIndex">The last index of the array </param>
        /// <returns>Sorted array</returns>
        public static int[] MergSort(int[] array, int startIndex, int endIndex)
        {
            if (array != null)
            {
                if (startIndex < endIndex)
                {
                    int middleIndex = (startIndex + endIndex) / 2;
                    MergSort(array, startIndex, middleIndex);
                    MergSort(array, middleIndex + 1, endIndex);
                    Merge(array, startIndex, middleIndex, endIndex);
                }
                return array;
            }
            throw new ArgumentNullException();
        }
    }
}

