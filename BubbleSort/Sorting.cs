using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class Sorting
    {
        public static void BubbleSort(int[] array)
        {
            for (int partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                for (int i = 0; i < partIndex; i++)
                {
                    if(array[i] > array[i+1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
            }
        }

        public static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = 1; j < array.Length - 1; j++)
                {
                    if (array[i] < array[j])
                    {
                        Swap(array, array[i], array[j]);
                    }
                }
            }
        }

        private static void Swap(int[] array, int i, int j)
        {
            if (i == j) return;
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

    }
}
