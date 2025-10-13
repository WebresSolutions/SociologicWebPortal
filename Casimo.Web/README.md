# Casimo Web - Blazor WebAssembly Frontend

A modern, responsive **Blazor WebAssembly** web client for the Casimo facility management system. Built with .NET 8 and MudBlazor UI components.

## 🏗️ Architecture Overview

```
Casimo.Web/
├── Pages/                   # Application Pages
│   ├── Index.razor         # Home page with FitForPurpose dashboard
│   ├── Authentication.razor # OAuth authentication handling
│   ├── Facility/           # Facility management pages
│   │   ├── Facilities.razor      # Facility listing with search
│   │   └── FacilityDetails.razor # Detailed facility view with maps
│   ├── FitForPurpose/      # Assessment management pages
│   │   ├── Assessments.razor           # Assessment listing
│   │   ├── AssessmentsLists.razor     # Assessment list management
│   │   └── SuitabilityAssessment.razor # Assessment form & scoring
│   └── Usermanagement/     # User administration pages
│       ├── UserManager.razor           # User listing
│       └── UserManagementIndvidual.razor # Individual user editing
├── Components/             # Reusable UI Components
│   ├── BaseDataComponent.razor        # Base class with auth & loading
│   ├── FitForPurpose.razor            # Assessment dashboard
│   ├── QuestionComponent.razor        # Individual question display
│   ├── CreateUser.razor               # User creation form
│   ├── RedirectToLogin.razor          # Authentication redirect
│   ├── UI/                           # UI Components
│   │   └── Card.razor                # Reusable card component
│   └── Dialogues/                    # Modal dialogs
│       ├── AssessmentsInListDialog.razor    # Assessment list viewer
│       ├── AssignedUsersDialog.razor        # User assignment viewer
│       └── CreateAssessmentDialog.razor     # Assessment list creator
├── Services/               # API Communication
│   ├── IApiService.cs      # API service interface
│   └── ApiService.cs       # HTTP client implementation
├── Helpers/                # Utility Classes
│   ├── Clone.cs            # Deep object cloning
│   └── RoleColourHelper.cs # Role-based color mapping
├── Shared/                 # Layout & Navigation
│   ├── MainLayout.razor    # Main application layout
│   ├── NavMenu.razor       # Sidebar navigation
│   └── LoginDisplay.razor  # Top navigation bar
├── wwwroot/                # Static Assets
│   ├── css/                # Custom stylesheets
│   ├── js/                 # JavaScript files
│   └── lib/                # Third-party libraries
└── Program.cs              # Application entry point
```

## 🚀 Key Features

- **Blazor WebAssembly** for client-side .NET execution
- **MudBlazor** UI component library for modern design
- **OAuth Authentication** with OpenID Connect
- **Google Maps Integration** for facility location display
- **Responsive Design** for desktop and mobile devices
- **Role-based Access Control** with dynamic navigation
- **Real-time Data Updates** via HTTP API calls
- **Progressive Web App** capabilities

