namespace agora.domain.tests;

public class ArticleTest
{
    [Theory(DisplayName = nameof(InstantiateThrowsExceptionWhenTitleIsNullOrEmpty))]
    [InlineData("")]
    [InlineData("     ")]
    [InlineData(null)]
    public void InstantiateThrowsExceptionWhenTitleIsNullOrEmpty(string invalidTitle)
    {
        Action instantiateThrowsExceptionWhenTitleIsNullOrEmpty = () => 
        {
            var article = new Article(1, invalidTitle, "john lennon");
        };

        var exception = Assert.Throws<Exception>(instantiateThrowsExceptionWhenTitleIsNullOrEmpty);

        Assert.Equal(ExceptionMessages.InvalidPropertyNullEmpty("Title"), exception.Message);
    }

    [Theory(DisplayName = nameof(InstantiateThrowsExceptionWhenBodyIsNullOrEmpty))]
    [InlineData("")]
    [InlineData("     ")]
    [InlineData(null)]
    public void InstantiateThrowsExceptionWhenBodyIsNullOrEmpty(string invalidBody)
    {
        Action instantiateThrowsExceptionWhenBodyIsNullOrEmpty = () => 
        {
            var article = new Article(1, "Some title", invalidBody);
        };

        var exception = Assert.Throws<Exception>(instantiateThrowsExceptionWhenBodyIsNullOrEmpty);

        Assert.Equal(ExceptionMessages.InvalidPropertyNullEmpty("Body"), exception.Message);
    }

    [Theory(DisplayName = nameof(InstantiateThrowsExceptionWhenIdIsNullOrEmpty))]
    [InlineData(default(int))]
    [InlineData(-210)]
    public void InstantiateThrowsExceptionWhenIdIsNullOrEmpty(int invalidId)
    {
        Action instantiateThrowsExceptionWhenIdIsInvalid = () => 
        {
            var article = new Article(invalidId, "Some title", "Some body");
        };

        var exception = Assert.Throws<Exception>(instantiateThrowsExceptionWhenIdIsInvalid);

        Assert.Equal(ExceptionMessages.InvalidProperty("Id", invalidId.ToString()), exception.Message);
    }
}
