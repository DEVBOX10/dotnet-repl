﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace dotnet_repl
{
    public class SillyExecutionStatusMessageGenerator
    {
        private readonly Random _random = new();

        private readonly string[] _verbs =
        {
            "🤞",
            "🦾",
            "🧠",
            "😎",
            "😱",
            "🙌",
            "🙌🏾",
            "Analyzing",
            "Booting",
            "Calculating",
            "Collating",
            "Compiling",
            "Computing",
            "Concatenating",
            "Distributing",
            "Executing",
            "Hashing",
            "Invoking",
            "Iterating",
            "Optimizing",
            "Parallelizing",
            "Parsing",
            "Recursing",
            "Running",
            "Sorting",
            "Tabulating",
            "Type-checking",
            "Verifying",
            "Warming up",
        };

        private readonly string[] _conjunctions =
        {
            "all kinds of",
            "all the",
            "an incredible amount of",
            "hard drives full of",
            "lots of",
            "much",
            "piles of",
            "several",
            "so many",
            "so much",
            "the",
            "those",
        };

        private readonly string[] _nouns =
        {
            "💻",
            "📊",
            "🤖",
            "abstractions",
            "algorithms",
            "arrays",
            "binary trees",
            "bits",
            "bytes",
            "classes",
            "closures",
            "codes",
            "computations",
            "computer science",
            "conditionals",
            "coroutines",
            "cryptography",
            "cyclomatic complexity",
            "data science",
            "data structures",
            "data transformations",
            "data",
            "expressions",
            "functions",
            "genius",
            "handles",
            "hash tables",
            "I/O",
            "implementation details",
            "integers",
            "internets",
            "invariants",
            "linked lists",
            "logic",
            "loops",
            "machine learning",
            "modules",
            "monads",
            "networks",
            "nodes",
            "objects",
            "OOP",
            "parameters",
            "pointers",
            "postconditions",
            "preconditions",
            "pure functions",
            "quantum computing",
            "recursion",
            "references",
            "serialization",
            "side effects",
            "smart stuff",
            "software",
            "source code",
            "source files",
            "stacks",
            "storage",
            "subroutines",
            "symbols",
            "syntax trees",
            "things",
            "types",
            "variables",
        };

        public string GetStatusMessage() =>
            $"{_verbs[_random.Next(_verbs.Length)]} {_conjunctions[_random.Next(_conjunctions.Length)]} {_nouns[_random.Next(_nouns.Length)]}...";
    }
}