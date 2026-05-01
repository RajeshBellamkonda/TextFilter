namespace TextFilter.Core;

/// <summary>
/// Applies a collection of word filters to text, removing words that match any filter.
/// </summary>
public class TextFilterProcessor
{
    private readonly IReadOnlyList<IWordFilter> _filters;

    public TextFilterProcessor(IEnumerable<IWordFilter> filters)
    {
        ArgumentNullException.ThrowIfNull(filters);
        _filters = filters.ToList();
    }

    /// <summary>
    /// Filters the input text by removing words that match any of the configured filters.
    /// </summary>
    /// <summary>
    /// Filters the input text by removing words that match any of the configured filters.
    /// </summary>
    public string Apply(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return string.Empty;

        var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // assuming punctuation should be removed before filtering, we clean the words first
        var cleaned = words.Select(RemovePunctuation).Where(w => w.Length > 0);
        var filtered = cleaned.Where(word => !_filters.Any(f => f.ShouldFilter(word)));
        return string.Join(' ', filtered);
    }

    /// <summary>
    /// Removes all punctuation characters from a word.
    /// </summary>
    private static string RemovePunctuation(string word)
    {
        return new string(word.Where(c => !char.IsPunctuation(c)).ToArray());
    }
}
