# Casimo Shared - Common Models & DTOs

A **.NET 8 shared class library** containing common models, DTOs, and utilities used across the Casimo Server and Web projects. This project serves as the contract between the backend API and frontend client.

## 🏗️ Architecture Overview

```
Casimo.Shared/
├── ApiModels/               # Data Transfer Objects
│   ├── Coordinates.cs       # Geographic coordinate models
│   ├── Facility.cs          # Facility-related DTOs
│   ├── CreateUserDto.cs     # User creation models
│   ├── ManageUserDetailsDto.cs # User management models
│   ├── UserDto.cs           # User information models
│   ├── UserRolesDto.cs      # User role models
│   ├── FitForPurpose/       # Assessment-related DTOs
│   │   ├── FitForPurposeDto.cs           # Comprehensive assessment data
│   │   ├── FacilityDetailsDto.cs         # Detailed facility information
│   │   ├── AssessmentListItemDto.cs      # Assessment list items
│   │   ├── QuestionResponseDetailDto.cs  # Question response details
│   │   ├── AssessmentLogDetailDto.cs     # Assessment log details
│   │   ├── SectionDetailDto.cs           # Assessment section details
│   │   ├── TemplateQuestionDto.cs        # Template question models
│   │   ├── AssessmentSectionDto.cs       # Assessment section models
│   │   ├── AssessmentList/               # Assessment list models
│   │   │   ├── AssessmentListBase.cs     # Base assessment list
│   │   │   ├── AssessmentListRequestDto.cs # Assessment list requests
│   │   │   └── AssessmentListResponseDto.cs # Assessment list responses
│   │   └── User/                         # User assessment models
│   │       ├── UserAssessmentListDto.cs  # User assessment assignments
│   │       ├── UsersAssignedToAssessmentDto.cs # User assignment details
│   │       ├── UserInviteFormModel.cs    # User invitation forms
│   │       └── UserIviteDto.cs           # User invitation DTOs
│   └── Responses/            # API Response Models
│       ├── SaveQuestionResponseDto.cs    # Question response saving
│       └── SaveQuestionResListDto.cs     # Bulk question response saving
├── ResponseModels/           # API Response Wrappers
│   ├── Result.cs             # Generic result wrapper
│   ├── PagedResponse.cs      # Paginated response wrapper
│   └── ErrorType.cs          # Error type enumeration
├── Enums/                    # Shared Enumerations
│   └── AssessmentStatusEnum.cs # Assessment status values
├── Helpers/                  # Utility Classes
│   ├── Validation.cs         # Data validation utilities
│   └── EnumExtensions.cs     # Enum extension methods
├── WebModels/                # Web-Specific Models
│   ├── GoogleMaps.cs         # Google Maps configuration
│   └── MarkerData.cs         # Map marker data models
└── RoleConstants.cs          # Role definition constants
```

## 🚀 Key Features

- **Data Transfer Objects (DTOs)** for API communication
- **Response Models** for consistent API responses
- **Validation Attributes** for data integrity
- **Enum Extensions** for display name retrieval
- **Utility Classes** for common operations
- **Role Constants** for authorization
- **Web Models** for frontend integration

## 📋 Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- Referenced by both `Casimo.Server` and `Casimo.Web` projects

## 🛠️ Usage

### 1. Project References

Add this project as a reference in your consuming projects:

```xml
<ProjectReference Include="..\Casimo.Shared\Casimo.Shared.csproj" />
```

### 2. Using DTOs

```csharp
using Casimo.Shared.ApiModels;
using Casimo.Shared.ApiModels.FitForPurpose;

// Create facility DTO
var facility = new FacilityListItemDto
{
    FacilityId = 1,
    SiteName = "Main Facility",
    Address = "123 Main St",
    Operator = "City Council"
};

// Use assessment DTOs
var assessment = new AssessmentListItemDto
{
    AssessmentLogId = 1,
    FacilityName = "Main Facility",
    TemplateTitle = "Standard Assessment",
    Status = AssessmentStatusEnum.InProgress
};
```

