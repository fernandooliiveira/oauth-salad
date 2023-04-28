FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["OAuthSalad/OAuthSalad.csproj", "OAuthSalad/"]
RUN dotnet restore "OAuthSalad/OAuthSalad.csproj"
COPY . .
WORKDIR "/src/OAuthSalad"
RUN dotnet build "OAuthSalad.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OAuthSalad.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OAuthSalad.dll"]
