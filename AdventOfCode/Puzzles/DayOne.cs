using System;
using System.Linq;

namespace AdventOfCode.Puzzles
{
    public class DayOne
    {
        public int PuzzleOne(char[] input)
        {
            var output = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (i == input.Length - 1 && input.Last() == input.First())
                {
                    output += Int32.Parse(input[i].ToString());
                }
                else if (input[i] == input[i + 1])
                {
                    output += Int32.Parse(input[i].ToString());
                }
            }
            return output;
        }

        public int PuzzleTwo(char[] input)
        {
            var output = 0;
            for (int i = 0; i < input.Length; i++)
            {
                var u = i + input.Length / 2;
                if (u >= input.Length)
                {
                    u = u - input.Length;
                }
                if (i == input.Length - 1 && input.Last() == input[u])
                {
                    output += Int32.Parse(input[i].ToString());
                }
                else if (input[i] == input[u])
                {
                    output += Int32.Parse(input[i].ToString());
                }
            }
            return output;
        }
    }
}
