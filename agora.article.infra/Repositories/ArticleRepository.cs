using agora.article.domain;
using agora.article.infra.EmbeddedDocuments;
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
    var articleModel = new Models.ArticleModel
    {
      title = article.Title,
      body = article.Body,
    };

    //article.Comments.Select(x => new Comment { body = x.Body }).ToList().ForEach(articleModel.comments.Add);
    //article.Categories.Select(x => new Category { name = x.Name }).ToList().ForEach(articleModel.categories.Add);

    _dbContext.Articles.Add(articleModel);

    _dbContext.SaveChanges();

    return article;
  }

  public void DeleteArticle(int id)
  {
    throw new NotImplementedException();
  }

  public Article GetArticle(string id)
  {
    return new Article(id, "Some title", "Body");
  }

  public List<Article> GetArticles()
  {
    return _dbContext.Articles
                     .Select(x =>
                      new Article(x._id.ToString()
                                , x.title
                                , x.body))
                     .ToList();
  }

  public Article UpdateArticle()
  {
    throw new NotImplementedException();
  }
}
