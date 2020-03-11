using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace Algorithms
{
    class AlgorithmsClass
    {
        public double[] SortedArray;
        Stopwatch stopwatch = new Stopwatch();
        public double Time;
        bool StartTimer = true;

        public void CopyArray(double[] InputArray)
        {
            int n = InputArray.Length;
            SortedArray = new double[n];
            for (int i = 0; i < n; i++)
            {
                SortedArray[i] = InputArray[i];
            }
        }
        public void Selection_sort()                                       //Сортирвка выбором
        {
            stopwatch.Start();
            int len = SortedArray.Length;
            for (int i = 0; i < len - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < len; j++)                          //Поиск минимума
                {
                    if (SortedArray[min] > SortedArray[j])
                    {
                        min = j;
                    }
                }
                double temp = SortedArray[i];
                SortedArray[i] = SortedArray[min];
                SortedArray[min] = temp;

            }
            stopwatch.Stop();
            Time = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Reset();
        }
        public void Insertion_sort()                                        //Сортировка вставками
        {
            stopwatch.Start();
            int len = SortedArray.Length;
            for (int j = 1; j < len; j++)
            {
                double temp = SortedArray[j];
                int i;

                for (i = j - 1; i >= 0 && SortedArray[i] > temp; i--)      //смотрим все что сзади temp
                {
                    SortedArray[i + 1] = SortedArray[i];
                }
                SortedArray[i + 1] = temp;
            }
            stopwatch.Stop();
            Time = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Reset();
        }
        public void bubble_sort()                                         //Сортировка перестановками
        {
            stopwatch.Start();
            int len = SortedArray.Length;
            for (int j = 0; j < len - 1; j++)
            {
                bool F = false;
                for (int i = 0; i < len - j - 1; i++)
                {
                    if (SortedArray[i] > SortedArray[i + 1])
                    {
                        double temp = SortedArray[i];
                        SortedArray[i] = SortedArray[i + 1];
                        SortedArray[i + 1] = temp;
                        F = true;

                    }

                }
                if (!F)
                {
                    break;
                }
            }
            stopwatch.Stop();
            Time = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Reset();
        }
        private int partition(int start, int end)                       //Определяет позиции опорного элемента
        {
            double temp;
            int marker = start;                                         //граничный элемент правой и левой части массива
            for (int i = start; i < end; i++)
            {
                if (SortedArray[i] < SortedArray[end])                  //array[end] - опорный элемент
                {
                    temp = SortedArray[marker];                         // swap
                    SortedArray[marker] = SortedArray[i];
                    SortedArray[i] = temp;
                    marker++;
                }
            }
                                                                        //опорный элемент (array[end]) разместить между правой и левой частями массива
            temp = SortedArray[marker];
            SortedArray[marker] = SortedArray[end];
            SortedArray[end] = temp;
            return marker;
        }

        
        public void quicksort(int start, int end)                       //Сортировка быстрая
        {
            if (StartTimer)
            {
                stopwatch.Start();
                StartTimer = false;
            }

            if (start >= end)
            {
                if (stopwatch.Elapsed.TotalMilliseconds != 0)
                {
                    stopwatch.Stop();
                    Time = stopwatch.Elapsed.TotalMilliseconds;
                    stopwatch.Reset();
                }

                return;
            }
            int pivot = partition(start, end);                       //Индекс опорного элемента в отсортированном массиве
            quicksort(start, pivot - 1);                             //Сортируюм левую часть
            quicksort(pivot + 1, end);                               //Сортируюм правую часть

        }
    }

}
