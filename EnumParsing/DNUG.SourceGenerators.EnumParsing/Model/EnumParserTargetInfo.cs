using System.Collections.Immutable;

namespace DNUG.SourceGenerators.EnumParsing.Model;

internal record struct EnumParserTargetInfo(
    string? TargetNamespace,
    string TargetClassName,
    ImmutableArray<EnumInfo> Enums);