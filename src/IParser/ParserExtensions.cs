using System.Diagnostics.CodeAnalysis;

namespace IParser;

public static class ParserExtensions
{
    public static bool TryParse<TIn, TOut>(this IParser<TIn, TOut> self, TIn input,
        [MaybeNullWhen(false)] out TOut output)
    {
        try
        {
            output = self.Parse(input);
            return true;
        }
        catch
        {
            output = default;
            return false;
        }
    }
}