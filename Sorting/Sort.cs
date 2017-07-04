using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    static class Sort
    {
        public static void BubbleSort(int[] list)
        {
            bool isSorted = false;
            for (int i = 0; i < list.Length && !isSorted; i++)
            {
                isSorted = true;
                for (int j = 0; j < list.Length - 1; j++)
                {
                    if(list[j].CompareTo(list[j+1]) > 0)
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                        isSorted = false;
                    }
                }
            }
        }

        public static void SelectionSort(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                int minI = i;
                for (int j = i + 1; j < list.Length; j++)
                {
                    if(list[minI].CompareTo(list[j]) > 0)
                    {
                        minI = j;
                    }
                }
                int temp = list[i];
                list[i] = list[minI];
                list[minI] = temp;
            }
        }

        public static void InsertionSort(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if(list[j].CompareTo(list[j - 1]) < 0)
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

        public static void ShellSort(int[] list)
        {
            int h = 1;
            while (h < list.Length / 3)
                h = h * 3 + 1;

            while(h >= 1)
            {
                for (int i = h; i < list.Length; i++)
                {
                    for (int j = i; j >= h; j = j - h)
                    {
                        if (list[j].CompareTo(list[j - h]) < 0)
                        {
                            int temp = list[j];
                            list[j] = list[j - h];
                            list[j - h] = temp;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                h = h / 3;
            }
        }
    }
}
