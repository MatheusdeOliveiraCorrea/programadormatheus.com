using agora.article.api;

var builder = WebApplication.CreateBuilder(args);

builder.AddApplicationServices();

var app = builder.Build();

app.UseCors(builder => builder.AllowAnyHeader()
                              .AllowAnyMethod()
                              .SetIsOriginAllowed(x => true));

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/article/{id}", (int id, IArticleApi api) => 
{
    var article = api.GetArticle(id);
    return article == null ? Results.NotFound() : Results.Ok(article);
});

app.MapGet("/articles", (IArticleApi api) => 
{
    var articles = api.GetArticles();
    return articles.Count == 0 ? Results.NotFound() : Results.Ok(articles);
});

app.UseHttpsRedirection();

app.Run();