using MongoDB.Bson;
using Realms;

namespace agora.article.infra.EmbeddedDocuments
{
  public partial class Category : IRealmObject
  {
    public ObjectId _id { get; set; }

    public string name { get; set; }
  }
}
