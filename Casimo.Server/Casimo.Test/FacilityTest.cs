using Casimo.Data.CasimoDB;
using Casimo.Server.Services.Instances;
using Casimo.Shared.ApiModels.Facility;
using Casimo.Shared.ApiModels.FitForPurpose;
using Casimo.Shared.ResponseModels;
using Casimo.Test.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Casimo.Test;

public class FacilityTest(CasimoWebAppFactory factory) : IClassFixture<CasimoWebAppFactory>, IDisposable
{
    private readonly ILogger<FacilityService> _logger = TestHelper.CreateMockLogger<FacilityService>();
    private readonly HttpContext _httpContext = HttpContextMockHelper.CreateMockHttpContextWithUserIdAndRoles("1", "AdminUser");
    private readonly CasimoWebAppFactory _Factory = factory;

    [Fact]
    public async Task GetAllFacilities()
    {
        CasimoDbContext dbContext = TestHelper.DbContext;
        _ = TestHelper.CreateFacilities(dbContext, Guid.NewGuid().ToString());
        _ = TestHelper.CreateFacilities(dbContext, Guid.NewGuid().ToString());
        _ = TestHelper.CreateFacilities(dbContext, Guid.NewGuid().ToString());

        FacilityService service = new(_logger, dbContext);
        // Act
        Result<PagedResponse<FacilityListItemDto>> facilities = await service.GetAllFacilities(_httpContext, 1, 3, null, null, Shared.Enums.SortDirectionEnum.Asc);

        // Assert
        Assert.True(facilities.IsSuccess);
        Assert.NotNull(facilities.Value);
        Assert.Equal(3, facilities.Value.Result.Count);

        // ACT
        facilities = await service.GetAllFacilities(_httpContext, 1, 2, null, null, Shared.Enums.SortDirectionEnum.Asc);

        // Assert
        Assert.True(facilities.IsSuccess);
        Assert.NotNull(facilities.Value);
        Assert.Equal(2, facilities.Value.Result.Count);
    }

    [Fact]
    public async Task GetAllFacilitiesFiltered()
    {
        CasimoDbContext dbContext = TestHelper.DbContext;
        string filterString = "Facility 1";
        TblFacility facility = TestHelper.CreateFacilities(dbContext, filterString);
        string filterString2 = "Facility 2";
        _ = TestHelper.CreateFacilities(dbContext, filterString2);
        FacilityService service = new(_logger, dbContext);
        // Act
        Result<PagedResponse<FacilityListItemDto>> facilities = await service.GetAllFacilities(_httpContext, 1, 2, filterString, null, Shared.Enums.SortDirectionEnum.Asc);

        // Assert
        Assert.True(facilities.IsSuccess);
        Assert.NotNull(facilities.Value);
        _ = Assert.Single(facilities.Value.Result);
        Assert.Equal(facility.FacilityId, facilities.Value.Result[0].FacilityId);
    }

    [Fact]
    public async Task GetSingleFaciltiy()
    {
        CasimoDbContext dbContext = TestHelper.DbContext;
        TblFacility facility = TestHelper.CreateFacilities(dbContext, Guid.NewGuid().ToString());
        FacilityService service = new(_logger, dbContext);
        // Act
        Result<FacilityDTO> faciltyRes = await service.GetFacility(facility.FacilityId);

        // Assert
        Assert.True(faciltyRes.IsSuccess);
        Assert.NotNull(faciltyRes.Value);
    }

    [Fact]
    public async Task GetFacilityInvalidId()
    {
        CasimoDbContext dbContext = TestHelper.DbContext;
        _ = TestHelper.CreateFacilities(dbContext, Guid.NewGuid().ToString());
        FacilityService service = new(_logger, dbContext);
        // Act
        Result<FacilityDTO> faciltyRes = await service.GetFacility(int.MaxValue);

        // Assert
        _ = Assert.NotNull(faciltyRes.Error);
        Assert.Null(faciltyRes.Value);
        Assert.Equal("The facility for which you requested does not exist", faciltyRes.ErrorDescription);
    }

