// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

using BenchmarkDotNet.Running;
using FrozenSetBenchmark;

BenchmarkRunner.Run<FrozenBenchmark>();
