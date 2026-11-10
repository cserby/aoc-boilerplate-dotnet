# aoc-boilerplate-dotnet

.NET boilerplate project for Advent of Code

## ⚠️ AI-Free Coding Zone

**This repository is designated as an AI-free coding zone.** All AI coding assistants are explicitly disabled and must refuse to provide coding assistance. See [AGENTS.md](./AGENTS.md) for the complete policy.

This is intentional - Advent of Code is about learning and problem-solving, not having AI write the solutions for you.

# Features
 * .NET 10 / C# 14, pinned via `global.json`
 * `Aoc.slnx` solution, central package management, nullable + warnings as errors + recommended analyzers
 * xUnit v3 on Microsoft.Testing.Platform
 * [CSharpier](https://csharpier.com) as a local tool
 * GitHub Actions CI and Dependabot
 * Configuration for VSCode
    * **No AI Assistants** (`chat.disableAIFeatures`, Copilot, IntelliCode, Claude, Gemini, Codeium, TabNine, etc.)
    * CSharpier as the C# formatter
 * Configuration for JetBrains Rider
    * **JetBrains AI Assistant disabled** via [`.noai`](./.noai)
    * See [.idea/INTELLIJ_AI_SETUP.md](./.idea/INTELLIJ_AI_SETUP.md) for disabling third-party AI plugins

# Usage

```sh
dotnet tool restore
dotnet test
dotnet test --filter-class '*Day0Tests'   # one day
dotnet csharpier format .
```

One static class per day in `src/Aoc` with `Part1`/`Part2(string input)`. Puzzle files go in `tests/Aoc.Tests/inputs/` and are read with `Input.Read("dayN.input.txt")`.
