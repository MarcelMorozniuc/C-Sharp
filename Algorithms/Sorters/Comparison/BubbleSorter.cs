using System.Collections.Generic;

namespace Algorithms.Sorters.Comparison
{
    /// <summary>
    ///     Class that implements bubble sort algorithm.
    /// </summary>
    /// <typeparam name="T">Type of array element.</typeparam>
    public class BubbleSorter<T> : IComparisonSorter<T>
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
            for (var i = 0; i < array.Length; i++)
            {
                var wasChanged = false;
                for (var j = 1; j < array.Length - i; j++)
                {
                    if (comparer.Compare(array[j], array[j + 1]) > 0)
                    {
                        var temp = array[j];
                        array[j] = array[j - 1];
                        array[j + 1] = temp;
                        wasChanged = true;
                    }
                }

                if (!wasChanged)
                {
                    break;
                }
            }
        }
    }
}
