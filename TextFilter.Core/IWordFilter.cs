namespace TextFilter.Core;

/// <summary>
/// Defines a filter that determines whether a word should be excluded.
/// </summary>
public interface IWordFilter
{
    /// <summary>
    /// Returns true if the word should be filtered out (excluded).
    /// </summary>
    bool ShouldFilter(string word);
}
