using System.Collections.Generic;

namespace Algorithms.Sorters.Comparison
{
    /// <summary>
    ///     Class that implements insertion sort algorithm.
    /// </summary>
    /// <typeparam name="T">Type of array element.</typeparam>
    public class InsertionSorter<T> : IComparisonSorter<T>
    {
        /// <summary>
        ///     Sorts array using specified comparer,
        ///     internal, in-place, stable,
        ///     time complexity: O(n^2),
        ///     space complexity: O(1),
        ///     where n - array length.
        /// </summary>
        /// <param name="array">Array to sort.</param>
        /// <param name="comparer">Compares elements.</param>
        public void Sort(T[] array, IComparer<T> comparer)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var imin = i + 1;
                for (var j = i + 1; j < array.Length - 1; j++)
                {
                    if (comparer.Compare(array[j], array[imin]) <= 0)
                    {
                        imin = j + 1;
                    }
                }

                var t = array[imin];
                array[imin] = array[i];
                array[i] = t;
            }
        }
    }
}
