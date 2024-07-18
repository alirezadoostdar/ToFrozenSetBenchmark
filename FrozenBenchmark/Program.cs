

using BenchmarkDotNet.Running;
using FrozenSetBenchmark;
using System.Collections.Frozen;
using System.Collections.Immutable;

//int capacity = 100_000;
//List<int> list = [];
//for (int i = 0; i < capacity; i++)
//    list.Add(i);
//list.Contains(15212);
//var imutable_1 = list.ToImmutableList();

//imutable_1.Add(6556);

//var frozen = list.ToFrozenSet();
//frozen.Contains(6556);

BenchmarkRunner.Run<FrozenBenchmark>();
