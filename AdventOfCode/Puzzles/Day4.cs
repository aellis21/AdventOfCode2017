using System.Linq;
using System;
using System.Collections.Generic;

namespace AdventOfCode.Puzzles
{
    public class Day4
    {
        public static int PuzzleOne(string input)
        {
            var result = 0;
            var lines = input.Split('\n', '\r').Distinct().Where(w => w != string.Empty).ToList();

            foreach (var line in lines)
            {
                var words = line.Split(' ');
                result = words.Distinct().Count() == words.Count() ? result + 1 : result;
            }

            return result;
        }

        public static int PuzzleTwo(string input)
        {
            var result = 0;
            var lines = input.Split('\n', '\r').Distinct().Where(w => w != string.Empty).ToList();

            foreach (var line in lines)
            {
                var words = line.Split(' ').ToList();

                words = words.Select(w => OrderString(w)).ToList();

                result = words.Distinct().Count() == words.Count() ? result + 1 : result;
            }

            return result;
        }

        private static string OrderString(string word)
        {
            var charArray = word.ToCharArray();
            var result = charArray.OrderByDescending(l => l).ToArray();
            return new string(result);
        }
    }
}
