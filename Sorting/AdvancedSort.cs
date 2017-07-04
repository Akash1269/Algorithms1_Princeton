using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class AdvancedSort
    {
        public static void MergeSort(int[] list)
        {
            int[] aux = new int[list.Length];
            _MergeSort(list, aux, 0, list.Length - 1);
        }

        private static void _MergeSort(int[] list,int[] aux, int low, int high)
        {
            if (high - low > 7)
            {
                int mid = (high - low) / 2 + low;
                _MergeSort(list, aux, low, mid);
                _MergeSort(list, aux, mid + 1, high);
                if (list[mid] > list[mid + 1])
                {
                    Merge(list, aux, low, mid, high);
                }
            }
            else
            {
                InsertionSort(list, low, high);
            }
        }

        private static void Merge(int[] list, int[] aux, int low, int mid, int high)
        {
            int i = low, j = mid + 1;

            for (int k = low; k <= high; k++)
            {
                aux[k] = list[k];
            }

            for (int k = low; k <= high; k++)
            {
                if(i > mid)
                {
                    list[k] = aux[j++];
                }
                else if (j > high)
                {
                    list[k] = aux[i++];
                }
                else if (aux[i].CompareTo(aux[j]) > 0)
                {
                    list[k] = aux[j++];
                }
                else
                {
                    list[k] = aux[i++];
                }
            }
        }

        public static void InsertionSort(int[] list, int low, int high)
        {
            for (int i = low; i <= high; i++)
            {
                for (int j = i; j > low; j--)
                {
                    if (list[j].CompareTo(list[j - 1]) < 0)
                    {
                        int temp = list[j];
                        list[j] = list[j - 1];
                        list[j - 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public static void BUMergeSort(int[] list)
        {
            int[] aux = new int[list.Length];
            for (int sz = 1; sz < list.Length; sz = sz + sz)
            {
                for (int i = 0; i < list.Length - sz; i = sz + sz + i)
                {
                    Merge(list, aux, i, i + sz - 1, Math.Min(list.Length - 1,i + sz + sz - 1));
                }
            }
        }

        private static int Partition(int[] list, int low, int high)
        {
            int i = low + 1, j = high, temp = 0;
            while(true)
            {
                while (list[i] <= list[low] && i < high) { i++; }
                while (list[j] >= list[low] && j > low) { j--; }

                if (i >= j) break;

                temp = list[i];
                list[i++] = list[j];
                list[j--] = temp;
            }
            temp = list[low];
            list[low] = list[j];
            list[j] = temp;
            return j;
        }

        private static void _QuickSort(int[] list, int low, int high)
        {
            if (high <= low + 5 - 1)
            {
                InsertionSort(list, low, high);
                return;
            }
            int j = Partition(list, low, high);
            _QuickSort(list, low, j - 1);
            _QuickSort(list, j + 1, high);
            
        }

        public static void QuickSort(int[] list)
        {
            _QuickSort(list, 0, list.Length - 1);
        }

        public static int QuickSelect(int[] list, int k)
        {
            int low = 0, high = list.Length - 1;
            while(low < high)
            {
                int j = Partition(list, low, high);
                if(j < k)
                {
                    low = j + 1;
                }
                else if(j > k)
                {
                    high = j - 1;
                }
                else
                {
                    return list[k];
                }
            }
            return list[k];
        }

        //Not Working
        public static void ThreeWayQuickSort(int[] list)
        {
            _ThreeWayQuickSort(list, 0, list.Length - 1);
        }
        public static void _ThreeWayQuickSort(int[] list, int low, int high)
        {
            if (high <= low)
                return;
            
            int lt = low, gt = high, i = low, temp = 0, v = list[low];
            while(i <= gt)
            {
                if(list[i] < v)
                {
                    temp = list[i];
                    list[i] = list[lt];
                    list[lt] = temp;
                    i++; lt++;
                }
                else if (list[i] > v)
                {
                    temp = list[i];
                    list[i] = list[gt];
                    list[gt] = temp;
                    gt--;
                }else
                {
                    i++;
                }
            }
            _ThreeWayQuickSort(list, low, lt - 1);
            _ThreeWayQuickSort(list, gt + 1, high);
            
        }

        public static void HeapSort(int[] a)
        {
            int n = a.Length - 1;
            for (int i = n / 2; i >= 0; i--)
            {
                Sink(a, i, n);
            }
            while (n > 0)
            {
                Swap(ref a[0],ref a[n]);
                Sink(a, 0, --n);
            }
        }

        private static void Sink(int[] a, int i, int n)
        {
            while(i * 2 < n)
            {
                int j = 2 * i + 1;
                if (j < n && a[j + 1] > a[j]) j++;
                if (a[i] > a[j]) break;
                Swap(ref a[i], ref a[j]);
                i = j;
            }
        }
        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
