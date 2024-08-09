using MongoDB.Bson;

namespace agora.article.infra.EmbeddedDocuments
{
  public partial class CategoryModel
  {
    public ObjectId _id { get; set; }

    public string name { get; set; }
  }
}
