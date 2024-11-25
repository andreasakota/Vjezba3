using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Quick
    {
        public delegate bool Comparison(object a, object b);

        public static void Sort(object[] array, int left, int right, Comparison cmp)
        {
            if (left >= right) return;
            int last = Partition(array, left, right, cmp);
            Sort(array, left, last - 1, cmp);
            Sort(array, last + 1, right, cmp);
        }

        public static int Partition(object[] array, int left, int right,Comparison cmp)
        {
            int pivotIndex = left;
            object pivot = array[left];
            Swap(array, left, right);

            for (int i = left; i < right; i++)
            {
                if (cmp(array[i], pivot))
                {
                    Swap(array, i, pivotIndex);
                    pivotIndex++;
                }
            }
            Swap(array, pivotIndex, right);
            return pivotIndex;
        }

        public static void Swap(object[] array, int first, int second)
        {
            object temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}
