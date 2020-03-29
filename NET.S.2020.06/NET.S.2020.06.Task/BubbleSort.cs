using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2020._06
{
    /// <summary>
    /// Consists methods for sorting jagged arrays
    /// </summary>
    public class BubbleSort
    {

        /// <summary>
        /// Sort by increasing sums of the single-dimensional arrays
        /// </summary>
        /// <param name="array">Input jagged array</param>
        /// <returns>Sorted array</returns>
        public static int[][] AscendingSortSumElements(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (sumElementsInArray(array[i]) > sumElementsInArray(array[j]))
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
            return array;
        }



        /// <summary>
        /// Sort by decreasing sums of the single-dimensional arrays
        /// </summary>
        /// <param name="array">Input jagged array</param>
        /// <returns>Sorted array</returns>
        public static int[][] DescendingSortSumElements(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (sumElementsInArray(array[i]) < sumElementsInArray(array[j]))
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
            return array;
        }


        /// <summary>
        /// Sort by increasing max elements of the single-dimensional arrays
        /// </summary>
        /// <param name="array">Input jagged array</param>
        /// <returns>Sorted array</returns>
        public static int[][] AscendingSortMaxElements(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (MaxElement(array[i]) > MaxElement(array[j]))
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
            return array;
        }



        /// <summary>
        /// Sort by decreasing max elements of the single-dimensional arrays
        /// </summary>
        /// <param name="array">Input jagged array</param>
        /// <returns> Sorted array </returns>
        public static int[][] DescendingSortMaxElements(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (MaxElement(array[i]) < MaxElement(array[j]))
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
            return array;
        }


        /// <summary>
        /// Sort by increasing min elements of the single-dimensional arrays
        /// </summary>
        /// <param name="array">Input jagged array</param>
        /// <returns> Sorted array </returns>
        public static int[][] AscendingSortMinElements(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (MinElement(array[i]) > MinElement(array[j]))
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
            return array;
        }


        /// <summary>
        /// Sort by decreasing min elements of the single-dimensional arrays
        /// </summary>
        /// <param name="array">Input jagged array</param>
        /// <returns> Sorted array </returns>
        public static int[][] DescendingSortMinElements(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (MinElement(array[i]) < MinElement(array[j]))
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
            return array;
        }


        /// <summary>
        /// Returns the sum of elements of the single-dimensional array
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Sum of elements of the row</returns>
        public static int sumElementsInArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }


        /// <summary>
        /// Method for swapping single-dimensional arrays
        /// </summary>
        /// <param name="array1">Input array 1</param>
        /// <param name="array2">Input array 2</param>
        public static void Swap(ref int [] array1, ref int[] array2)
        {
            int[] temp = array1;
            array1 = array2;
            array2 = temp;
        }



        /// <summary>
        /// Method for searching the maximum value
        /// </summary>
        /// <param name="array">Input array</param>
        /// <returns> Maximum value in the array </returns>
        public static int MaxElement(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }



        /// <summary>
        /// Method for searching the minimum value
        /// </summary>
        /// <param name="array">Input array</param>
        /// <returns> Minimum value in the array </returns>
        public static int MinElement(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }      
    }
}