### 3. Using Response Models

```csharp
using Casimo.Shared.ResponseModels;

// Create success result
var result = new Result<FacilityListItemDto>
{
    Value = facility
};

// Create error result
var errorResult = new Result<FacilityListItemDto>();
errorResult.SetError(ErrorType.NotFound, "Facility not found");

// Check result status
if (result.IsSuccess)
{
    var facility = result.Value;
    // Process facility
}
```

### 4. Using Enums and Extensions

```csharp
using Casimo.Shared.Enums;
using Casimo.Shared.Helpers;

// Get display name for enum
var status = AssessmentStatusEnum.InProgress;
var displayName = status.GetDisplayName(); // "In Progress"

// Validate email
var isValid = Validation.IsValidEmail("user@example.com");
```

## 🔧 Development Workflow

### Adding New DTOs

1. **Create DTO Class** in appropriate namespace:
   ```csharp
   namespace Casimo.Shared.ApiModels
   {
       /// <summary>
       /// Data transfer object for new feature
       /// </summary>
       public class NewFeatureDto
       {
           /// <summary>
           /// Gets or sets the unique identifier
           /// </summary>
           public int Id { get; set; }
           
           /// <summary>
           /// Gets or sets the feature name
           /// </summary>
           public string Name { get; set; } = string.Empty;
       }
   }
   ```

2. **Add Validation Attributes** if needed:
   ```csharp
   using System.ComponentModel.DataAnnotations;
   
   public class NewFeatureDto
   {
       [Required]
       [StringLength(100)]
       public string Name { get; set; } = string.Empty;
   }
   ```

3. **Update Response Models** if needed:
   ```csharp
   public class NewFeatureResponseDto
   {
       public NewFeatureDto Feature { get; set; }
       public DateTime CreatedAt { get; set; }
   }
   ```

### Adding New Enums

1. **Create Enum** in `Enums/` directory:
   ```csharp
   namespace Casimo.Shared.Enums
   {
       /// <summary>
       /// Enumeration for feature status
       /// </summary>
       public enum FeatureStatusEnum
       {
           /// <summary>
           /// Feature is active
           /// </summary>
           Active,
           
           /// <summary>
           /// Feature is inactive
           /// </summary>
           Inactive
       }
   }
   ```

2. **Add Display Attributes** for user-friendly names:
   ```csharp
   using System.ComponentModel.DataAnnotations;
   
   public enum FeatureStatusEnum
   {
       [Display(Name = "Active")]
       Active,
       
       [Display(Name = "Inactive")]
       Inactive
   }
   ```

### Adding New Utility Classes

1. **Create Utility Class** in `Helpers/` directory:
   ```csharp
   namespace Casimo.Shared.Helpers
   {
       /// <summary>
       /// Utility class for feature operations
       /// </summary>
       public static class FeatureHelper
       {
           /// <summary>
           /// Validates feature name format
           /// </summary>
           /// <param name="name">The feature name to validate</param>
           /// <returns>True if valid, false otherwise</returns>
           public static bool IsValidFeatureName(string name)
           {
               return !string.IsNullOrWhiteSpace(name) && name.Length <= 100;
           }
       }
   }
   ```

## 📊 Data Models

### Core DTOs

#### Facility Models
- **FacilityListItemDto**: Basic facility information for lists
- **FacilityDetailsDto**: Comprehensive facility details
- **FacilityRelatedAssets**: Assets associated with facilities

#### Assessment Models
- **AssessmentListItemDto**: Assessment summary for lists
- **AssessmentLogDetailDto**: Complete assessment details
- **QuestionResponseDetailDto**: Individual question responses
- **SectionDetailDto**: Assessment section information

#### User Models
- **UserDto**: Basic user information (immutable record)
- **UserRolesDto**: User role assignments (immutable record)
- **ManageUserDetailsDto**: Comprehensive user management

### Response Models

