using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.Logging;

namespace Benchmarks;

public class LoggerBenchmark
{
    private ILogger _logger;

    [GlobalSetup]
    public void Setup()
    {
        using var factory = LoggerFactory.Create(builder =>
        {
            builder.SetMinimumLevel(LogLevel.Information);
            builder.AddConsole();
        });
        _logger = factory.CreateLogger("LoggerBenchmark");
    }
    
    [Benchmark(Baseline = true)]
    public void Default()
    {
        _logger.LogDebug("Logging without testing the minimum level: {MinimumLevel}", LogLevel.Debug);
    }
    
    [Benchmark]
    public void WithLogLevelTest()
    {
        if (_logger.IsEnabled(LogLevel.Debug))
        {
            _logger.LogDebug("Logging without testing the minimum level: {MinimumLevel}", LogLevel.Debug);
        }
    }
}