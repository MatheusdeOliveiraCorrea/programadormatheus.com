using agora.article.domain;
using agora.domain;

namespace agora.article.api;

public class ArticleApi : IArticleApi
{
    private readonly IArticleRepository _articleRepository;

    public ArticleApi(IArticleRepository articleRepository)
    {
        _articleRepository = articleRepository;
    }

    public Article GetArticle(int id) => _articleRepository.GetArticle(id);

    public List<Article> GetArticles() => _articleRepository.GetArticles();
}
