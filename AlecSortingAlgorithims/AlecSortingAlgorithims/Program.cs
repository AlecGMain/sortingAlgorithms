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
            int[] array = new int[100];
            Random r = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(0, 100);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}, ", array[i]);
            }
            Console.WriteLine();

            array = BubbleSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}, ", array[i]);
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
            for(int i = 1; i < array.Length; i++)
            {
                int place = i;
                bool smaller = true;
                while(smaller)
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
    }
}
