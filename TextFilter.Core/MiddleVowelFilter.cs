namespace TextFilter.Core;

/// <summary>
/// Filters out words that contain a vowel in the middle (centre 1 or 2 letters).
/// </summary>
public class MiddleVowelFilter : IWordFilter
{
    private static readonly HashSet<char> Vowels = ['a', 'e', 'i', 'o', 'u'];

    public bool ShouldFilter(string word)
    {
        if (string.IsNullOrWhiteSpace(word))
            return false;

        var middle = GetMiddleCharacters(word);
        foreach (var c in middle)
        {
            if (Vowels.Contains(char.ToLowerInvariant(c)))
                return true;
        }
        return false;
    }

    private static ReadOnlySpan<char> GetMiddleCharacters(string word)
    {
        int length = word.Length;

        if (length <= 2)
            return word.AsSpan();

        if (length % 2 == 1)
        {
            // Odd length: single middle character
            int midIndex = length / 2;
            return word.AsSpan(midIndex, 1);
        }
        else
        {
            // Even length: two middle characters
            int midIndex = (length / 2) - 1;
            return word.AsSpan(midIndex, 2);
        }
    }
}
