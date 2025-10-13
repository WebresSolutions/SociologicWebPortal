# HttpContext Extension Method Mocking

This directory contains comprehensive mocks and test utilities for testing the `HttpContextExtension.UserId()` method and related functionality.

## Files Overview

### 1. `HttpContextExtensionTests.cs`
Complete unit tests for the `HttpContextExtension` class, including:
- Testing the `UserId()` extension method with various scenarios
- Testing the `UserCasimoId()` and `UserName()` methods
- Error scenario testing (missing claims, null values, etc.)
- Theory-based tests for different user ID formats

### 2. `HttpContextMockHelper.cs`
Utility class providing static methods for creating mock `HttpContext` objects:
- `CreateMockHttpContextWithUserId()` - Basic mock with user ID
- `CreateMockHttpContextWithUserIdAndRoles()` - Mock with user ID and roles
- `CreateMockHttpContextWithoutUserId()` - Mock without NameIdentifier claim
- `CreateMockHttpContextWithNullUserId()` - Mock with null user ID
- `CreateMockHttpContextWithEmptyUserId()` - Mock with empty user ID
- `CreateMockHttpContextWithWhitespaceUserId()` - Mock with whitespace user ID

### 3. `HttpContextExtensionMockExample.cs`
Practical examples demonstrating how to use the mocks in various scenarios.

## Quick Start

### Basic Usage

```csharp
// Create a mock with a valid user ID
var httpContext = HttpContextMockHelper.CreateMockHttpContextWithUserId("user-123");
var userId = httpContext.UserId(); // Returns "user-123"
```

### Testing Error Scenarios

```csharp
// Test when user ID is missing
var httpContext = HttpContextMockHelper.CreateMockHttpContextWithoutUserId();
Assert.Throws<Exception>(() => httpContext.UserId());
```

### Testing with Roles

```csharp
// Create a mock with user ID and roles
var httpContext = HttpContextMockHelper.CreateMockHttpContextWithUserIdAndRoles(
    "user-456", 
    "AdminUser", 
    "FullUser"
);
var userId = httpContext.UserId(); // Returns "user-456"
```

## The Original Method

The `UserId` extension method being mocked:

```csharp
public static string UserId(this HttpContext context)
{
    string? userIdClaim = context.User.FindFirstValue(ClaimTypes.NameIdentifier) 
        ?? throw new Exception("Could not find the userId ");
    return userIdClaim;
}
```

## Key Features

1. **Comprehensive Coverage**: Tests all success and error scenarios
2. **Easy to Use**: Simple static methods for creating mocks
3. **Flexible**: Support for custom claims and roles
4. **Well Documented**: Clear examples and documentation
5. **Type Safe**: Uses proper C# types and FluentAssertions

## Dependencies

- `Moq` - For creating mock objects
- `FluentAssertions` - For readable test assertions
- `Xunit` - For the testing framework
- `System.Security.Claims` - For claim-based authentication

## Running the Tests

```bash
# Run all tests
dotnet test

# Run specific test class
dotnet test --filter "HttpContextExtensionTests"

# Run with verbose output
dotnet test --verbosity normal
```

## Best Practices

1. **Use the Helper Methods**: Prefer `HttpContextMockHelper` methods over manual mock creation
2. **Test Both Success and Error Cases**: Always test what happens when claims are missing or invalid
3. **Use Theory Tests**: For testing multiple input values efficiently
4. **Clear Test Names**: Use descriptive test method names that explain the scenario
5. **Arrange-Act-Assert**: Follow the AAA pattern in your tests

## Common Scenarios

### Testing a Service Method

```csharp
[Fact]
public void MyService_WithValidUser_ProcessesCorrectly()
{
    // Arrange
    var httpContext = HttpContextMockHelper.CreateMockHttpContextWithUserId("user-123");
    var service = new MyService();

    // Act
    var result = service.ProcessRequest(httpContext);

    // Assert
    result.Should().NotBeNull();
    // Additional assertions...
}
```

### Testing Authorization Logic

```csharp
[Fact]
public void AuthorizeUser_WithAdminRole_AllowsAccess()
{
    // Arrange
    var httpContext = HttpContextMockHelper.CreateMockHttpContextWithUserIdAndRoles(
        "user-123", 
        "AdminUser"
    );

    // Act
    var isAuthorized = AuthorizeUser(httpContext);

    // Assert
    isAuthorized.Should().BeTrue();
}
```

This mocking approach provides a robust foundation for testing any code that depends on the `HttpContext.UserId()` extension method.