## 📋 Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [Casimo-Server](https://github.com/your-org/Casimo-Server) running locally
- [Casimo-Shared](https://github.com/your-org/Casimo-Shared) project
- Modern web browser with WebAssembly support

## 🛠️ Setup & Configuration

### 1. Project Dependencies

Ensure all three projects are in the same root directory:
```
Casimo/
├── Casimo.Server/          # Backend API
├── Casimo.Web/             # Frontend (this project)
└── Casimo.Shared/          # Shared models
```

### 2. Configuration

#### Authentication Settings
Update `wwwroot/appsettings.json` with your server configuration:

```json
{
  "ApiBaseUrl": "https://localhost:7000",
  "GoogleMaps": {
    "MapsApiKey": "your-google-maps-api-key"
  }
}
```

#### Environment-Specific Settings
- `appsettings.Development.json` - Development environment
- `appsettings.Staging.json` - Staging environment
- `appsettings.Production.json` - Production environment
- `appsettings.Localdocker.json` - Docker environment

### 3. Google Maps Integration

1. **Get API Key** from [Google Cloud Console](https://console.cloud.google.com/)
2. **Enable Maps JavaScript API**
3. **Add API Key** to configuration
4. **Restrict API Key** to your domain for security

## 🔧 Development Workflow

### Adding New Pages

1. **Create Razor Page** in `Pages/` directory:
   ```razor
   @page "/NewFeature"
   @inherits BaseDataComponent
   
   <h3>New Feature</h3>
   
   @code {
       protected override async Task OnInitializedAsync()
       {
           await base.OnInitializedAsync();
           // Implementation
       }
   }
   ```

2. **Add Navigation** in `Shared/NavMenu.razor`:
   ```razor
   <MudNavLink Href="NewFeature" Icon="@Icons.Material.Filled.NewReleases">
       New Feature
   </MudNavLink>
   ```

3. **Implement API Calls** using `IApiService`:
   ```csharp
   private async Task LoadData()
   {
       var result = await ApiService.GetNewFeatureAsync();
       if (result.IsSuccess)
       {
           // Handle success
       }
   }
   ```

### Adding New Components

1. **Create Component** in `Components/` directory:
   ```razor
   @inherits BaseDataComponent
   
   <div class="new-component">
       @ChildContent
   </div>
   
   @code {
       [Parameter]
       public RenderFragment ChildContent { get; set; }
   }
   ```

2. **Use Component** in pages:
   ```razor
   <NewComponent>
       <p>Content goes here</p>
   </NewComponent>
   ```

### Adding New Services

1. **Extend IApiService** interface:
   ```csharp
   public interface IApiService
   {
       Task<Result<NewFeatureDto>> GetNewFeatureAsync(int id);
   }
   ```

2. **Implement in ApiService**:
   ```csharp
   public async Task<Result<NewFeatureDto>> GetNewFeatureAsync(int id)
   {
       return await GetAsync<NewFeatureDto>($"api/NewFeature/{id}");
   }
   ```

## 🚀 Running the Application

### Development Mode

1. **Ensure Server is Running**:
   ```bash
   cd Casimo.Server/Casimo.Server
   dotnet run
   ```

2. **Run Web Client**:
   ```bash
   cd Casimo.Web
   dotnet run
   ```

3. **Open Browser** to `https://localhost:9900`

### Docker Mode

```bash
# Build and run with Docker Compose
docker-compose up -d --build

# Access application at configured port
```

### Visual Studio

1. **Open Solution** `Casimo.Server.sln`
2. **Set Multiple Startup Projects**:
   - Casimo.Server: Start
   - Casimo.Web: Start
3. **Press F5** to run both projects

## 🔐 Authentication Flow

### OAuth Integration

1. **User Clicks Login** → Redirected to `/authentication/login`
2. **OAuth Provider** (GitHub) authenticates user
3. **Callback Processing** → User redirected back to application
4. **Token Storage** → Access token stored in browser
5. **API Calls** → Token included in Authorization header

### Role-Based Access

- **Admin**: Full system access
- **CouncilAdmin**: Limited administrative access
- **Temp**: Temporary user with restricted access

### Protected Routes

All pages inherit from `BaseDataComponent` which:
- Checks authentication status
- Redirects unauthenticated users to login
- Provides loading state management

## 🎨 UI Components

### MudBlazor Integration

The application uses MudBlazor for consistent, modern UI:

- **MudDataGrid**: Data display with sorting, filtering, pagination
- **MudDialog**: Modal dialogs for user interactions
- **MudCard**: Content containers with loading states
- **MudNavigation**: Responsive navigation components
- **MudForm**: Form components with validation

### Custom Components

- **Card**: Reusable card with loading states and titles
- **BaseDataComponent**: Base class for authenticated components
- **QuestionComponent**: Assessment question display and editing

## 📱 Responsive Design

### Mobile-First Approach

- **Responsive Grid**: Adapts to different screen sizes
- **Touch-Friendly**: Optimized for mobile devices
- **Progressive Enhancement**: Works on all device types

### Breakpoints

- **Mobile**: < 768px
- **Tablet**: 768px - 1024px
- **Desktop**: > 1024px

## 🔄 State Management

### Component State

- **Local State**: Managed within individual components
- **Parameter Passing**: Parent-child component communication
- **Event Callbacks**: Child-to-parent communication

### API State

- **HTTP Client**: Centralized API communication
- **Error Handling**: Consistent error display
- **Loading States**: User feedback during operations

## 🧪 Testing

### Unit Testing

```bash
# Run tests
dotnet test

# Run with coverage
dotnet test --collect:"XPlat Code Coverage"
```

### Component Testing

Use bUnit for Blazor component testing:

```csharp
[Test]
public void Component_ShouldRender_Correctly()
{
    using var ctx = new TestContext();
    var component = ctx.RenderComponent<MyComponent>();
    
    Assert.IsNotNull(component);
}
```

## 📦 Building & Deployment

### Development Build

```bash
dotnet build
```

### Production Build

```bash
dotnet publish -c Release -o ./publish
```

### Docker Build

```bash
docker build -t casimo-web:latest .
```

## 🐛 Troubleshooting

### Common Issues

#### Authentication Errors
- Verify server is running and accessible
- Check OAuth configuration in server
- Clear browser cookies and local storage
- Check browser console for errors

#### Build Errors
- Ensure .NET 8 SDK is installed
- Run `dotnet restore` before building
- Check project references are correct
- Verify all projects are in same directory

#### Runtime Errors
- Check browser console for JavaScript errors
- Verify API endpoints are accessible
- Check network tab for failed requests
- Ensure Google Maps API key is valid

### Debugging

#### Browser Developer Tools
- **Console**: JavaScript and .NET errors
- **Network**: API request/response details
- **Application**: Local storage and cookies
- **Sources**: Blazor WebAssembly debugging

#### Visual Studio Debugging
- Set breakpoints in Razor components
- Use browser debugging tools
- Check Output window for build information

## 🔧 Performance Optimization

### Blazor WebAssembly Best Practices

1. **Lazy Loading**: Load components on demand
2. **Virtualization**: Use virtual scrolling for large lists
3. **Memory Management**: Dispose of resources properly
4. **Bundle Optimization**: Minimize initial download size

### API Optimization

1. **Caching**: Cache frequently accessed data
2. **Pagination**: Load data in chunks
3. **Debouncing**: Limit rapid API calls
4. **Error Handling**: Graceful degradation

## 📚 Additional Resources

### Blazor Documentation
- [Blazor WebAssembly](https://docs.microsoft.com/en-us/aspnet/core/blazor/webassembly-blazor)
- [Blazor Components](https://docs.microsoft.com/en-us/aspnet/core/blazor/components)
- [Blazor State Management](https://docs.microsoft.com/en-us/aspnet/core/blazor/state-management)

### MudBlazor Documentation
- [MudBlazor Components](https://mudblazor.com/components)
- [MudBlazor Themes](https://mudblazor.com/features/themes)
- [MudBlazor Examples](https://mudblazor.com/examples)

### Google Maps API
- [Maps JavaScript API](https://developers.google.com/maps/documentation/javascript)
- [API Key Management](https://developers.google.com/maps/documentation/javascript/get-api-key)
- [Best Practices](https://developers.google.com/maps/documentation/javascript/best-practices)

## 🤝 Contributing

1. **Fork** the repository
2. **Create** a feature branch
3. **Follow** Blazor and MudBlazor best practices
4. **Add** XML documentation to new components
5. **Test** on multiple browsers and devices
6. **Submit** a pull request

## 📄 License

This project is licensed under the MIT License.

---

**Built with Blazor WebAssembly, MudBlazor, and .NET 8**
