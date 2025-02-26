using Microsoft.Extensions.Logging;

namespace Bcl.SourceGenerators;

public partial class LoggingSourceGenerated
{
    [LoggerMessage(
        EventId = 0,
        Level = LogLevel.Critical,
        Message = "Could not open socket to `{HostName}`")]
    public static partial void CouldNotOpenSocket(ILogger logger, string hostName);
}