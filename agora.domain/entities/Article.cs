using agora.article.domain.entities;

namespace agora.domain;

public class Article : IValidatedEntity
{
  public string Id { get; }

  public string Title { get; private set; }

  public string Body { get; private set; }

  public int AuthorID { get; private set; }

  public IEnumerable<Category> Categories { get; private set; } = [];

  public IEnumerable<Comment> Comments { get; private set; } = [];

  public Article(string id, string title, string body)
  {
    Id = id;
    Title = title;
    Body = body;

    ThrowsIfInvalidData();
  }

  public Article(string title, string body)
  {
    Title = title;
    Body = body;

    ThrowsIfInvalidData(creatingEntity: true);
  }

  public void ThrowsIfInvalidData(bool creatingEntity = false)
  {
    if(string.IsNullOrEmpty(Id) && !creatingEntity)
        throw new Exception(ExceptionMessages.InvalidPropertyNullEmpty(nameof(Id)));

    if(string.IsNullOrEmpty(Title) || string.IsNullOrWhiteSpace(Title))
        throw new Exception(ExceptionMessages.InvalidPropertyNullEmpty(nameof(Title)));
    
    if(string.IsNullOrEmpty(Body) || string.IsNullOrWhiteSpace(Body))
        throw new Exception(ExceptionMessages.InvalidPropertyNullEmpty(nameof(Body)));
  }

  public void SetComments(IEnumerable<Comment> comments)
    => Comments = comments;

  public void SetCategories(IEnumerable<Category> categories)
    => Categories = categories;
}
