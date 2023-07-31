```

BenchmarkDotNet v0.13.6, Windows 10 (10.0.19045.3086/22H2/2022Update)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.302
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
|                           Method |       Mean |     Error |    StdDev |    Median |
|--------------------------------- |-----------:|----------:|----------:|----------:|
|      UsingASwitchExistingElement |  0.6933 ns | 0.0124 ns | 0.0110 ns | 0.6940 ns |
|    UsingASwitchNoExistingElement |  0.7550 ns | 0.0560 ns | 0.0524 ns | 0.7513 ns |
|   UsingANewSwitchExistingElement |  2.4072 ns | 0.0933 ns | 0.1610 ns | 2.3958 ns |
| UsingANewSwitchNoExistingElement |  1.9737 ns | 0.0852 ns | 0.2089 ns | 1.9361 ns |
|   UsingDictionaryExistingElement |  9.7720 ns | 0.2391 ns | 0.2456 ns | 9.8356 ns |
| UsingDictionaryNoExistingElement | 11.0380 ns | 1.1314 ns | 3.3361 ns | 9.6394 ns |
