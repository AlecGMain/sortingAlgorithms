using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlecSortingAlgorithims
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing algorithim.
            int[] array = new int[10];
            Random r = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(1, 100);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}");
                if(i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();

            array = QuickSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}");
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        static int[] BubbleSort(int[] array)
        {
            int allsort = 0;
            while (allsort != array.Length - 1)
            {
                allsort = 0;

                for (int i = 0; i < array.Length - 1; i++)
                {

                    if (array[i] > array[i + 1])
                    {
                        int second = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = second;

                    }
                    else
                    {
                        allsort++;
                    }

                }

            }

            return array;
        }
        static int[] SelectionSort(int[] array)
        {
            for (int j = 0; j < array.Length; j++)
            {
                int smallest = j;

                for (int i = j; i < array.Length; i++)
                {
                    if (array[i] < array[smallest])
                    {
                        smallest = i;
                    }
                }

                int second = array[smallest];
                array[smallest] = array[j];
                array[j] = second;

            }
            return array;
        }
        static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int place = i;
                bool smaller = true;
                while (smaller)
                {
                    if (place != 0 && array[place] < array[place - 1])
                    {
                        int second = array[place];
                        array[place] = array[place - 1];
                        array[place - 1] = second;
                        place--;
                    }
                    else
                    {
                        smaller = false;
                    }
                }

            }
            return array;
        }

        static int[] MergeSort(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }

            int[] left = new int[array.Length / 2];
            int[] right = new int[array.Length - left.Length];

            int i = 0;
            for (; i < left.Length; i++)
            {
                left[i] = array[i];
            }
            for (int j = 0; i < array.Length; i++, j++)
            {
                right[j] = array[i];
            }

            return Merge(MergeSort(left), MergeSort(right));

        }
        static int[] QuickSort(int[] array)
        {
            int pivotIndex = array.Length - 1;
            if (array.Length > 1)
            {
                for (int i = 0; i < array.Length - 2; i++)
                {
                    if (array[i] >= array[pivotIndex])
                    {
                        if (i + 1 == pivotIndex)
                        {
                            pivotIndex--;
                        }
                        int second = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = second;
                    }
                    else
                    {

                    }

                }
                int[] left = new int[(array.Length - 1) - ((array.Length - 1) - pivotIndex) + 1];
                int[] right = new int[(array.Length - 1) - (left.Length - 1)];
                for (int i = 0; i < left.Length - 1; i++)
                {
                    left[i] = array[i];
                }
                for (int i = pivotIndex + 1; i < array.Length; i++)
                {
                    right[i] = array[i];
                }
                left = QuickSort(left);
                right = QuickSort(right);

                for (int i = 0; i < left.Length - 1; i++)
                {
                    array[i] = left[i];
                }
                for (int i = pivotIndex + 1; i < array.Length; i++)
                {
                    array[i] = right[i];
                }
                return array;
            }
            else
            {
                return array;
            }
        }
//DO NOT RUN! NOT SEPERATE SORTING FUNCTION!
//USE MERGESORT INSTEAD!
        static int[] Merge(int[] left, int[] right)
        {
            int[] array = new int[left.Length + right.Length];
            int leftIndex = 0; 
            int rightIndex = 0;
            int combinedArrayIndex = 0;

            while (combinedArrayIndex < array.Length)
            {
                //Both left and right arrays still have data left that has not been copied
                if (leftIndex < left.Length && rightIndex < right.Length)
                {
                    //Determine if right or left side is smaller; copy the smaller value
                    if (left[leftIndex] >= right[rightIndex])
                    {
                        array[combinedArrayIndex] = right[rightIndex];
                        combinedArrayIndex++;
                        rightIndex++;
                    }
                    else
                    {
                        array[combinedArrayIndex] = left[leftIndex];
                        combinedArrayIndex++;
                        leftIndex++;
                    }
                }
                else
                {
                    //One of the arrays is fully copied (possibly both); check if there's any data left to copy 
                    if(leftIndex == left.Length && rightIndex < right.Length)
                    {
                        //Data is still left in the right array - copy it over
                        while(rightIndex < right.Length)
                        {
                            array[combinedArrayIndex] = right[rightIndex];
                            combinedArrayIndex++;
                            rightIndex++;
                        }
                    }
                    else if(rightIndex == right.Length && leftIndex < left.Length)
                    {
                        //Data is still left in the left array - copy it over
                        while(leftIndex < left.Length)
                        {
                            array[combinedArrayIndex] = left[leftIndex];
                            combinedArrayIndex++;
                            leftIndex++;
                        }
                    }
                }
            }
            //if (i > left.Length - 1)
            //{
            //    for (j = j; j < right.Length; j++, k++)
            //    {
            //        array[k] = right[j];
            //    }
            //}
            //else
            //{
            //    for (int l = 0; l < length; l++)
            //    {

            //    }

            //    for (int m = 0; m < left.Length; i++, k++)
            //    {
            //        array[k] = left[i];
            //    }
            //}


            return array;
        }
    }
}