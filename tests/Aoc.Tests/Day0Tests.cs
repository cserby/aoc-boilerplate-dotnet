namespace Aoc.Tests;

public class Day0Tests
{
    private static readonly string Example = Input.Read("day0.example.txt");

    [Fact]
    public void Part1Example() => Assert.Equal(10, Day0.Part1(Example));

    [Fact]
    public void Part2Example() => Assert.Equal(24, Day0.Part2(Example));
}
