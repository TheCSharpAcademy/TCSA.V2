using TCSA.V2.Helpers;

namespace TCSA.V2.UnitTests;

public class BlogHelperTests
{
    [Fact]
    public void Convert_ValidContentString_ReturnsExpectedBlocks()
    {
        var content = @"
        [
            {
                'Title': 'Block 1 Title',
                'Paragraphs': [
                    { 'Body': 'Paragraph 1 in Block 1' },
                    { 'Body': 'Paragraph 2 in Block 1' }
                ]
            },
            {
                'Title': 'Block 2 Title',
                'Paragraphs': [
                    { 'Body': 'Paragraph 1 in Block 2' }
                ]
            }
        ]";

        // Act
        var result = BlogHelper.Convert(content);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(2, result.Count);

        //// Assert Block 1
        Assert.Equal("Block 1 Title", result[0].Title);
        Assert.Equal(2, result[0].Paragraphs.Count);
        Assert.Equal("Paragraph 1 in Block 1", result[0].Paragraphs[0].Body);
        Assert.Equal("Paragraph 2 in Block 1", result[0].Paragraphs[1].Body);

        //// Assert Block 2
        Assert.Equal("Block 2 Title", result[1].Title);
        Assert.Single(result[1].Paragraphs);
        Assert.Equal("Paragraph 1 in Block 2", result[1].Paragraphs[0].Body);
    }
}
