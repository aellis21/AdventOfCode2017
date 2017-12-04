using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Puzzles
{
    public class Day3
    {
        public static int PuzzleOne(int input)
        {
            var result = 0;

            var spiral = CreateSpiral(input);



            return result;
        }

        public static int PuzzleTwo(string input)
        {
            var result = 0;

            return result;
        }

        private static int[,] CreateSpiral(int number)
        {
            var position = new { x = -1, y = 0 };
            var directions = new[] {
                new { x = 1, y = 0 },
                new { x = 0, y = 1 },
                new { x = -1, y = 0 },
                new { x = 0, y = -1 }
            };

            var sequence = (
                from n in Enumerable.Range(1, number)
                from o in Enumerable.Repeat(n, n != number ? 2 : 1)
                select o
            ).Reverse().ToList();

            var result = new int[number, number];

            for (int i = 0, current = 1; i < sequence.Count; i++)
            {
                var direction = directions[i % directions.Length];

                for (int j = 0; j < sequence[i]; j++, current++)
                {
                    position = new
                    {
                        x = position.x + direction.x,
                        y = position.y + direction.y
                    };

                    result[position.y, position.x] = current;
                }
            }

            return result;
        }
    }
}
