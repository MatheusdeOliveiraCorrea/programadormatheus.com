# Etapa 1: Imagem base para execução
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Etapa 2: Imagem de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copiar os arquivos .csproj e restaurar as dependências
COPY ["agora.article.api/agora.article.api.csproj", "agora.article.api/"]
COPY ["agora.domain/agora.article.domain.csproj", "agora.domain/"]
COPY ["agora.article.infra/agora.article.infra.csproj", "agora.article.infra/"]

# Restaurar pacotes
RUN dotnet restore "agora.article.api/agora.article.api.csproj"

# Copiar todo o código-fonte
COPY . .

# Definir o diretório de trabalho para o projeto principal
WORKDIR "/src/agora.article.api"

# Construir o projeto
RUN dotnet build "./agora.article.api.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Etapa 3: Publicar o projeto
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./agora.article.api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Etapa 4: Imagem final
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "agora.article.api.dll"]
