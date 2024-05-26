namespace agora.domain;

public class Article : IValidatedEntity
{
    public int Id { get; }
    
    public List<Category> Categories { get; private set; } = [];

    public string Title { get; private set; }

    public string Body { get; private set; }

    public Article(int id, string title, string body)
    {
        Id = id;
        Title = title;
        Body = body;

        ThrowsIfInvalidData();
    }

    public void ThrowsIfInvalidData()
    {
        if(Id < 0 || Id == default(int))
            throw new Exception(ExceptionMessages.InvalidProperty(nameof(Id), Id.ToString()));

        if(string.IsNullOrEmpty(Title) || string.IsNullOrWhiteSpace(Title))
            throw new Exception(ExceptionMessages.InvalidPropertyNullEmpty(nameof(Title)));
        
        if(string.IsNullOrEmpty(Body) || string.IsNullOrWhiteSpace(Body))
            throw new Exception(ExceptionMessages.InvalidPropertyNullEmpty(nameof(Body)));
    }
}
