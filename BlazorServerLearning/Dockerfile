#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BlazorServerLearning/BlazorServerLearning.csproj", "BlazorServerLearning/"]
RUN dotnet restore "BlazorServerLearning/BlazorServerLearning.csproj"
COPY . .
WORKDIR "/src/BlazorServerLearning"
RUN dotnet build "BlazorServerLearning.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlazorServerLearning.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlazorServerLearning.dll"]

FROM mcr.microsoft.com/dotnet/sdk:6.0 as development
WORKDIR /app
COPY ["BlazorServerLearning/BlazorServerLearning.csproj", "BlazorServerLearning/"]
RUN dotnet restore "BlazorServerLearning/BlazorServerLearning.csproj"
COPY . .
WORKDIR "/app/BlazorServerLearning"
RUN dotnet watch
