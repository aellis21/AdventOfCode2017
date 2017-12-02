using System;

namespace AdventOfCode.Puzzles
{
    public class Day1
    {
        public static int PuzzleOne(char[] input)
        {
            var output = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == input[(i+1) % input.Length])
                {
                    output += Int32.Parse(input[i].ToString());
                }
            }
            return output;
        }

        public static int PuzzleTwo(char[] input)
        {
            var output = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == input[(i + input.Length / 2) % input.Length])
                {
                    output += Int32.Parse(input[i].ToString());
                }
            }
            return output;
        }
    }
}
