using agora.article.infra.EmbeddedDocuments;
using MongoDB.Bson;
using Realms;
using Realms.Schema;
using Realms.Weaving;
using System.Collections;

namespace agora.article.infra.Models
{
  public partial class ArticleModel : IRealmObject
  {
    public ObjectId _id { get; set; }
    public string title { get; set; }
    public string body { get; set; }
    public int author_id { get; set; }

    public IList<Comment> comments { get; }
    public IList<Category> categories { get; }
  }
}