    [Fact]
    public async Task UpdateFacilityDetails()
    {
        CasimoDbContext dbContext = TestHelper.DbContext;
        TblFacility facility = TestHelper.CreateFacilities(dbContext, Guid.NewGuid().ToString());

        FacilityService service = new(_logger, dbContext);

        // Arrange - Get existing facility and modify it
        Result<FacilityDTO> existingFacility = await service.GetFacility(facility.FacilityId);
        Assert.True(existingFacility.IsSuccess);

        FacilityDetailsDto updatedDetails = new(
            facilityId: 1,
            siteName: "Updated Facility Site",
            streetAddress: "Updated Address 123",
            postCode: 1234,
            suburb: "Updated Suburb",
            owner: "Updated Owner",
            "Updated Operator",
            status: "Active",
            coordinates: new Coordinates(40.7128, -74.0060),
            notes: "Updated notes",
            statusId: 1
        );

        // Act
        Result<FacilityDTO> result = await service.SaveFacilityDetails(updatedDetails);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.NotNull(result.Value);
        Assert.Equal("Updated Facility Site", result.Value.FacilityDetails.SiteName);
        Assert.Equal("Updated Address 123", result.Value.FacilityDetails.StreetAddress);
        Assert.Equal("Updated Suburb", result.Value.FacilityDetails.Suburb);
        Assert.Equal("Updated Owner", result.Value.FacilityDetails.Owner);
        Assert.Equal("Updated Operator", result.Value.FacilityDetails.Operator);
        Assert.Equal("Updated notes", result.Value.FacilityDetails.Notes);
    }

    [Fact]
    public async Task SaveFacilityDetails_InvalidFacilityId()
    {
        CasimoDbContext dbContext = TestHelper.DbContext;
        FacilityService service = new(_logger, dbContext);

        // Arrange
        FacilityDetailsDto invalidDetails = new(
            facilityId: int.MaxValue,
            siteName: "Test Site",
            streetAddress: "Test Address",
            postCode: 1234,
            suburb: "Test Suburb",
            owner: "Test Owner",
             "Test Operator",
            status: "Active",
            coordinates: new Coordinates(40.7128, -74.0060),
            notes: "Test notes",
            statusId: 1
        );

        // Act
        Result<FacilityDTO> result = await service.SaveFacilityDetails(invalidDetails);

        // Assert
        Assert.False(result.IsSuccess);
        _ = Assert.NotNull(result.Error);
        Assert.Equal("The facility for which you requested does not exist", result.ErrorDescription);
    }

    [Fact]
    public async Task SaveFacilityDetails_StringTruncation()
    {
        CasimoDbContext dbContext = TestHelper.DbContext;
        TblFacility facility = TestHelper.CreateFacilities(dbContext, Guid.NewGuid().ToString());
        FacilityService service = new(_logger, dbContext);

        // Arrange - Create details with very long strings to test truncation
        string longString = new('A', 200); // 200 characters
        FacilityDetailsDto detailsWithLongStrings = new(
            facilityId: facility.FacilityId,
            siteName: longString,
            streetAddress: longString,
            postCode: 1234,
            suburb: longString,
            owner: longString,
            longString,
            status: "Active",
            coordinates: new Coordinates(40.7128, -74.0060),
            notes: "Test notes",
            statusId: 1
        );

        // Act
        Result<FacilityDTO> result = await service.SaveFacilityDetails(detailsWithLongStrings);

        // Assert
        Assert.True(result.IsSuccess, result.ErrorDescription ?? "String truncation failed.");
        Assert.NotNull(result.Value);
        // Check that strings are truncated to 150 characters
        Assert.Equal(150, result.Value.FacilityDetails.SiteName.Length);
        Assert.Equal(150, result.Value.FacilityDetails.StreetAddress.Length);
        Assert.Equal(150, result.Value.FacilityDetails.Suburb.Length);
        Assert.Equal(150, result.Value.FacilityDetails.Owner.Length);
        Assert.Equal(150, result.Value.FacilityDetails.Operator.Length);
    }

    public void Dispose()
    {
    }
}