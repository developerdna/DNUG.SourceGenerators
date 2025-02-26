using System.Collections.Generic;
using System.Linq;
using DNUG.SourceGenerators.EnumParsing.Model;

namespace DNUG.SourceGenerators.EnumParsing.Comparer;

internal class EnumParserTargetInfoComparer : IEqualityComparer<EnumParserTargetInfo>
{
    private EnumParserTargetInfoComparer()
    {
    }

    internal static EnumParserTargetInfoComparer Instance { get; } = new();

    public bool Equals(EnumParserTargetInfo x, EnumParserTargetInfo y)
    {
        return x.TargetNamespace == y.TargetNamespace && x.TargetClassName == y.TargetClassName &&
               x.Enums.SequenceEqual(y.Enums, EnumInfoComparer.Instance);
    }

    public int GetHashCode(EnumParserTargetInfo obj)
    {
        unchecked
        {
            var hashCode = obj.TargetNamespace != null ? obj.TargetNamespace.GetHashCode() : 0;
            hashCode = (hashCode * 397) ^ obj.TargetClassName.GetHashCode();
            hashCode = (hashCode * 397) ^ obj.Enums.GetHashCode();
            return hashCode;
        }
    }
}