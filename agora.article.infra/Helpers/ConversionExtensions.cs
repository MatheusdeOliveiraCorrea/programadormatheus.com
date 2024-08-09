using agora.article.domain.entities;
using agora.article.infra.EmbeddedDocuments;
using agora.article.infra.Models;
using agora.domain;

namespace agora.article.infra.Helpers
{
  public static class ConversionExtensions
  {
    public static ArticleModel ToModel(this Article article)
    {
      return new ArticleModel
      {
        _id = article.Id is null ?
              MongoDB.Bson.ObjectId.GenerateNewId() : 
              MongoDB.Bson.ObjectId.Parse(article.Id),
        title = article.Title,
        author_id = article.AuthorID,
        body = article.Body,
        categories = article.Categories
                            .Select(category => category.ToModel())
                            .ToList(),
        comments = article.Comments
                          .Select(comment =>
                                comment.ToModel())
                          .ToList(),
      };
    }

    public static CommentModel ToModel(this Comment comment)
    {
      return new CommentModel
      {
        body = comment.Body,
      };
    }

    public static CategoryModel ToModel(this Category category)
    {
      return new CategoryModel
      {
        name = category.Name,
      };
    }

    public static Article ToEntity(this ArticleModel articleModel)
    {
      var articleEntity = new Article(articleModel._id.ToString()
                                    , articleModel.title
                                    , articleModel.body);

      articleEntity.SetComments(articleModel.comments?
                                            .Select(x => new Comment(x.body))
                                            ?? []);

      articleEntity.SetCategories(articleModel.categories?
                                              .Select(x => new Category(x.name))
                                              ?? []);

      return articleEntity;
    }
  }
}
