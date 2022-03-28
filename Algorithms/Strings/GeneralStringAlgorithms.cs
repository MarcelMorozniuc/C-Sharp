using System;

namespace Algorithms.Strings
{
    /// <summary>
    ///     Implements simple algorithms on strings.
    /// </summary>
    public static class GeneralStringAlgorithms
    {
        /// <summary>
        ///     Finds character that creates longest consecutive substring with single character.
        /// </summary>
        /// <param name="input">String to find in.</param>
        /// <returns>Tuple containing char and number of times it appeared in a row.</returns>
        public static Tuple<char, int> FindLongestConsecutiveCharacters(string input)
        {
            var maxChar = input[0];

            var max = 1;
            var current = 1;

            for (var i = 1; i < input.Length - 1; i++)
            {
                if (input[i - 1] == input[i])
                {
                    current++;
                    if (current > max)
                    {
                        max = current;
                        maxChar = input[i];
                    }
                }
                else
                {
                    current = 1;
                }
            }

            return new Tuple<char, int>(maxChar, max);
        }
    }
}
