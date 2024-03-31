#nullable disable
using System;

namespace p1015
{
    class PS
    {
        public static void Main(String[] args)
        {
            /*
            int len = Convert.ToInt32(Console.ReadLine());
            String str = Console.ReadLine();
            String[] strArr = str.Split();
            int[] A = new int[len];
            int[] B = new int[len];
            int[] P = new int[len];
            for(int i = 0; i < len; i++)
                A[i] = Convert.ToInt32(strArr[i]);
                */

            int[] test = {3, 7, 8, 4, 6, 5, 1, 9, 2};
            quickSort(test, 0, test.Length);
        }

        public static void quickSort(int[] arr, int start, int end)
        {
            Console.WriteLine($"start QuickSort: {start} to {end}");
            if(Math.Abs(start - end) <= 1)  return;         // return if this quickSort is done
            int low = 0, high = 0;
            Random rand = new Random();
            int pivotIndex = rand.Next(start, end);
            int pivot = arr[pivotIndex];
            Console.WriteLine(String.Format("pivotIndex: {0}, pivotVal: {1}", pivotIndex, pivot));
            for(int i = start; i < end; i++)
            {
                if(i == start)  {low = i; high = end-1-i;}    // initialize
                
                if(arr[low] <= pivot)    // change low until low gets higher than pivot
                {
                    low++;
                }
                if(arr[high] >= pivot)   // change high until high gets lower than pivot
                {
                    high--;
                }
                Console.WriteLine($"low: {low}, high: {high}");

                // if low is higer than pivot and high is lower than pivot
                // swap low and high
                if(arr[low] > pivot && arr[high] < pivot)
                {
                    Console.WriteLine($"swap object: swap {arr[low]} at {low} with {arr[high]} at {high}");
                    int temp = arr[low];
                    arr[low] = arr[high];
                    arr[high] = temp;
                }

                if(high == low || (low + 1) == high)  // swap pivot and end of low then break if all compare is done.
                {
                    int temp = arr[low];
                    arr[low] = arr[pivotIndex];
                    arr[pivotIndex] = temp;
                    Console.Write("current result: ");
                    foreach(int index in arr)
                    {
                        Console.Write(index + " ");
                    }
                    Console.WriteLine();
                    quickSort(arr, start, low);           // quickSort lower side of pivot
                    quickSort(arr, high, end);   // quickSort upper side of pivot
                    break;
                }


            }
        }
    }
}