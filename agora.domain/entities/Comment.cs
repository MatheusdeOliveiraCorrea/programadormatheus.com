namespace agora.article.domain.entities
{
  public class Comment
  {
    public int Id { get; private set; }
    public string Body { get; private set; }

    public Comment(string body)
    {
      Body = body;
    }
  }
}
