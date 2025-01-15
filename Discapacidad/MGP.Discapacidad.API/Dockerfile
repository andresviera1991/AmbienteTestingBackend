#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 5433

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Discapacidad/MGP.Discapacidad.API/MGP.Discapacidad.API.csproj", "Discapacidad/MGP.Discapacidad.API/"]
COPY ["Discapacidad/MGP.Discapacidad.Application/MGP.Discapacidad.Application.csproj", "Discapacidad/MGP.Discapacidad.Application/"]
COPY ["Discapacidad/MGP.Discapacidad.CrossCutting/MGP.Discapacidad.CrossCutting.csproj", "Discapacidad/MGP.Discapacidad.CrossCutting/"]
COPY ["Discapacidad/MGP.Discapacidad.Domain/MGP.Discapacidad.Domain.csproj", "Discapacidad/MGP.Discapacidad.Domain/"]
COPY ["Discapacidad/MGP.Discapacidad.Client/MGP.Discapacidad.Client.csproj", "Discapacidad/MGP.Discapacidad.Client/"]
COPY ["Discapacidad/MGP.Discapacidad.Persistance/MGP.Discapacidad.Persistance.csproj", "Discapacidad/MGP.Discapacidad.Persistance/"]
RUN dotnet restore "./Discapacidad/MGP.Discapacidad.API/MGP.Discapacidad.API.csproj"
COPY . .
WORKDIR "/src/Discapacidad/MGP.Discapacidad.API"
RUN dotnet build "./MGP.Discapacidad.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./MGP.Discapacidad.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MGP.Discapacidad.API.dll"]