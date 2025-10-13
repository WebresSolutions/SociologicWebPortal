FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 9900
EXPOSE 9901

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy project files for dependency restoration
COPY ["Casimo.Server/Casimo.Server/Casimo.Server.csproj", "Casimo.Server/Casimo.Server/"]
COPY ["Casimo.Server/Casimo.Data/Casimo.Data.csproj", "Casimo.Server/Casimo.Data/"]
COPY ["Casimo.Shared/Casimo.Shared.csproj", "Casimo.Shared/"]
COPY ["Casimo.Web/Casimo.Web.csproj", "Casimo.Web/"]

# Copy all source code first
COPY . .

# Restore and build Shared project first
WORKDIR "/src/Casimo.Shared"
RUN dotnet restore
RUN dotnet build -c $BUILD_CONFIGURATION

# Restore and build Web project
WORKDIR "/src/Casimo.Web"
RUN dotnet restore
RUN dotnet build -c $BUILD_CONFIGURATION
RUN dotnet publish -c $BUILD_CONFIGURATION -o /app/client -p:PublishTrimmed=true -p:TrimMode=partial

# Build the server project last since it depends on the others
WORKDIR "/src/Casimo.Server/Casimo.Server"
RUN dotnet restore
RUN dotnet build -c $BUILD_CONFIGURATION -o /app/build

# Publish the server project
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
WORKDIR "/src/Casimo.Server/Casimo.Server"
RUN dotnet publish "Casimo.Server.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Copy the client build output to the server's wwwroot
COPY --from=build /app/client/wwwroot /app/publish/wwwroot

FROM base AS final
WORKDIR /app

# Copy the published server application
COPY --from=publish /app/publish .

# Set the entry point
ENTRYPOINT ["dotnet", "Casimo.Server.dll"]