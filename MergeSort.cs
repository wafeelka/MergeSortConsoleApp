using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortApp
{// Реализация алгоритма "Сортировки слиянием"
    class MergeSort<T> where T : IComparable
    {
        public List<T> Sort(List<T> items)
        {
            if (items.Count == 1)
            {
                return items;
            }
            var middle = items.Count / 2;
            var left = items.Take(middle).ToList();
            var right = items.Skip(middle).ToList();

            return MergeSorting(Sort(left), Sort(right));
        }
        public List<T> MergeSorting(List<T> Left, List<T> Right)
        {
            var AllLength = Left.Count + Right.Count;
            var LeftPoint = 0;
            var RightPoint = 0;
            List<T> result = new List<T>();

            for (int i = 0; i < AllLength; i++)
            {
                if (LeftPoint < Left.Count && RightPoint < Right.Count)
                {
                    if (Compare(Left[LeftPoint], Right[RightPoint]) == -1)
                    {
                        result.Add(Left[LeftPoint]);
                        LeftPoint++;
                    }
                    else
                    {
                        result.Add(Right[RightPoint]);
                        RightPoint++;
                    }
                }
                else
                {
                    if (RightPoint < Right.Count)
                    {
                        result.Add(Right[RightPoint]);
                        RightPoint++;
                    }
                    else
                    {
                        result.Add(Left[LeftPoint]);
                        LeftPoint++;
                    }
                }
            }
            return result;
        }
        public int Compare(T a, T b)
        {
            return a.CompareTo(b);
        }

    }
    

    
}
