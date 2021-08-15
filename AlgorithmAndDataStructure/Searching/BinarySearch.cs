using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDataStructure
{
    public static class BinarySearch
    {
        public static bool FindValueViaBinarySearch(int[] input,int searchValue)
        {
            var lower = 0;
            var upper=input.Length-1;

            while (upper >= lower)
            {
                var mid = (upper + lower) / 2;
                if (input[mid] == searchValue)
                {
                    //  Console.WriteLine("found value" +"true");
                    return true;
                }
                else if (searchValue < input[mid])
                {
                    upper = mid - 1;
                }
                else
                {
                    lower = mid + 1;
                  
                }
            }
            return false;
        }
    }
}
