using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{

    public class Class1
    {
        public static void Swap(int[] a, int i, int j)
        {
            int t = a[i];
            a[i] = a[j];
            a[j] = t;

        }
        public static int Partition(int[] a, int l, int r)
        {
            int ndx = l;
            int pivot = a[l];
            for (int i = l + 1; i <= r; i++)
            {
                if (a[i] < pivot)
                {
                    ndx++;
                    Swap(a, ndx, i);
                }
            }
            Swap(a, ndx, l);
            return ndx;
        }
        public static void QuickSort(int[] a, int l, int r)
        {
            if (l < r)
            {
                int pi = Partition(a, l, r);
                QuickSort(a, l, pi - 1);
                QuickSort(a, pi + 1, r);

            }
        }
    }
}



