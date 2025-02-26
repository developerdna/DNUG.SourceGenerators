using BenchmarkDotNet.Running;
using Benchmarks;

_ = BenchmarkRunner.Run<LoggerBenchmark>();