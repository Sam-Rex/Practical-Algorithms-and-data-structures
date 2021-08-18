using AlgorithmAndDataStructure.Sorting;
using System;
using System.Collections.Generic;

namespace AlgorithmAndDataStructure
{
    class Program
    {

        private static int[] orders = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15,
                16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

        static void Main(string[] args)
        {

            #region LinearSearch
            // LinearSearchExample();
            #endregion
            #region BinarySearch
            // BinarySearchExample();
            #endregion
            #region Selection Sort
            //SelectionSortExample();
            #endregion
            #region Quick Sort
            QuickSortExample();
            #endregion


            Console.ReadKey();
            
        }

        private static void QuickSortExample()
        {
            int[] arr = new int[] {  45, 4, 1, -8, 6, 11, 25, 78, 12, -74, 13, 94 };
            Console.WriteLine("Original Array: ");
            foreach (var item in arr)
            {
                Console.WriteLine(" "+item);
            }
            Console.WriteLine();
            QuickSort quickSort = new();
            quickSort.Sort(arr, 0, arr.Length - 1);
            Console.WriteLine();
            Console.WriteLine("Sorted Array:  ");
            foreach (var item in arr)
            {
                Console.WriteLine(" "+item);
            }
            Console.WriteLine();
        }

        private static void SelectionSortExample()
        {
            SelectionSort selection= new SelectionSort(10);
            selection.Sort();
        }

        public static void LinearSearchExample()
        {
            int orders;
            for (int i = 0; i < 20; i++)
            {
                orders = i;
                LinearSearch.FindValueViaLinearSearch(orders, 15);
            }
        } 
        public static void BinarySearchExample()
        {
            BinarySearch.FindValueViaBinarySearch(orders, 17);
        }
       
    }
}
