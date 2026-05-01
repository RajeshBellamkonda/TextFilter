namespace TextFilter.Core.Tests;

public class ShortWordFilterTests
{
    private readonly ShortWordFilter _filter = new();

    [Theory]
    [InlineData("hi", true)]
    [InlineData("a", true)]
    [InlineData("", true)]
    [InlineData("the", false)]
    [InlineData("word", false)]
    public void ShouldFilter_ReturnsExpected(string word, bool expected)
    {
        Assert.Equal(expected, _filter.ShouldFilter(word));
    }
}
