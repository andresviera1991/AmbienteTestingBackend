#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 5437

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Auditoria/MGP.Audit.API/MGP.Audit.API.csproj", "Auditoria/MGP.Audit.API/"]
COPY ["Auditoria/MGP.Audit.Application/MGP.Audit.Application.csproj", "Auditoria/MGP.Audit.Application/"]
COPY ["Auditoria/MGP.Audit.CrossCutting/MGP.Audit.CrossCutting.csproj", "Auditoria/MGP.Audit.CrossCutting/"]
COPY ["Auditoria/MGP.Audit.Domain/MGP.Audit.Domain.csproj", "Auditoria/MGP.Audit.Domain/"]
COPY ["Auditoria/MGP.Audit.Persistance/MGP.Audit.Persistance.csproj", "Auditoria/MGP.Audit.Persistance/"]
RUN dotnet restore "./Auditoria/MGP.Audit.API/MGP.Audit.API.csproj"
COPY . .
WORKDIR "/src/Auditoria/MGP.Audit.API"
RUN dotnet build "./MGP.Audit.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./MGP.Audit.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MGP.Audit.API.dll"]