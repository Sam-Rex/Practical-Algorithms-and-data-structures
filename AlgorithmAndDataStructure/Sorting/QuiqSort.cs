
namespace AlgorithmAndDataStructure.Sorting
{
    public class QuiqSort
    {
        public void Sort(int[] array,int left,int right) 
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);
                if (pivot > 1)
                {
                    Sort(array, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Sort(array, pivot + 1, right);
                }
            }
        }
        private int Partition(int[] GivenArray,int Left,int Right)
        {
            int pivot = GivenArray[Left];
            while (true)
            {
                while (GivenArray[Left] < pivot)
                {
                    Left++;
                }
                while (GivenArray[Right] > pivot)
                {
                    Right--;
                }
                if (Left < Right)
                {
                    if (GivenArray[Left] == GivenArray[Right])
                        return Right;
                    int temp = GivenArray[Left];
                    GivenArray[Left] = GivenArray[Right];
                    GivenArray[Right] = temp;
                }
                return Right;
            }
            
        }

        
    }
}
