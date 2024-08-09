using agora.article.api.Parameters;
using agora.article.domain;
using agora.article.domain.entities;
using agora.article.infra;
using agora.article.infra.Helpers;
using agora.article.infra.MongoDbContexts;
using Microsoft.EntityFrameworkCore;

namespace agora.article.api
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var connectionString = Environment.GetEnvironmentVariable("MONGODB_URI_ARTICLE_DB");

      if (connectionString == null)
      {
        Console.WriteLine("You must set your 'MONGODB_URI_ARTICLE_DB' environment variable. To learn how to set it, see https://www.mongodb.com/docs/drivers/csharp/current/quick-start/#set-your-connection-string");
        Environment.Exit(0);
      }

      var builder = WebApplication.CreateBuilder(args);

      builder.Services.AddAuthorization();

      builder.Services.AddEndpointsApiExplorer();
      builder.Services.AddSwaggerGen();

      builder.Services.AddScoped<IArticleRepository, ArticleRepository>();

      builder.Services.AddDbContext<ArticleDBContext>(options =>
        options.UseMongoDB(connectionString, "api_articles_db"));

      var app = builder.Build();

      if (app.Environment.IsDevelopment())
      {
        app.UseSwagger();
        app.UseSwaggerUI();
      }

      app.UseHttpsRedirection();

      app.UseAuthorization();

      app.MapGet("/article", (IArticleRepository repository) =>
      {
        return repository.GetArticles()
                         .Select(x => x.ToModel());
      });

      app.MapPost("/article", (JsonCreateArticle jsonArticle, IArticleRepository repository) =>
      {
        var entityArticle = new agora.domain.Article(jsonArticle.title, jsonArticle.body);

        entityArticle.SetComments(jsonArticle.comments?
                                             .Select(x =>
                                               new Comment(x.body)
                                             ) ?? []);

        entityArticle.SetCategories(jsonArticle.categories?
                                               .Select(x =>
                                                 new Category(x.name)
                                               ) ?? []);

        repository.CreateArticle(entityArticle);
      });

      app.Run();
    }
  }
}
