#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 5442

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Notifications/MGP.Notifications.API/MGP.Notifications.API.csproj", "Notifications/MGP.Notifications.API/"]
COPY ["Notifications/MGP.Notifications.Application/MGP.Notifications.Application.csproj", "Notifications/MGP.Notifications.Application/"]
COPY ["Notifications/MGP.Notifications.CrossCutting/MGP.Notifications.CrossCutting.csproj", "Notifications/MGP.Notifications.CrossCutting/"]
COPY ["Notifications/MGP.Notifications.Domain/MGP.Notifications.Domain.csproj", "Notifications/MGP.Notifications.Domain/"]
COPY ["Notifications/MGP.Notifications.Persistance/MGP.Notifications.Persistance.csproj", "Notifications/MGP.Notifications.Persistance/"]
RUN dotnet restore "./Notifications/MGP.Notifications.API/MGP.Notifications.API.csproj"
COPY . .
WORKDIR "/src/Notifications/MGP.Notifications.API"
RUN dotnet build "./MGP.Notifications.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./MGP.Notifications.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MGP.Notifications.API.dll"]