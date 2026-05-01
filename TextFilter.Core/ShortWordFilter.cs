namespace TextFilter.Core;

/// <summary>
/// Filters out words that have a length less than 3.
/// </summary>
public class ShortWordFilter : IWordFilter
{
    private readonly int _length;
    public ShortWordFilter(int length = 3)
    {
        _length = length;
    }

    public bool ShouldFilter(string word) => word.Length < _length;
}