﻿using BenchmarkDotNet.Running;
using LeetSharp.Benchmarks.Console.Benchmarks;

// Select the benchmark to run within the <>.
var summary = BenchmarkRunner.Run<Problem0001TwoSum>();
