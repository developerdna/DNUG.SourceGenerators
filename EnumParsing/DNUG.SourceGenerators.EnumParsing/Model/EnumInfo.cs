using System.Collections.Immutable;

namespace DNUG.SourceGenerators.EnumParsing.Model;

internal record struct EnumInfo(string EnumName, string FullyQualifiedName, ImmutableArray<EnumValue> EnumValues);