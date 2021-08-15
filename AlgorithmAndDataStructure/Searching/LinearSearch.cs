
using System;

namespace AlgorithmAndDataStructure
{
    public static class LinearSearch
    {
        
        public static void FindValueViaLinearSearch(int input,int searchValue)
        {
            if (input== searchValue)
            {
                Console.WriteLine(input +"|"+ "Search value found");
               
            }
            else {
                Console.WriteLine(input + "|" + "No Matchs ");
                
            }
            
        }

    }
}
