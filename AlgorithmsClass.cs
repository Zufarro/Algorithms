using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class AlgorithmsClass
    {
        public double[] SortedArray;

        public void CopyArray(double[] InputArray)
        {

            int n = InputArray.Length;
            SortedArray = new double[n];
            for (int i = 0; i < n; i++)
            {
                SortedArray[i] = InputArray[i];
            }
        }
        public void Selection_sort()
        {
            int len = SortedArray.Length;
            for (int i = 0; i < len - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < len; j++)                        //Поиск минимума
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
        }
        public void Insertion_sort()
        {
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
        }
        public void bubble_sort()
        {
            int len = SortedArray.Length;
            for (int j = 0; j < len - 1; j++)
            {
                bool F = false;
                for (int i = 0; i < len-j-1; i++)
                {
                    if (SortedArray[i] > SortedArray[i+1])
                    {
                        double temp = SortedArray[i];
                        SortedArray[i] = SortedArray[i + 1];
                        SortedArray[i + 1] = temp;
                        F = true;
                        
                    }
                    if (!F) {
                        break;
                    }
                }
            }
        }
        public void quicksort()
        {

        }
    }

}
