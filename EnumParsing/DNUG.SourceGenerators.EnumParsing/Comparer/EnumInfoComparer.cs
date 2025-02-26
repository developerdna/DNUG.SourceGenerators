using System.Collections.Generic;
using System.Linq;
using DNUG.SourceGenerators.EnumParsing.Model;

namespace DNUG.SourceGenerators.EnumParsing.Comparer;

internal class EnumInfoComparer : IEqualityComparer<EnumInfo>
{
    private EnumInfoComparer()
    {
    }

    internal static EnumInfoComparer Instance { get; } = new();

    public bool Equals(EnumInfo x, EnumInfo y)
    {
        return x.EnumName == y.EnumName && x.FullyQualifiedName == y.FullyQualifiedName &&
               x.EnumValues.SequenceEqual(y.EnumValues);
    }

    public int GetHashCode(EnumInfo obj)
    {
        unchecked
        {
            var hashCode = obj.EnumName.GetHashCode();
            hashCode = (hashCode * 397) ^ obj.FullyQualifiedName.GetHashCode();
            hashCode = (hashCode * 397) ^ obj.EnumValues.GetHashCode();
            return hashCode;
        }
    }
}