#### Result<T>
Generic wrapper for API responses with:
- Success/failure indication
- Error type and description
- HTTP status code conversion

#### PagedResponse<T>
Paginated data response with:
- Current page items
- Total count and pages
- Page size and current page

### Enums

#### AssessmentStatusEnum
Defines assessment workflow states:
- NotStarted
- InProgress
- Completed
- Submitted
- Approved
- Rejected

## 🔐 Role-Based Access Control

### Role Constants
```csharp
public static class RoleConstants
{
    public const string Admin = "Admin";
    public const string CouncilAdmin = "CouncilUser";
    public const string Temp = "Temp";
}
```

### Usage in Authorization
```csharp
[Authorize(Roles = RoleConstants.Admin)]
public class AdminController : Controller
{
    // Admin-only endpoints
}
```

## 🧪 Testing

### Unit Testing DTOs

```csharp
[Test]
public void FacilityDto_ShouldHaveRequiredProperties()
{
    // Arrange
    var facility = new FacilityListItemDto();
    
    // Act & Assert
    Assert.That(facility.FacilityId, Is.EqualTo(0));
    Assert.That(facility.SiteName, Is.EqualTo(string.Empty));
}
```

### Testing Response Models

```csharp
[Test]
public void Result_ShouldIndicateSuccess_WhenValueIsSet()
{
    // Arrange
    var result = new Result<string> { Value = "Success" };
    
    // Act & Assert
    Assert.That(result.IsSuccess, Is.True);
}
```

## 📦 Building & Publishing

### Development Build
```bash
dotnet build
```

### Release Build
```bash
dotnet build -c Release
```

### Publishing
```bash
dotnet pack -c Release
```

## 🔄 Versioning

### Semantic Versioning
This project follows [Semantic Versioning](https://semver.org/):
- **Major**: Breaking changes to public APIs
- **Minor**: New functionality in backward-compatible manner
- **Patch**: Backward-compatible bug fixes

### Breaking Changes
When making breaking changes:
1. **Update Major Version**
2. **Document Changes** in CHANGELOG.md
3. **Provide Migration Guide** if needed
4. **Update Consuming Projects** to new version

## 🐛 Troubleshooting

### Common Issues

#### Build Errors
- Ensure .NET 8 SDK is installed
- Run `dotnet restore` before building
- Check project references are correct
- Verify namespace declarations

#### Runtime Errors
- Check DTO property names match API responses
- Verify enum values are consistent
- Ensure validation attributes are correct
- Check for missing using statements

### Debugging

#### DTO Serialization
```csharp
// Debug DTO serialization
var json = JsonSerializer.Serialize(dto, new JsonSerializerOptions 
{ 
    WriteIndented = true 
});
Console.WriteLine(json);
```

#### Enum Values
```csharp
// Debug enum values
foreach (var value in Enum.GetValues<AssessmentStatusEnum>())
{
    Console.WriteLine($"{value}: {value.GetDisplayName()}");
}
```

## 📚 Best Practices

### DTO Design
1. **Immutable Records** for simple data transfer
2. **Validation Attributes** for data integrity
3. **XML Documentation** for all public members
4. **Consistent Naming** conventions
5. **Separation of Concerns** between different DTOs

### Response Models
1. **Generic Types** for reusability
2. **Error Handling** for consistent error responses
3. **Success Indicators** for easy status checking
4. **HTTP Status Mapping** for proper error codes

### Enums
1. **Display Attributes** for user-friendly names
2. **Extension Methods** for common operations
3. **Documentation** for all enum values
4. **Consistent Naming** conventions

## 🤝 Contributing

1. **Fork** the repository
2. **Create** a feature branch
3. **Follow** existing patterns and conventions
4. **Add XML Documentation** to all public members
5. **Update Tests** for new functionality
6. **Submit** a pull request

## 📄 License

This project is licensed under the MIT License.

---

**Built with .NET 8 and designed for reusability across the Casimo platform**
