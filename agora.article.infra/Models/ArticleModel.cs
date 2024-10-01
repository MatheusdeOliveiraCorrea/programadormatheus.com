using agora.article.infra.EmbeddedDocuments;
using MongoDB.Bson;

namespace agora.article.infra.Models
{
  public partial class ArticleModel
  {
    public ObjectId _id { get; set; }
    public string title { get; set; }
    public string body { get; set; }
    public string author_id { get; set; }

    public IList<CommentModel> comments { get; set; } = [];
    public IList<CategoryModel> categories { get; set; } = [];
  }
}
