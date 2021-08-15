using System;
using System.Collections.Generic;

namespace AlgorithmAndDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {

            #region LinearSearch
           // LinearSearchExample();
            #endregion 
            #region BinarySearch
           // BinarySearchExample();
            #endregion 
            #region BinarySearch
            SelectionSortExample();
            #endregion


            Console.ReadKey();
            
        }

        private static void SelectionSortExample()
        {
            throw new NotImplementedException();
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
            int[] orders = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15,
                16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
 
            
            BinarySearch.FindValueViaBinarySearch(orders, 17);
         
        }
        public static void SelectionSort()
        {

        }
    }
}
