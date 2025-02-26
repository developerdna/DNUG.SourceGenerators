using System.Collections.Immutable;
using Microsoft.CodeAnalysis;

namespace DNUG.SourceGenerators.EnumParsing.Model;

internal record struct EnumParseSyntaxTreeInfo(
    INamedTypeSymbol TargetSymbol,
    ImmutableArray<AttributeData> Attributes);