using MongoDB.Bson;
using Realms;

namespace agora.article.infra.EmbeddedDocuments
{
  public partial class Comment : IRealmObject
  {
    public ObjectId _id { get; set; }
    public string body { get; set; }
    public ObjectId user_id { get; set; }
  }
}
