#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["TechnicalChallenge.WebApi/TechnicalChallenge.WebApi.csproj", "TechnicalChallenge.WebApi/"]
RUN dotnet restore "TechnicalChallenge.WebApi/TechnicalChallenge.WebApi.csproj"
COPY . .
WORKDIR "/src/TechnicalChallenge.WebApi"
RUN dotnet build "TechnicalChallenge.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TechnicalChallenge.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TechnicalChallenge.WebApi.dll"]