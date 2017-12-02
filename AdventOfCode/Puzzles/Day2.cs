using System.Linq;

namespace AdventOfCode.Puzzles
{
    public class Day2
    {
        public static int PuzzleOne(string input)
        {
            var result = 0;
            foreach (var line in input.Split('\r', '\n').Where(n => n != ""))
            {
                var numbers = line.Split(' ', '\t').Where(n => n != "").Select(int.Parse).OrderByDescending(n => n);
                result = result + (numbers.First() - numbers.Last());
            }

            return result;
        }

        public static int PuzzleTwo(string input)
        {
            var result = 0;
            foreach (var line in input.Split('\r', '\n').Where(n => n != ""))
            {
                var numbers = line.Split(' ', '\t').Where(n => n != "").Select(int.Parse).OrderByDescending(n => n).ToArray();
                bool isFound = false;
                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int u = 0; u < numbers.Length; u++)
                    {
                        if (numbers[i] % numbers[u] == 0 && i != u)
                        {
                            result = result + (numbers[i] / numbers[u]);
                            isFound = true;
                            break;
                        }
                    }
                    if (isFound)
                    {
                        break;
                    }
                }
            }

            return result;
        }
    }
}
