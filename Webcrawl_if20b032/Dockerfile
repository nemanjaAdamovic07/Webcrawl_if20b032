#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081
RUN mkdir -p /app/wwwroot/files/ && chmod -R 777 /app/wwwroot/files/
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Webcrawl_if20b032/Webcrawl_if20b032.csproj", "Webcrawl_if20b032/"]
RUN dotnet restore "./Webcrawl_if20b032/./Webcrawl_if20b032.csproj"
COPY . .
WORKDIR "/src/Webcrawl_if20b032"
RUN dotnet build "./Webcrawl_if20b032.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Webcrawl_if20b032.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Webcrawl_if20b032.dll"]