using System;

namespace MergeSortAlgorithm
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 12, 4, 5, 6, 7, 3, 1, 15 };
            Console.WriteLine("Unsorted array:");
            PrintArray(arr);

            MergeSortAlgorithm(arr, 0, arr.Length - 1);

            Console.WriteLine("\nSorted array:");
            PrintArray(arr);
        }

        static void MergeSortAlgorithm(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSortAlgorithm(array, left, mid);
                MergeSortAlgorithm(array, mid + 1, right);

                Merge(array, left, mid, right);
            }
        }

        static void Merge(int[] array, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            Array.Copy(array, left, leftArray, 0, n1);
            Array.Copy(array, mid + 1, rightArray, 0, n2);

            int i = 0, j = 0, k = left;

            while (i < n1 && j < n2)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                array[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
