using TCSA.V2.Helpers;

namespace TCSA.V2.UnitTests;

public class GalleryHelperTests
{
    [Fact]
    public void CorrectUrlReturnsValidString()
    {
        var input = "https://www.youtube.com/watch?v=JJN5iZcUYtQ";
        var expectedResult = "https://www.youtube.com/embed/JJN5iZcUYtQ";
        var result = GalleryHelpers.GalleryVideoUrlFormatter(input);

        Assert.Equal(result, expectedResult);
    }

    [Theory]
    [InlineData("https://www.youtube.com/watch?v=JJN5iZcUYtQ", true)]
    [InlineData("https://www.youtube.com/watch?v=invalid", false)]
    [InlineData("https://www.invalid.com/watch?v=JJN5iZcUYtQ", false)]
    [InlineData("", false)]
    [InlineData(null, false)]
    public void YouTubeUrlValidatorReturnsCorrectResult(string url, bool expected)
    {
        var result = GalleryHelpers.YouTubeUrlValidator(url);
        Assert.Equal(expected, result);
    }
}
