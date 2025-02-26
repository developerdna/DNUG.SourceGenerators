using System.Text.RegularExpressions;

namespace Bcl.SourceGenerators;

public partial class RegexSourceGenerated
{
    [GeneratedRegex("abc|def", RegexOptions.IgnoreCase, "en-US")]
    private static partial Regex AbcOrDefGeneratedRegex();
}