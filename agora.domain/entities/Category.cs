using agora.domain;

namespace agora.article.domain.entities;

public class Category : IValidatedEntity
{
    public string Id { get; }
    public string Name { get; private set; }

    public void ThrowsIfInvalidData(bool creatingEntity = false)
    {
        if(string.IsNullOrEmpty(Name) || string.IsNullOrWhiteSpace(Name))
            throw new Exception(ExceptionMessages.InvalidPropertyNullEmpty(nameof(Name)));
    }

  public Category(string name) => Name = name;
}
