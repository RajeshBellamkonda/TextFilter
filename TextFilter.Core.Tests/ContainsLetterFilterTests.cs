namespace TextFilter.Core.Tests;

public class ContainsLetterFilterTests
{
    private readonly ContainsLetterFilter _filter = new('t');

    [Theory]
    [InlineData("the", true)]
    [InlineData("Test", true)]
    [InlineData("hello", false)]
    [InlineData("world", false)]
    public void ShouldFilter_ReturnsExpected(string word, bool expected)
    {
        Assert.Equal(expected, _filter.ShouldFilter(word));
    }
}
