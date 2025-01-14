#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 5434

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Backoffice/MGP.Backoffice.Api/MGP.Backoffice.Api.csproj", "Backoffice/MGP.Backoffice.Api/"]
COPY ["Backoffice/MGP.Backoffice.Application/MGP.Backoffice.Application.csproj", "Backoffice/MGP.Backoffice.Application/"]
COPY ["Backoffice/MGP.Backoffice.CrossCutting/MGP.Backoffice.CrossCutting.csproj", "Backoffice/MGP.Backoffice.CrossCutting/"]
COPY ["Backoffice/MGP.Backoffice.Domain/MGP.Backoffice.Domain.csproj", "Backoffice/MGP.Backoffice.Domain/"]
COPY ["Backoffice/MGP.Backoffice.Persistance/MGP.Backoffice.Persistance.csproj", "Backoffice/MGP.Backoffice.Persistance/"]
RUN dotnet restore "./Backoffice/MGP.Backoffice.Api/MGP.Backoffice.Api.csproj"
COPY . .
WORKDIR "/src/Backoffice/MGP.Backoffice.Api"
RUN dotnet build "./MGP.Backoffice.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./MGP.Backoffice.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MGP.Backoffice.Api.dll"]