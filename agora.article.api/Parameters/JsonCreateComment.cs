using MongoDB.Bson;

namespace agora.article.api.Parameters
{
  public class JsonCreateComment
  {
    public string body { get; set; }
    public ObjectId user_id { get; set; }
  }
}
