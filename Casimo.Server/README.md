# Casimo Server - Backend API & Identity Provider

This is the **Casimo-Server**, a robust backend web application built with **ASP.NET Core 8**. It serves as the backend API and identity provider for the Casimo platform, supporting a Blazor WebAssembly client and shared logic across the system.

## 🏗️ Architecture Overview

```
Casimo.Server/
├── Casimo.Server/           # Main Web API Project
│   ├── Controllers/         # API Endpoints & Route Handlers
│   │   ├── BaseController.cs           # Common controller functionality
│   │   ├── AuthenticationController.cs # OAuth authentication callbacks
│   │   ├── AuthorizationController.cs  # User & role management
│   │   ├── UserManagerController.cs    # User administration
│   │   ├── FitForPurposeEndpoints.cs   # Assessment API endpoints
│   │   └── FacilitiesEndpoints.cs     # Facility management endpoints
│   ├── Services/            # Business Logic Layer
│   │   ├── Interfaces/      # Service contracts
│   │   │   ├── IFacilityService.cs        # Facility operations
│   │   │   └── IFitForPurposeService.cs   # Assessment operations
│   │   └── Instances/       # Service implementations
│   │       ├── FacilityService.cs         # Facility business logic
│   │       ├── FitForPurposeService.cs    # Assessment business logic
│   │       └── EmailSender.cs             # Email service (Smtp2Go)
│   ├── Models/              # View Models
│   │   └── ErrorViewModel.cs # Error display model
│   ├── ViewModels/          # Authorization Models
│   │   └── Authorization/   # OAuth view models
│   ├── Helpers/             # Utility Classes
│   ├── Strings/             # Error Message Constants
│   ├── ApiData/             # Configuration Models
│   ├── Dependencies.cs      # Service Registration
│   ├── Program.cs           # Application Entry Point
│   └── Worker.cs            # Background Service
└── Casimo.Data/             # Data Access Layer
    ├── CasimoDB/            # Entity Framework Models
    │   ├── CasimoDbContext.cs # Main database context
    │   ├── TblUser.cs       # User entity
    │   └── [Other Entities] # Database table models
    └── IdentityData/        # Authentication Models
        ├── AuthDBContext.cs # Identity database context
        ├── ApplicationUser.cs # Extended user model
        └── Migrations/      # EF Core migrations
```

## 🚀 Key Features

- **ASP.NET Core Web API** with minimal API endpoints
- **Integrated Identity System** (ASP.NET Core Identity)
- **OpenID Connect** authentication with OpenIddict
- **Entity Framework Core** with SQL Server
- **Role-based Authorization** (Admin, CouncilAdmin, Temp)
- **Blazor WebAssembly** client support
- **OpenAPI & Scalar** API documentation
- **Docker** containerization support
- **Background Services** for OAuth client management
- **Email Services** via Smtp2Go API

## 📋 Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)
- [Docker Desktop](https://www.docker.com/products/docker-desktop/) (optional)

## 🛠️ Setup & Configuration

### 1. Database Configuration

#### Connection Strings
Update `appsettings.json` with your database connection strings:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=CasimoDB;Trusted_Connection=true;TrustServerCertificate=true;",
    "AuthConnection": "Server=localhost;Database=CasimoAuthDB;Trusted_Connection=true;TrustServerCertificate=true;"
  }
}
```

#### Environment-Specific Settings
- `appsettings.Development.json` - Development environment
- `appsettings.Staging.json` - Staging environment  
- `appsettings.Production.json` - Production environment
- `appsettings.Localdocker.json` - Docker environment

### 2. OAuth Configuration

#### Client Options
Configure OAuth client settings in `appsettings.json`:

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

#### Email Configuration
Configure Smtp2Go API settings:

```json
{
  "SMPT2GO": "your-smtp2go-api-key",
  "EmailOptions": {
    "FromAddress": "noreply@casimo.com"
  }
}
```

### 3. CORS Configuration

CORS is configured for the following origins:
- `https://localhost:9900` (Blazor WebAssembly)
- `https://localhost:9901` (Development)
- `https://localhost:44310` (Visual Studio)

## 🔧 Development Workflow

### Adding New API Endpoints

1. **Create Endpoint Class** (for minimal APIs):
   ```csharp
   public static class NewFeatureEndpoints
   {
       public static void AddNewFeatureEndpoints(this IEndpointRouteBuilder app)
       {
           var group = app.MapGroup("api/NewFeature");
           
           group.MapGet("/", async (INewFeatureService service) =>
           {
               // Implementation
           }).RequireAuthorization();
       }
   }
   ```

2. **Register in Program.cs**:
   ```csharp
   app.AddNewFeatureEndpoints();
   ```

### Adding New Services

1. **Create Interface** in `Services/Interfaces/`:
   ```csharp
   public interface INewFeatureService
   {
       Task<Result<NewFeatureDto>> GetFeatureAsync(int id);
   }
   ```

2. **Implement Service** in `Services/Instances/`:
   ```csharp
   public class NewFeatureService : INewFeatureService
   {
       public async Task<Result<NewFeatureDto>> GetFeatureAsync(int id)
       {
           // Implementation
       }
   }
   ```

3. **Register in Dependencies.cs**:
   ```csharp
   builder.Services.AddScoped<INewFeatureService, NewFeatureService>();
   ```

### Database Operations

#### Entity Framework Context
The main database context is `CasimoDbContext` in the `Casimo.Data` project.

