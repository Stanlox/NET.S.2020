using System;

namespace NET.S._2020.Bandaruk._01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                Console.WriteLine(" Input elements of array:");
                int elementCounts = int.Parse(Console.ReadLine());
                int[] array = new int[elementCounts];
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("{0}-element  ", i);
                    array[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Ordered array using algorithm Merge sort : {0}", string.Join(", ", MergeSort.MergSort(array, 0, array.Length - 1)));
                QuickSort.QuickSorting(array, 0, array.Length - 1);
                Console.WriteLine("Ordered array using algorithm Quick sort : {0}", string.Join(", ", array));

                Console.ReadLine();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
