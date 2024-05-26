using agora.article.domain;
using agora.domain;

namespace agora.article.infra;

public class ArticleRepository : IArticleRepository
{
  public Article CreateArticle(Article article)
  {
    throw new NotImplementedException();
  }

  public void DeleteArticle(int id)
  {
    throw new NotImplementedException();
  }

  public Article GetArticle(int id)
  {
    return new Article(id, "Some title", "Body");
  }

  public List<Article> GetArticles()
  {
    var articles = new List<Article>
    {
      new Article(12, "Teste", "Body"),
      new Article(321, "SLA", "n sei")
    };

    return articles;
  }

  public Article UpdateArticle()
  {
    throw new NotImplementedException();
  }
}
