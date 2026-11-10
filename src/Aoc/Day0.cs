namespace Aoc;

public static class Day0
{
    private static IEnumerable<int> Parse(string input) => input.Split('\n').Select(int.Parse);

    public static int Part1(string input) => Parse(input).Sum();

    public static int Part2(string input) => Parse(input).Aggregate(1, (acc, n) => acc * n);
}
