using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDataStructure.Sorting
{
    public  class SelectionSort
    {
        private int[] Data;
        private static Random generator = new Random();

        public SelectionSort(int size)
        {
            Data= new int[size];
            for (int i = 0; i < size; i++)
            {
                Data[i] = generator.Next(20, 90);
            }
        }

        public void Sort()
        {
            Console.WriteLine("\n Sorted Array Elements (Step by Step )\n\n");
            DisplayArrayElemnts();
            for(int i = 0; i < Data.Length-1; i++)
            {
                int smallest = i;
                for(int Index = i + 1; Index < Data.Length; Index++)
                {
                    if (Data[Index] < Data[smallest])
                        smallest = Index;
                }
                Swap(i, smallest);
                DisplayArrayElemnts();
            }
        }
       
        private  void Swap( int First,int Second)
        {
            int temp = Data[First];
            Data[First] = Data[Second];
            Data[Second] = temp;
        }

        private void DisplayArrayElemnts()
        {
            foreach (var element in Data)
            {
                Console.WriteLine(element + "  ");
            }
            Console.WriteLine("\n\n");
        }
    }
}
