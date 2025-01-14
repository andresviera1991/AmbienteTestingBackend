#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 5436

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Locations/MGP.Location.API/MGP.Location.API.csproj", "Locations/MGP.Location.API/"]
COPY ["Locations/MGP.Location.Application/MGP.Location.Application.csproj", "Locations/MGP.Location.Application/"]
COPY ["Locations/MGP.Location.CrossCutting/MGP.Location.CrossCutting.csproj", "Locations/MGP.Location.CrossCutting/"]
COPY ["Locations/MGP.Location.Domain/MGP.Location.Domain.csproj", "Locations/MGP.Location.Domain/"]
COPY ["Locations/MGP.Location.Client/MGP.Location.Client.csproj", "Locations/MGP.Location.Client/"]
COPY ["Locations/MGP.Location.Persistance/MGP.Location.Persistance.csproj", "Locations/MGP.Location.Persistance/"]
RUN dotnet restore "./Locations/MGP.Location.API/MGP.Location.API.csproj"
COPY . .
WORKDIR "/src/Locations/MGP.Location.API"
RUN dotnet build "./MGP.Location.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./MGP.Location.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MGP.Location.API.dll"]