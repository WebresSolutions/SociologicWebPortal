using Microsoft.AspNetCore.Http;
using Moq;
using System.Security.Claims;

namespace Casimo.Test.Helpers;

/// <summary>
/// Helper class for creating HttpContext mocks specifically for testing HttpContextExtension methods
/// </summary>
public static class HttpContextMockHelper
{
    /// <summary>
    /// Creates a mock HttpContext with a specific user ID claim
    /// This is specifically designed for testing the UserId() extension method
    /// </summary>
    /// <param name="userId">The user ID to set in the NameIdentifier claim</param>
    /// <param name="additionalClaims">Optional additional claims to add</param>
    /// <returns>Mock HttpContext configured with the specified claims</returns>
    public static HttpContext CreateMockHttpContextWithUserId(string userId, params Claim[] additionalClaims)
    {
        List<Claim> claims =
        [
            new(ClaimTypes.NameIdentifier, userId),
            new(ClaimTypes.Name, "testuser@example.com")
        ];

        if (additionalClaims is not null)
            claims.AddRange(additionalClaims);

        ClaimsIdentity identity = new(claims, "Test");
        ClaimsPrincipal principal = new(identity);

        Mock<HttpContext> mockHttpContext = new();
        mockHttpContext.Setup(x => x.User).Returns(principal);

        return mockHttpContext.Object;
    }

    /// <summary>
    /// Creates a mock HttpContext with a specific user ID and roles
    /// </summary>
    /// <param name="userId">The user ID to set in the NameIdentifier claim</param>
    /// <param name="roles">Roles to add to the user</param>
    /// <returns>Mock HttpContext configured with the specified user ID and roles</returns>
    public static HttpContext CreateMockHttpContextWithUserIdAndRoles(string userId, params string[] roles)
    {
        List<Claim> claims =
        [
            new(ClaimTypes.NameIdentifier, userId),
            new(ClaimTypes.Name, "testuser@example.com")
        ];

        foreach (string role in roles)
        {
            claims.Add(new Claim(ClaimTypes.Role, role));
        }

        ClaimsIdentity identity = new(claims, "Test");
        ClaimsPrincipal principal = new(identity);

        Mock<HttpContext> mockHttpContext = new();
        mockHttpContext.Setup(x => x.User).Returns(principal);

        return mockHttpContext.Object;
    }

    /// <summary>
    /// Creates a mock HttpContext without a NameIdentifier claim
    /// This is useful for testing error scenarios in the UserId() extension method
    /// </summary>
    /// <param name="includeOtherClaims">Whether to include other claims like Name</param>
    /// <returns>Mock HttpContext without NameIdentifier claim</returns>
    public static HttpContext CreateMockHttpContextWithoutUserId(bool includeOtherClaims = true)
    {
        List<Claim> claims = [];

        if (includeOtherClaims)
        {
            claims.Add(new Claim(ClaimTypes.Name, "testuser@example.com"));
            claims.Add(new Claim(ClaimTypes.Role, "AdminUser"));
        }

        ClaimsIdentity identity = new(claims, "Test");
        ClaimsPrincipal principal = new(identity);

        Mock<HttpContext> mockHttpContext = new();
        mockHttpContext.Setup(x => x.User).Returns(principal);

        return mockHttpContext.Object;
    }

    /// <summary>
    /// Creates a mock HttpContext with a null NameIdentifier claim
    /// This is useful for testing error scenarios in the UserId() extension method
    /// </summary>
    /// <returns>Mock HttpContext with null NameIdentifier claim</returns>
    public static HttpContext CreateMockHttpContextWithNullUserId()
    {
        List<Claim> claims =
        [
            new(ClaimTypes.NameIdentifier, null!),
            new(ClaimTypes.Name, "testuser@example.com")
        ];

        ClaimsIdentity identity = new(claims, "Test");
        ClaimsPrincipal principal = new(identity);

        Mock<HttpContext> mockHttpContext = new();
        mockHttpContext.Setup(x => x.User).Returns(principal);

        return mockHttpContext.Object;
    }

    /// <summary>
    /// Creates a mock HttpContext with an empty NameIdentifier claim
    /// This is useful for testing error scenarios in the UserId() extension method
    /// </summary>
    /// <returns>Mock HttpContext with empty NameIdentifier claim</returns>
    public static HttpContext CreateMockHttpContextWithEmptyUserId()
    {
        List<Claim> claims =
        [
            new(ClaimTypes.NameIdentifier, ""),
            new(ClaimTypes.Name, "testuser@example.com")
        ];

        ClaimsIdentity identity = new(claims, "Test");
        ClaimsPrincipal principal = new(identity);

        Mock<HttpContext> mockHttpContext = new();
        mockHttpContext.Setup(x => x.User).Returns(principal);

        return mockHttpContext.Object;
    }

    /// <summary>
    /// Creates a mock HttpContext with a whitespace-only NameIdentifier claim
    /// This is useful for testing error scenarios in the UserId() extension method
    /// </summary>
    /// <returns>Mock HttpContext with whitespace-only NameIdentifier claim</returns>
    public static HttpContext CreateMockHttpContextWithWhitespaceUserId()
    {
        List<Claim> claims =
        [
            new(ClaimTypes.NameIdentifier, "   "),
            new(ClaimTypes.Name, "testuser@example.com")
        ];

        ClaimsIdentity identity = new(claims, "Test");
        ClaimsPrincipal principal = new(identity);

        Mock<HttpContext> mockHttpContext = new();
        mockHttpContext.Setup(x => x.User).Returns(principal);

        return mockHttpContext.Object;
    }

    /// <summary>
    /// Example usage method showing how to use the mock for testing the UserId extension method
    /// </summary>
    /// <returns>Example test result</returns>
    public static string ExampleUsage()
    {
        // Example 1: Create a mock with a valid user ID
        HttpContext httpContextWithValidUserId = CreateMockHttpContextWithUserId("user-123");
        // Now you can test: var userId = httpContextWithValidUserId.UserId();

        // Example 2: Create a mock with user ID and roles
        HttpContext httpContextWithRoles = CreateMockHttpContextWithUserIdAndRoles("user-456", "AdminUser", "FullUser");
        // Now you can test: var userId = httpContextWithRoles.UserId();

        // Example 3: Create a mock without user ID (for testing error scenarios)
        HttpContext httpContextWithoutUserId = CreateMockHttpContextWithoutUserId();
        // Now you can test that it throws an exception: Assert.Throws<Exception>(() => httpContextWithoutUserId.UserId());

        return "Mock creation examples completed";
    }
}
