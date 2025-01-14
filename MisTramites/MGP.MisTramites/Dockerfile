#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 5435

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["MisTramites/MGP.MisTramites/MGP.MisTramites.API.csproj", "MisTramites/MGP.MisTramites/"]
COPY ["MisTramites/MGP.MisTramites.Application/MGP.MisTramites.Application.csproj", "MisTramites/MGP.MisTramites.Application/"]
COPY ["MisTramites/MGP.MisTramites.CrossCutting/MGP.MisTramites.CrossCutting.csproj", "MisTramites/MGP.MisTramites.CrossCutting/"]
COPY ["MisTramites/MGP.MisTramites.Domain/MGP.MisTramites.Domain.csproj", "MisTramites/MGP.MisTramites.Domain/"]
COPY ["MisTramites/MGP.MisTramites.Client/MGP.MisTramites.Client.csproj", "MisTramites/MGP.MisTramites.Client/"]
RUN dotnet restore "./MisTramites/MGP.MisTramites/MGP.MisTramites.API.csproj"
COPY . .
WORKDIR "/src/MisTramites/MGP.MisTramites"
RUN dotnet build "./MGP.MisTramites.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./MGP.MisTramites.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MGP.MisTramites.API.dll"]