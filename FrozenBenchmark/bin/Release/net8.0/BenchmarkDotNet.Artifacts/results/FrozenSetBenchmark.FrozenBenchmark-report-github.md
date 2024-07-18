```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4651/22H2/2022Update)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.101
  [Host]     : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2


```
| Method                 | Mean      | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------------- |----------:|----------:|----------:|------:|--------:|----------:|------------:|
| LookupFrozen           |  2.608 μs | 0.0368 μs | 0.0345 μs |  0.04 |    0.00 |         - |          NA |
| LookupList             | 62.566 μs | 1.2418 μs | 1.7409 μs |  1.00 |    0.00 |         - |          NA |
| LookupHashSet          |  5.784 μs | 0.0789 μs | 0.0738 μs |  0.09 |    0.00 |         - |          NA |
| LookupImmutableHashSet | 39.017 μs | 0.7770 μs | 1.8467 μs |  0.61 |    0.02 |         - |          NA |