#### Adding New Entities
1. **Create Entity Class** in `Casimo.Data/CasimoDB/`
2. **Add DbSet** to `CasimoDbContext`
3. **Create Migration**:
   ```bash
   dotnet ef migrations add AddNewEntity --project Casimo.Data --startup-project Casimo.Server
   ```
4. **Update Database**:
   ```bash
   dotnet ef database update --project Casimo.Data --startup-project Casimo.Server
   ```

## 🚀 Running the Application

### Development Mode
```bash
# Navigate to server directory
cd Casimo.Server/Casimo.Server

# Restore packages
dotnet restore

# Run the application
dotnet run

# Or use Visual Studio
# Open Casimo.Server.sln and press F5
```

### Docker Mode
```bash
# Build and run with Docker Compose
docker-compose up -d --build

# View logs
docker-compose logs -f casimo-server

# Stop services
docker-compose down
```

### Environment Variables
```bash
# Set environment for Docker
ASPNETCORE_ENVIRONMENT=Staging

# Run with specific environment
dotnet run --environment Staging
```

## 📚 API Documentation

### Development Mode
- **Swagger UI**: Navigate to `/swagger`
- **OpenAPI JSON**: Navigate to `/swagger/v1/swagger.json`

### Production Mode
- **Scalar API**: Navigate to `/scalar`
- **API Reference**: Navigate to `/api-reference`

## 🔐 Authentication & Authorization

### OpenID Connect Flow
1. **Client Redirects** to `/connect/authorize`
2. **User Authenticates** via external provider (GitHub)
3. **Callback Processing** in `AuthenticationController`
4. **Token Issuance** via `/connect/token`
5. **API Access** with Bearer token

### Role-Based Access Control
- **Admin**: Full system access
- **CouncilAdmin**: Limited administrative access
- **Temp**: Temporary user with restricted access

### Protected Endpoints
All API endpoints require authorization except:
- `/connect/authorize` - OAuth authorization
- `/connect/token` - Token issuance
- `/connect/userinfo` - User information
- `/connect/logout` - Logout

## 🧪 Testing

### Unit Tests
```bash
# Run all tests
dotnet test

# Run specific project tests
dotnet test Casimo.Server.Tests

# Run with coverage
dotnet test --collect:"XPlat Code Coverage"
```

### Integration Tests
```bash
# Run integration tests
dotnet test --filter Category=Integration
```

### API Testing
Use the built-in Swagger UI or tools like:
- [Postman](https://www.postman.com/)
- [Insomnia](https://insomnia.rest/)
- [curl](https://curl.se/)

## 📦 Deployment

### Local Publishing
```bash
dotnet publish -c Release -o ./publish
```

### Docker Production
```bash
# Build production image
docker build -t casimo-server:latest .

# Run production container
docker run -d -p 8080:80 \
  -e ASPNETCORE_ENVIRONMENT=Production \
  -e ConnectionStrings__DefaultConnection="your-connection-string" \
  casimo-server:latest
```

### Azure Deployment
1. **Create App Service** in Azure Portal
2. **Configure Application Settings**:
   - Connection strings
   - Environment variables
   - OAuth client settings
3. **Deploy** using:
   - Azure DevOps
   - GitHub Actions
   - Visual Studio publish

## 🐛 Troubleshooting

### Common Issues

#### Database Connection Failed
- Verify SQL Server is running
- Check connection strings in `appsettings.json`
- Ensure firewall allows connections
- Verify database exists

#### Authentication Errors
- Check OpenIddict configuration in `Dependencies.cs`
- Verify OAuth client settings
- Check external provider configuration (GitHub)
- Review authentication logs

#### Build Errors
- Ensure .NET 8 SDK is installed
- Run `dotnet restore` before building
- Check for missing package references
- Verify project file dependencies

### Logging

#### Console Logging
Logs are written to console by default. Check the terminal output for:
- Database connection status
- Authentication flow
- API request/response details
- Error messages

#### Database Logs
Use SQL Server Management Studio to check:
- Connection attempts
- Query performance
- Error logs

#### Docker Logs
```bash
# View container logs
docker-compose logs -f casimo-server

# View specific service logs
docker logs casimo-server
```

## 🔄 Background Services

### Worker Service
The `Worker` class runs as a hosted service and:
- Ensures database creation
- Initializes OpenIddict applications
- Manages OAuth client registration

### Quartz.NET Integration
OpenIddict uses Quartz.NET for:
- Token cleanup
- Scheduled tasks
- Background job processing

## 📁 Project Structure Details

### Controllers
- **BaseController**: Common error handling and response formatting
- **AuthenticationController**: OAuth callback processing
- **AuthorizationController**: User and role management
- **Endpoints Classes**: Minimal API endpoint configurations

### Services
- **FacilityService**: Facility CRUD operations and filtering
- **FitForPurposeService**: Assessment management and scoring
- **EmailSender**: Email delivery via Smtp2Go

### Data Layer
- **CasimoDbContext**: Main application database context
- **AuthDBContext**: Identity and authentication database
- **Entity Models**: Database table representations

## 🤝 Contributing

1. **Fork** the repository
2. **Create** a feature branch
3. **Follow** the existing code style and patterns
4. **Add** XML documentation to new public members
5. **Test** your changes thoroughly
6. **Submit** a pull request

## 📄 License

This project is licensed under the MIT License.

---

**Built with ASP.NET Core 8, OpenIddict, and Entity Framework Core**