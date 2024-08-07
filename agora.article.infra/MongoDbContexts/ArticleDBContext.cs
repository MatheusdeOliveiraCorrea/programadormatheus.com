using agora.article.infra.Models;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using MongoDB.EntityFrameworkCore.Extensions;

namespace agora.article.infra.MongoDbContexts
{
  public class ArticleDBContext : DbContext
  {
    public DbSet<ArticleModel> Articles { get; set; }

    public static ArticleDBContext Create(IMongoDatabase database) =>
        new(new DbContextOptionsBuilder<ArticleDBContext>()
            .UseMongoDB(database.Client, database.DatabaseNamespace.DatabaseName)
            .Options);

    public ArticleDBContext(DbContextOptions options)
    : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<ArticleModel>().ToCollection("articles");
    }
  }
}
