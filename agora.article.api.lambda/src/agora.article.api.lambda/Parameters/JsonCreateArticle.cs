using MongoDB.Bson;

namespace agora.article.api.lambda.Parameters
{
  public class JsonCreateArticle
  {
    public string title { get; set; }
    public string body { get; set; }
    public ObjectId author_id { get; set; }

    public List<JsonCreateComment> comments { get; set; }
    public List<JsonCreateCategory> categories { get; set; }
  }
}
