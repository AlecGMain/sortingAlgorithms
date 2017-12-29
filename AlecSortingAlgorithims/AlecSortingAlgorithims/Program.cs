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

            for ( int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(0, 100);
            }
            for(int i = 0; i<array.Length; i++)
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

    }
}
