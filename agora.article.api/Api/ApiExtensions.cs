using agora.article.domain;
using agora.article.infra;

namespace agora.article.api;

public static class ApiExtensions
{
    public static void AddApplicationServices(this IHostApplicationBuilder builder)
    {
        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowAll", builder =>
                            builder.AllowAnyOrigin()
                                   .AllowAnyMethod()
                                   .AllowAnyHeader()
                                   .SetIsOriginAllowed(x => true));
        });

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddScoped<IArticleRepository, ArticleRepository>();
        builder.Services.AddScoped<IArticleApi, ArticleApi>();
    }
}
