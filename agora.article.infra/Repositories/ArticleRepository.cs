using agora.article.domain;
using agora.article.infra.Helpers;
using agora.article.infra.MongoDbContexts;
using agora.domain;

namespace agora.article.infra;

public class ArticleRepository : IArticleRepository
{
  ArticleDBContext _dbContext;

  public ArticleRepository(ArticleDBContext context)
  {
    _dbContext = context;
  }

  public Article CreateArticle(Article article)
  {
    _dbContext.Articles.Add(article.ToModel());

    _dbContext.SaveChanges();

    return article;
  }

  public void DeleteArticle(int id)
  {
    throw new NotImplementedException();
  }

  public Article GetArticle(string id)
  {
    throw new NotImplementedException();
  }

  public IEnumerable<Article> GetArticles()
  {
    var articles = _dbContext.Articles.ToArray();

    return articles.Select(article => article.ToEntity());
  }

  public Article UpdateArticle()
  {
    throw new NotImplementedException();
  }
}
