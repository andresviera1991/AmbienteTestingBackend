FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 5432

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Autenticacion/MGP.Authentication.Api/MGP.Authentication.API.csproj", "Autenticacion/MGP.Authentication.Api/"]
COPY ["Autenticacion/MGP.Authentication.Application/MGP.Authentication.Application.csproj", "Autenticacion/MGP.Authentication.Application/"]
COPY ["Autenticacion/MGP.Authentication.CrossCutting/MGP.Authentication.CrossCutting.csproj", "Autenticacion/MGP.Authentication.CrossCutting/"]
COPY ["Autenticacion/MGP.Authentication.Domain/MGP.Authentication.Domain.csproj", "Autenticacion/MGP.Authentication.Domain/"]
COPY ["Autenticacion/MGP.Authentication.Persistance/MGP.Authentication.Persistance.csproj", "Autenticacion/MGP.Authentication.Persistance/"]
RUN dotnet restore "./Autenticacion/MGP.Authentication.Api/MGP.Authentication.API.csproj"
COPY . .
WORKDIR "/src/Autenticacion/MGP.Authentication.Api"
RUN dotnet build "./MGP.Authentication.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./MGP.Authentication.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Ejecutar las migraciones y luego la aplicación
ENTRYPOINT ["dotnet", "MGP.Authentication.API.dll"]
