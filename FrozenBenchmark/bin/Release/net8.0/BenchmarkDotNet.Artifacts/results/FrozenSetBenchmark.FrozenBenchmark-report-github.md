```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4651/22H2/2022Update)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.101
  [Host]     : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2


```
| Method                 | Mean         | Error     | StdDev    | Median       | Ratio  | RatioSD | Gen0    | Allocated | Alloc Ratio |
|----------------------- |-------------:|----------:|----------:|-------------:|-------:|--------:|--------:|----------:|------------:|
| CreateFrozenList       |  24,950.8 ns | 415.23 ns | 682.24 ns |  24,744.7 ns |  60.59 |    5.00 | 14.1602 |  43.59 KB |       11.00 |
| CreateList             |     412.4 ns |   9.95 ns |  29.18 ns |     400.3 ns |   1.00 |    0.00 |  1.2918 |   3.96 KB |        1.00 |
| CreateHashSet          |   9,860.3 ns | 175.85 ns | 330.30 ns |   9,736.1 ns |  23.76 |    2.12 |  5.6458 |  17.38 KB |        4.39 |
| CreateImmutableHashSet | 137,298.8 ns | 987.41 ns | 824.53 ns | 136,991.3 ns | 347.28 |   17.48 | 17.8223 |  54.77 KB |       13.83 |
