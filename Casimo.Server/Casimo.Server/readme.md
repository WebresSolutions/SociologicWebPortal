# Casimo Server - Development Guide

This is the Casimo server project containing the backend API and Blazor WebAssembly frontend.

## 🏗️ Project Structure

- **Backend**: ASP.NET Core Web API with minimal endpoints
- **Frontend**: Blazor WebAssembly project
- **Database**: Entity Framework Core with SQL Server

## 🗄️ Database Scaffolding

### Prerequisites
- SQL Server instance running
- Database created and accessible
- Connection string configured in `appsettings.json`

### Scaffold the Casimo Database

1. **Open Package Manager Console** in Visual Studio
2. **Set Default Project** to `Casimo.Data`
3. **Run the scaffolding command**:

```bash
Scaffold-DbContext "Name=DefaultConnection" Microsoft.EntityFrameworkCore.SqlServer -OutputDir CasimoDB -Context CasimoDbContext -f
```

4. **Apply database changes** by running `dbChanges.sql` in SQL Server Management Studio

### Database Context Location
The scaffolded database context will be created in:
```
Casimo.Data/CasimoDB/CasimoDbContext.cs
```

## 🔄 Entity Framework Operations

### Add New Migration

```bash
dotnet ef migrations add YourMigrationName --project Casimo.Data --startup-project Casimo.Server --context CasimoDbContext
```

### Update Database

```bash
dotnet ef database update --project Casimo.Data --startup-project Casimo.Server --context CasimoDbContext
```

### Remove Last Migration

```bash
dotnet ef migrations remove --project Casimo.Data --startup-project Casimo.Server --context CasimoDbContext
```

### Generate SQL Script

```bash
dotnet ef migrations script --project Casimo.Data --startup-project Casimo.Server --context CasimoDbContext
```

## 🔐 Authentication Database Operations

### Add Migration to AuthDBContext

```bash
dotnet ef migrations add YourMigrationName --project Casimo.Data --startup-project Casimo.Server --context AuthDBContext
```

### Update Authentication Database

```bash
dotnet ef database update --project Casimo.Data --startup-project Casimo.Server --context AuthDBContext
```

### Remove Authentication Migration

```bash
dotnet ef migrations remove --project Casimo.Data --startup-project Casimo.Server --context AuthDBContext
```

### Generate a migrations script 

```bash
dotnet ef migrations script --project Casimo.Data --startup-project Casimo.Server --context AuthDBContext --output migration-script.sql
```


## 🐳 Docker Development

### Run with Docker Compose

```bash
# Set environment
ASPNETCORE_ENVIRONMENT=Staging

# Build and run
docker-compose up -d --build

# View logs
docker-compose logs -f

# Stop services
docker-compose down
```

### Docker Commands

```bash
# Build image
docker build -t casimo-server .

# Run container
docker run -d -p 8080:80 casimo-server

# View running containers
docker ps

# View container logs
docker logs <container-id>
```

## 🚀 Development Workflow

### 1. Database Changes
1. **Modify Entity Models** in `Casimo.Data/CasimoDB/`
2. **Add DbSet** to `CasimoDbContext` if needed
3. **Create Migration**: `dotnet ef migrations add...`
4. **Update Database**: `dotnet ef database update`

### 2. API Development
1. **Create Service Interface** in `Services/Interfaces/`
2. **Implement Service** in `Services/Instances/`
3. **Add Endpoints** in `Controllers/` or create endpoint classes
4. **Register Services** in `Dependencies.cs`

### 3. Frontend Development
1. **Create Razor Pages** in `Pages/`
2. **Add Components** in `Components/`
3. **Update Navigation** in `Shared/NavMenu.razor`
4. **Implement API Calls** using `IApiService`

## 🔧 Configuration

### Connection Strings
Update `appsettings.json` with your database connections:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=CasimoDB;Trusted_Connection=true;TrustServerCertificate=true;",
    "AuthConnection": "Server=localhost;Database=CasimoAuthDB;Trusted_Connection=true;TrustServerCertificate=true;"
  }
}
```

### OAuth Settings
Configure OAuth client in `appsettings.json`:

```json
{
  "ClientOptions": {
    "ClientId": "your-client-id",
    "DisplayName": "Casimo Client",
    "RedirectUri": "https://localhost:9900/authentication/login-callback",
    "PostLogoutRedirectUri": "https://localhost:9900/authentication/logout-callback"
  }
}
```

## 🧪 Testing

### Run Tests
```bash
dotnet test
```

### Run with Coverage
```bash
dotnet test --collect:"XPlat Code Coverage"
```

### Run Specific Tests
```bash
dotnet test --filter Category=Integration
```

## 📦 Building

### Development Build
```bash
dotnet build
```

### Release Build
```bash
dotnet build -c Release
```

### Publish
```bash
dotnet publish -c Release -o ./publish
```

## 🐛 Troubleshooting

### Common Issues

#### Database Connection Failed
- Verify SQL Server is running
- Check connection strings in `appsettings.json`
- Ensure firewall allows connections
- Verify database exists

#### Scaffolding Errors
- Check connection string is correct
- Ensure database is accessible
- Verify Entity Framework tools are installed
- Check for existing context files

#### Build Errors
- Ensure .NET 8 SDK is installed
- Run `dotnet restore` before building
- Check for missing package references
- Verify project file dependencies

### Useful Commands

```bash
# Restore packages
dotnet restore

# Clean build
dotnet clean
dotnet build

# Check EF tools
dotnet ef --version

# List migrations
dotnet ef migrations list --project Casimo.Data --startup-project Casimo.Server
```

## 📚 Additional Resources

- [Entity Framework Core Documentation](https://docs.microsoft.com/en-us/ef/core/)
- [ASP.NET Core Documentation](https://docs.microsoft.com/en-us/aspnet/core/)
- [Blazor WebAssembly Documentation](https://docs.microsoft.com/en-us/aspnet/core/blazor/webassembly-blazor)
- [OpenIddict Documentation](https://documentation.openiddict.com/)

---

**Happy Coding! 🚀**