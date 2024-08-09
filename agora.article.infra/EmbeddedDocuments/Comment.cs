using MongoDB.Bson;

namespace agora.article.infra.EmbeddedDocuments
{
  public partial class CommentModel
  {
    public ObjectId _id { get; set; }
    public string body { get; set; }
    public ObjectId user_id { get; set; }
  }
}
