#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 5439

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ApiGateway/MGP.ApiGateway/MGP.ApiGateway.csproj", "ApiGateway/MGP.ApiGateway/"]
RUN dotnet restore "./ApiGateway/MGP.ApiGateway/MGP.ApiGateway.csproj"
COPY . .
WORKDIR "/src/ApiGateway/MGP.ApiGateway"
RUN dotnet build "./MGP.ApiGateway.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./MGP.ApiGateway.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MGP.ApiGateway.dll"]