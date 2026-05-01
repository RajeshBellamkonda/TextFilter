namespace TextFilter.Core.Tests;

public class MiddleVowelFilterTests
{
    private readonly MiddleVowelFilter _filter = new();

    [Theory]
    [InlineData("clean", true)]    // middle is 'e' (vowel)
    [InlineData("what", true)]     // middle is 'ha' - contains 'a' (vowel)
    [InlineData("currently", true)] // middle is 'e' (vowel)
    [InlineData("the", false)]     // middle is 'h' (no vowel)
    [InlineData("rather", false)]  // middle is 'th' (no vowel)
    [InlineData("me", true)]       // 2-char word, middle is "me" - contains 'e' (vowel)
    [InlineData("bank", true)]     // middle is "an" - contains 'a' (vowel)
    public void ShouldFilter_ReturnsExpected(string word, bool expected)
    {
        Assert.Equal(expected, _filter.ShouldFilter(word));
    }

    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    public void ShouldFilter_EmptyOrWhitespace_ReturnsFalse(string word)
    {
        Assert.False(_filter.ShouldFilter(word));
    }
}
