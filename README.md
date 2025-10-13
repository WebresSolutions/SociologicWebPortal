# Casimo - Comprehensive Facility Management System

A modern, full-stack facility management and assessment platform built with ASP.NET Core, Blazor WebAssembly, and Entity Framework Core.

## 🏗️ Project Architecture

```
Casimo/
├── Casimo.Server/           # Backend API & Identity Provider
│   ├── Casimo.Server/       # Main ASP.NET Core Web API
│   │   ├── Controllers/     # API Endpoints
│   │   ├── Services/        # Business Logic Services
│   │   ├── Helpers/         # Utility Classes
│   │   └── Dependencies.cs  # DI Configuration
│   └── Casimo.Data/         # Data Access Layer
│       ├── CasimoDB/        # Entity Framework Models
│       └── IdentityData/    # Authentication Models
├── Casimo.Web/              # Frontend Blazor WebAssembly
│   ├── Pages/               # Application Pages
│   ├── Components/          # Reusable UI Components
│   └── Services/            # API Communication
└── Casimo.Shared/           # Shared Models & DTOs
    ├── ApiModels/           # Data Transfer Objects
    ├── ResponseModels/      # API Response Wrappers
    └── Enums/               # Shared Enumerations
```

## 🚀 Technology Stack

- **Backend**: ASP.NET Core 8, Entity Framework Core, OpenIddict
- **Frontend**: Blazor WebAssembly, MudBlazor UI Components
- **Database**: SQL Server with Entity Framework Code-First
- **Authentication**: OpenID Connect with ASP.NET Core Identity
- **API Documentation**: OpenAPI/Swagger + Scalar
- **Containerization**: Docker & Docker Compose

## 📋 Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)
- [Docker Desktop](https://www.docker.com/products/docker-desktop/) (optional, for containerized deployment)

## 🛠️ Getting Started

### 1. Clone the Repository

```bash
git clone <repository-url>
cd Casimo
```

### 2. Database Setup

#### Option A: Local SQL Server
1. Create a new database in SQL Server
2. Update connection strings in `Casimo.Server/Casimo.Server/appsettings.json`:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Database=CasimoDB;Trusted_Connection=true;TrustServerCertificate=true;",
       "AuthConnection": "Server=localhost;Database=CasimoAuthDB;Trusted_Connection=true;TrustServerCertificate=true;"
     }
   }
   ```

#### Option B: Docker SQL Server
```bash
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=YourStrong@Passw0rd" \
  -p 1433:1433 --name casimo-sql --hostname casimo-sql \
  -d mcr.microsoft.com/mssql/server:2022-latest
```

### 3. Database Scaffolding

The project uses Entity Framework Code-First approach. To scaffold the database:

1. **Open Package Manager Console** in Visual Studio
2. **Set Default Project** to `Casimo.Data`
3. **Run the scaffolding command**:

```bash
Scaffold-DbContext "Name=DefaultConnection" Microsoft.EntityFrameworkCore.SqlServer -OutputDir CasimoDB -Context CasimoDbContext -f
```

4. **Apply database changes** by running `dbChanges.sql` in SQL Server Management Studio

### 4. Build and Run

#### Development Mode
```bash
# Restore packages
dotnet restore

# Build the solution
dotnet build

# Run the server
cd Casimo.Server/Casimo.Server
dotnet run

# In another terminal, run the web client
cd Casimo.Web
dotnet run
```

#### Docker Mode
```bash
# Build and run with Docker Compose
docker-compose up -d --build

# View logs
docker-compose logs -f

# Stop services
docker-compose down
```

## 🔧 Development Workflow

### Adding New Database Models

1. **Create Entity Class** in `Casimo.Data/CasimoDB/`
2. **Add DbSet** to `CasimoDbContext`
3. **Create Migration**:
   ```bash
   dotnet ef migrations add AddNewModel --project Casimo.Data --startup-project Casimo.Server
   ```
4. **Update Database**:
   ```bash
   dotnet ef database update --project Casimo.Data --startup-project Casimo.Server
   ```

### Adding New API Endpoints

1. **Create Controller** in `Casimo.Server/Controllers/`
2. **Implement Service Interface** in `Casimo.Server/Services/Interfaces/`
3. **Implement Service** in `Casimo.Server/Services/Instances/`
4. **Add DTOs** in `Casimo.Shared/ApiModels/`
5. **Register Services** in `Dependencies.cs`

### Adding New Frontend Pages

1. **Create Razor Page** in `Casimo.Web/Pages/`
2. **Add Navigation** in `Casimo.Web/Shared/NavMenu.razor`
3. **Implement API Calls** using `IApiService`

## 📚 API Documentation

- **Development**: Navigate to `/swagger` for Swagger UI
- **Production**: Navigate to `/scalar` for Scalar API documentation
- **Authentication**: All endpoints require authorization except `/connect/*` endpoints

## 🔐 Authentication & Authorization

The system uses OpenID Connect with the following roles:
- **Admin**: Full system access
- **CouncilAdmin**: Limited administrative access
- **Temp**: Temporary user with restricted access

## 🧪 Testing

```bash
# Run unit tests
dotnet test

# Run with coverage
dotnet test --collect:"XPlat Code Coverage"
```

## 📦 Deployment

### Local Deployment
```bash
dotnet publish -c Release -o ./publish
```

### Docker Deployment
```bash
# Build production image
docker build -t casimo:latest .

# Run production container
docker run -d -p 8080:80 casimo:latest
```

### Azure Deployment
1. **Create App Service** in Azure Portal
2. **Configure Connection Strings** in Application Settings
3. **Deploy** using Azure DevOps or GitHub Actions

## 🐛 Troubleshooting

### Common Issues

1. **Database Connection Failed**
   - Verify SQL Server is running
   - Check connection strings in `appsettings.json`
   - Ensure firewall allows connections

2. **Authentication Errors**
   - Verify OpenIddict configuration in `Dependencies.cs`
   - Check client application settings in `appsettings.json`

3. **Build Errors**
   - Ensure .NET 8 SDK is installed
   - Run `dotnet restore` before building
   - Check for missing package references

### Logs

- **Server Logs**: Check console output or `logs/` directory
- **Database Logs**: SQL Server Management Studio → Management → SQL Server Logs
- **Docker Logs**: `docker-compose logs -f`

## 🤝 Contributing

1. **Fork** the repository
2. **Create** a feature branch
3. **Make** your changes
4. **Add** tests for new functionality
5. **Submit** a pull request

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 📞 Support

For support and questions:
- **Issues**: Create a GitHub issue
- **Documentation**: Check the project wiki
- **Email**: [support@casimo.com](mailto:support@casimo.com)

---

**Built with ❤️ using ASP.NET Core and Blazor**
