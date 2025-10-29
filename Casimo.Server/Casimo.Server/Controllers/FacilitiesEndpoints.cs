using Casimo.Server.Helpers;
using Casimo.Server.Services.Interfaces;
using Casimo.Shared.ApiModels.Facility;
using Casimo.Shared.ApiModels.FitForPurpose;
using Casimo.Shared.Constants;
using Casimo.Shared.Enums;
using Casimo.Shared.ResponseModels;
using Microsoft.AspNetCore.Mvc;

namespace Casimo.Server.Controllers;

/// <summary>
/// Static class containing endpoint configurations for facility management operations
/// Maps HTTP endpoints to service methods for facility retrieval and management
/// </summary>
public static class FacilitiesEndpoints
{
    /// <summary>
    /// Maps facility endpoints to the application
    /// Configures facility-related API routes with proper authorization requirements
    /// </summary>
    /// <param name="app">The endpoint route builder to configure</param>
    public static void AddFacilityEndpoints(this IEndpointRouteBuilder app)
    {
        // Create an endpoint group 
        RouteGroupBuilder facilitiesGroup = app.MapGroup("api/Facilities");

        // Get all of the facililities
        _ = facilitiesGroup.MapGet(
                "/All",
        async ([FromServices] IFacilityService facilitiesService,
            [FromQuery] int page,
            [FromQuery] int pageSize,
            [FromQuery] string? nameFilter,
            [FromQuery] string? orderby,
            [FromQuery] SortDirectionEnum? order,
            HttpContext httpContext) =>
                {
                    if (page <= 0)
                        page = 1;

                    order ??= SortDirectionEnum.Asc;

                    Result<PagedResponse<FacilityListItemDto>> facilitiesResult = await facilitiesService
                        .GetAllFacilities(httpContext, page, pageSize, nameFilter, orderby, order.Value);

                    return EndpointsHelper.ProcessResult(facilitiesResult, "An Error occured while loading facilities");
                })
            .RequireAuthorization();

        // Get a specific facility by its ID
        _ = facilitiesGroup.MapGet(
                "/{facilityId}",
        async (
            [FromServices] IFacilityService facilitiesService,
            [FromRoute] int facilityId) =>
                {
                    if (facilityId is 0)
                        return Results.BadRequest("Invalid facility id");

                    Result<FacilityDTO> res = await facilitiesService.GetFacility(facilityId);

                    return EndpointsHelper.ProcessResult(res, "An Error occured while loading facility details");
                })
            .RequireAuthorization();

        _ = facilitiesGroup.MapPost("",
        async (
            [FromServices] IFacilityService facilitiesService,
            [FromBody] FacilityDetailsDto req) =>
        {

            if (req is null)
                return Results.BadRequest("Invalid request body");

            if (req.FacilityId <= 0)
                return Results.BadRequest("Invalid facility id");

            if (req.SiteName is "" or null || req.StreetAddress is "" or null || req.Owner is "" or null || req.PostCode is < 0 or > 9999)
                return Results.BadRequest("Invalid request");

            Result<FacilityDTO> res = await facilitiesService.SaveFacilityDetails(req);

            return EndpointsHelper.ProcessResult(res, "An Error occurred while loading facility details");
        })
        .RequireAuthorization(PolicyConstants.AdminOnly);

        _ = facilitiesGroup.MapGet(
            "/LGAids",
            async ([FromServices] IFacilityService facilitiesService) =>
            {
                LGAidCounts[] lgaIdCounts = await facilitiesService.GetLgAids();
                return Results.Ok(lgaIdCounts);
            });

        _ = facilitiesGroup.MapGet(
            "/LGAid",
            async ([FromServices] IFacilityService facilitiesService, [FromQuery] string lgAid) =>
            {
                FacilityCoords[] lgaIdCounts = await facilitiesService.GetLgAidFacility(lgAid);
                return Results.Ok(lgaIdCounts);
            });
    }
}