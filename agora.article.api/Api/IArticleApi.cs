using agora.domain;

namespace agora.article.api;

public interface IArticleApi
{
    Article GetArticle(int id);

    List<Article> GetArticles();
}
