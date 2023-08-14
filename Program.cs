using System;

namespace Learn
{
    class Program
    {
        public static void Main()
        {
            int[] nums = {8,5,4,1,2,9,7,3,6};
            BubleSort.SortingInt(nums);
            foreach(var i in nums)
            {
                Console.Write(i);
            }
        }
    }


    public static class BubleSort{
        public static void SortingInt(int[] array)
        {
            bool isSorted = false;
            
            for(int i = 0;i<array.Length;i++)
            {
                isSorted = false;

                for(int j = 1;j<array.Length-i;j++)
                {
                    if(array[j-1] > array[j])//0 > 1
                    {
                        //Swap  1 =0 |0 = 1
                        int temp = array[j];//1
                        array[j] = array[j-1];
                        array[j-1] = temp;

                        isSorted = false;
                    }

                    if(isSorted)return;//continue to next index
                }
            }

        }


    }

    public static class InsertionSort
    {
        public static void SortingInt(int[] arr)
        {

        }
    }
}