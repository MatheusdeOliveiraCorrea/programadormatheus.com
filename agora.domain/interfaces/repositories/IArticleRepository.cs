using agora.domain;

namespace agora.article.domain;

public interface IArticleRepository
{
    Article CreateArticle(Article article);

    Article GetArticle(string id);

    IEnumerable<Article> GetArticles();

    Article UpdateArticle();

    void DeleteArticle(int id);
}
