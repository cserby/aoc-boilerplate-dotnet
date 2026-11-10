namespace Aoc.Tests;

internal static class Input
{
    public static string Read(string name) =>
        File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "inputs", name)).Trim();
}
