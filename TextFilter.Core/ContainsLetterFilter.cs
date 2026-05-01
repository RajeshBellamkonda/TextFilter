namespace TextFilter.Core;

/// <summary>
/// Filters out words that contain a specified letter (case-insensitive).
/// </summary>
public class ContainsLetterFilter : IWordFilter
{
    private readonly char _letter;

    public ContainsLetterFilter(char letter = 't')
    {
        _letter = char.ToLowerInvariant(letter);
    }

    public bool ShouldFilter(string word) =>
        word.Contains(_letter, StringComparison.OrdinalIgnoreCase);
}
