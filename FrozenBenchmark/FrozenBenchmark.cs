using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrozenSetBenchmark
{

    [MemoryDiagnoser]
    public class FrozenBenchmark
    {
        private const int Iterations = 1000;
        private readonly List<int> list = Enumerable.Range(0, Iterations).ToList();
        private readonly HashSet<int> hashSet = Enumerable.Range(0, Iterations).ToHashSet();
        private readonly ImmutableHashSet<int> immutableHashSet = Enumerable.Range(0, Iterations).ToImmutableHashSet();
        private readonly FrozenSet<int> frozenSet = Enumerable.Range(0, Iterations).ToFrozenSet();

        [Benchmark]
        public void LookupFrozen()
        {
            for (int i = 0; i < Iterations; i++)
                _ = frozenSet.Contains(i);
        }

        [Benchmark(Baseline = true)]
        public void LookupList()
        {
            for (int i = 0; i < Iterations; i++)
                _ = list.Contains(i);
        }

        [Benchmark]
        public void LookupHashSet()
        {
            for (int i = 0; i < Iterations; i++)
                _ = hashSet.Contains(i);
        }

        [Benchmark]
        public void LookupImmutableHashSet()
        {
            for (int i = 0; i < Iterations; i++)
                _ = immutableHashSet.Contains(i);
        }
    }
}
