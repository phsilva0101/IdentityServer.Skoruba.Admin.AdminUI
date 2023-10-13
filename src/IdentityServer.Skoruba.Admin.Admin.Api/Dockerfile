FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/IdentityServer.Skoruba.Admin.Admin.Api/IdentityServer.Skoruba.Admin.Admin.Api.csproj", "src/IdentityServer.Skoruba.Admin.Admin.Api/"]
COPY ["src/IdentityServer.Skoruba.Admin.Admin.EntityFramework.Shared/IdentityServer.Skoruba.Admin.Admin.EntityFramework.Shared.csproj", "src/IdentityServer.Skoruba.Admin.Admin.EntityFramework.Shared/"]
COPY ["src/IdentityServer.Skoruba.Admin.Admin.EntityFramework.SqlServer/IdentityServer.Skoruba.Admin.Admin.EntityFramework.SqlServer.csproj", "src/IdentityServer.Skoruba.Admin.Admin.EntityFramework.SqlServer/"]
COPY ["src/IdentityServer.Skoruba.Admin.Shared/IdentityServer.Skoruba.Admin.Shared.csproj", "src/IdentityServer.Skoruba.Admin.Shared/"]
COPY ["src/IdentityServer.Skoruba.Admin.Admin.EntityFramework.PostgreSQL/IdentityServer.Skoruba.Admin.Admin.EntityFramework.PostgreSQL.csproj", "src/IdentityServer.Skoruba.Admin.Admin.EntityFramework.PostgreSQL/"]
COPY ["src/IdentityServer.Skoruba.Admin.Admin.EntityFramework.MySql/IdentityServer.Skoruba.Admin.Admin.EntityFramework.MySql.csproj", "src/IdentityServer.Skoruba.Admin.Admin.EntityFramework.MySql/"]
RUN dotnet restore "src/IdentityServer.Skoruba.Admin.Admin.Api/IdentityServer.Skoruba.Admin.Admin.Api.csproj"
COPY . .
WORKDIR "/src/src/IdentityServer.Skoruba.Admin.Admin.Api"
RUN dotnet build "IdentityServer.Skoruba.Admin.Admin.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IdentityServer.Skoruba.Admin.Admin.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
ENTRYPOINT ["dotnet", "IdentityServer.Skoruba.Admin.Admin.Api.dll"]