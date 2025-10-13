using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Casimo.Data.CasimoDB;

public partial class CasimoDbContext : DbContext
{
    public CasimoDbContext()
    {
    }

    public CasimoDbContext(DbContextOptions<CasimoDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BoundariesImportFormatted> BoundariesImportFormatteds { get; set; }

    public virtual DbSet<TblAccessType> TblAccessTypes { get; set; }

    public virtual DbSet<TblAcecqaLga> TblAcecqaLgae { get; set; }

    public virtual DbSet<TblAcecqaforecastArea> TblAcecqaforecastAreas { get; set; }

    public virtual DbSet<TblAcecqaregister> TblAcecqaregisters { get; set; }

    public virtual DbSet<TblAgeRange> TblAgeRanges { get; set; }

    public virtual DbSet<TblAggrBoundary> TblAggrBoundaries { get; set; }

    public virtual DbSet<TblAggrBoundaryForecastArea> TblAggrBoundaryForecastAreas { get; set; }

    public virtual DbSet<TblAltInfType> TblAltInfTypes { get; set; }

    public virtual DbSet<TblAssessmentList> TblAssessmentLists { get; set; }

    public virtual DbSet<TblAssessmentListAssessment> TblAssessmentListAssessments { get; set; }

    public virtual DbSet<TblAssessmentStatus> TblAssessmentStatuses { get; set; }

    public virtual DbSet<TblAsset> TblAssets { get; set; }

    public virtual DbSet<TblAssetCondition> TblAssetConditions { get; set; }

    public virtual DbSet<TblAttribute> TblAttributes { get; set; }

    public virtual DbSet<TblAttributeExampleAttribute> TblAttributeExampleAttributes { get; set; }

    public virtual DbSet<TblAttributeExampleName> TblAttributeExampleNames { get; set; }

    public virtual DbSet<TblAttributeName> TblAttributeNames { get; set; }

    public virtual DbSet<TblBoundariesWorkerZone> TblBoundariesWorkerZones { get; set; }

    public virtual DbSet<TblBoundary> TblBoundaries { get; set; }

    public virtual DbSet<TblBoundaryType> TblBoundaryTypes { get; set; }

    public virtual DbSet<TblCasimoFacilitiesUse> TblCasimoFacilitiesUses { get; set; }

    public virtual DbSet<TblCasimoFacilitiesUsesQuantity> TblCasimoFacilitiesUsesQuantities { get; set; }

    public virtual DbSet<TblCasimoFacility> TblCasimoFacilities { get; set; }

    public virtual DbSet<TblCasimoQuantityAsstComparisonArea> TblCasimoQuantityAsstComparisonAreas { get; set; }

    public virtual DbSet<TblCasimoQuantityAsstForecastArea> TblCasimoQuantityAsstForecastAreas { get; set; }

    public virtual DbSet<TblCasimoQuantityAsstStandard> TblCasimoQuantityAsstStandards { get; set; }

    public virtual DbSet<TblCasimoSuitabilityAsstOverallScore> TblCasimoSuitabilityAsstOverallScores { get; set; }

    public virtual DbSet<TblCasimoSuitabilityAsstQuestionResponse> TblCasimoSuitabilityAsstQuestionResponses { get; set; }

    public virtual DbSet<TblCasimoSuitabilityAsstSectionResponse> TblCasimoSuitabilityAsstSectionResponses { get; set; }

    public virtual DbSet<TblCohort> TblCohorts { get; set; }

    public virtual DbSet<TblCohortType> TblCohortTypes { get; set; }

    public virtual DbSet<TblCriticalityType> TblCriticalityTypes { get; set; }

    public virtual DbSet<TblCustomUseGroup> TblCustomUseGroups { get; set; }

    public virtual DbSet<TblCustomUseGroupId> TblCustomUseGroupIds { get; set; }

    public virtual DbSet<TblDevTestTable> TblDevTestTables { get; set; }

    public virtual DbSet<TblExportList> TblExportLists { get; set; }

    public virtual DbSet<TblFacilitiesForecastArea> TblFacilitiesForecastAreas { get; set; }

    public virtual DbSet<TblFacilitiesPoint> TblFacilitiesPoints { get; set; }

    public virtual DbSet<TblFacilitiesSa2> TblFacilitiesSa2s { get; set; }

    public virtual DbSet<TblFacility> TblFacilities { get; set; }

    public virtual DbSet<TblFacilityFilterVal> TblFacilityFilterVals { get; set; }

    public virtual DbSet<TblFacilitySortVal> TblFacilitySortVals { get; set; }

    public virtual DbSet<TblFacilityStatus> TblFacilityStatuses { get; set; }

    public virtual DbSet<TblFfpDraftTemplateQuestion> TblFfpDraftTemplateQuestions { get; set; }

    public virtual DbSet<TblFfpDraftTemplateSection> TblFfpDraftTemplateSections { get; set; }

    public virtual DbSet<TblFfpDraftTemplateTitle> TblFfpDraftTemplateTitles { get; set; }

    public virtual DbSet<TblFfpassessmentScheme> TblFfpassessmentSchemes { get; set; }

    public virtual DbSet<TblFfpasstLog> TblFfpasstLogs { get; set; }

    public virtual DbSet<TblFfpasstQuestionResponse> TblFfpasstQuestionResponses { get; set; }

    public virtual DbSet<TblFfpasstSectionResponse> TblFfpasstSectionResponses { get; set; }

    public virtual DbSet<TblFfpasstSelection> TblFfpasstSelections { get; set; }

    public virtual DbSet<TblFfpcommentType> TblFfpcommentTypes { get; set; }

    public virtual DbSet<TblFfpscoreSysOverride> TblFfpscoreSysOverrides { get; set; }

    public virtual DbSet<TblFfpscoreSysRange> TblFfpscoreSysRanges { get; set; }

    public virtual DbSet<TblFfpscoreSysScore> TblFfpscoreSysScores { get; set; }

    public virtual DbSet<TblFfpscoreSysTitle> TblFfpscoreSysTitles { get; set; }

    public virtual DbSet<TblFfptemplateQuestion> TblFfptemplateQuestions { get; set; }

    public virtual DbSet<TblFfptemplateSection> TblFfptemplateSections { get; set; }

    public virtual DbSet<TblFfptemplateTitle> TblFfptemplateTitles { get; set; }

    public virtual DbSet<TblFfptemplatesByInfType> TblFfptemplatesByInfTypes { get; set; }

    public virtual DbSet<TblForecastAreasCopy> TblForecastAreasCopies { get; set; }

    public virtual DbSet<TblHierarchy> TblHierarchies { get; set; }

    public virtual DbSet<TblHierarchyExampleLevel> TblHierarchyExampleLevels { get; set; }

    public virtual DbSet<TblHierarchyExampleName> TblHierarchyExampleNames { get; set; }

    public virtual DbSet<TblHierarchyLevel> TblHierarchyLevels { get; set; }

    public virtual DbSet<TblHierarchyName> TblHierarchyNames { get; set; }

    public virtual DbSet<TblInfClass> TblInfClasses { get; set; }

    public virtual DbSet<TblInfGroup> TblInfGroups { get; set; }

    public virtual DbSet<TblInfType> TblInfTypes { get; set; }

    public virtual DbSet<TblInfTypeCohort> TblInfTypeCohorts { get; set; }

    public virtual DbSet<TblInfTypeHierarchyAttribute> TblInfTypeHierarchyAttributes { get; set; }

    public virtual DbSet<TblInfTypeUnit> TblInfTypeUnits { get; set; }

    public virtual DbSet<TblIntersectingForecastArea> TblIntersectingForecastAreas { get; set; }

    public virtual DbSet<TblKinderLdcmodelDefaultConstant> TblKinderLdcmodelDefaultConstants { get; set; }

    public virtual DbSet<TblKinderLdcmodelDefaultVariable> TblKinderLdcmodelDefaultVariables { get; set; }

    public virtual DbSet<TblKinderLdcmodelGlobalAssumptionsDelete> TblKinderLdcmodelGlobalAssumptionsDeletes { get; set; }

    public virtual DbSet<TblKinderLdcmodelInclFacility> TblKinderLdcmodelInclFacilities { get; set; }

    public virtual DbSet<TblKinderLdcmodelInclForecastArea> TblKinderLdcmodelInclForecastAreas { get; set; }

    public virtual DbSet<TblKinderLdcmodelInclSa2> TblKinderLdcmodelInclSa2s { get; set; }

    public virtual DbSet<TblKinderLdcmodelKispdatum> TblKinderLdcmodelKispdata { get; set; }

    public virtual DbSet<TblKinderLdcmodelServiceDataSharing> TblKinderLdcmodelServiceDataSharings { get; set; }

    public virtual DbSet<TblKinderLdcmodelServiceDatum> TblKinderLdcmodelServiceData { get; set; }

    public virtual DbSet<TblKinderLdcmodelUserConstant> TblKinderLdcmodelUserConstants { get; set; }

    public virtual DbSet<TblKinderLdcmodelUserVariable> TblKinderLdcmodelUserVariables { get; set; }

    public virtual DbSet<TblLga> TblLgas { get; set; }

    public virtual DbSet<TblLgacriticality> TblLgacriticalities { get; set; }

    public virtual DbSet<TblLgaresponsibility> TblLgaresponsibilities { get; set; }

    public virtual DbSet<TblLocalitiesForecastArea> TblLocalitiesForecastAreas { get; set; }

    public virtual DbSet<TblLocalitiesLga> TblLocalitiesLgas { get; set; }

    public virtual DbSet<TblMainMenuItem> TblMainMenuItems { get; set; }

    public virtual DbSet<TblNonResDemandProportionRate> TblNonResDemandProportionRates { get; set; }

    public virtual DbSet<TblOperator> TblOperators { get; set; }

    public virtual DbSet<TblOwner> TblOwners { get; set; }

    public virtual DbSet<TblPermissionType> TblPermissionTypes { get; set; }

    public virtual DbSet<TblPlanYearsDistinct> TblPlanYearsDistincts { get; set; }

    public virtual DbSet<TblPlanYr> TblPlanYrs { get; set; }

    public virtual DbSet<TblPlanYrTitle> TblPlanYrTitles { get; set; }

    public virtual DbSet<TblPopRatioStd> TblPopRatioStds { get; set; }

    public virtual DbSet<TblPopRatioStdsInfType> TblPopRatioStdsInfTypes { get; set; }

    public virtual DbSet<TblPostcode> TblPostcodes { get; set; }

    public virtual DbSet<TblQtyAssessmentStd> TblQtyAssessmentStds { get; set; }

    public virtual DbSet<TblQtyAssessmentStdsId> TblQtyAssessmentStdsIds { get; set; }

    public virtual DbSet<TblResPopSa2SingleYr> TblResPopSa2SingleYrs { get; set; }

    public virtual DbSet<TblResPopSingleYr> TblResPopSingleYrs { get; set; }

    public virtual DbSet<TblResPopSingleYrsArchive> TblResPopSingleYrsArchives { get; set; }

    public virtual DbSet<TblResponsibilityType> TblResponsibilityTypes { get; set; }

    public virtual DbSet<TblSa2Lga> TblSa2Lgas { get; set; }

    public virtual DbSet<TblService> TblServices { get; set; }

    public virtual DbSet<TblServiceOwner> TblServiceOwners { get; set; }

    public virtual DbSet<TblServiceUnitQuantity> TblServiceUnitQuantities { get; set; }

    public virtual DbSet<TblSettlementPostcode> TblSettlementPostcodes { get; set; }

    public virtual DbSet<TblSubSpace> TblSubSpaces { get; set; }

    public virtual DbSet<TblToolTip> TblToolTips { get; set; }

    public virtual DbSet<TblTravelPropensity> TblTravelPropensities { get; set; }

    public virtual DbSet<TblTypologyLog> TblTypologyLogs { get; set; }

    public virtual DbSet<TblUnitType> TblUnitTypes { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    public virtual DbSet<TblUserAssignedAssessmentList> TblUserAssignedAssessmentLists { get; set; }

    public virtual DbSet<TblUserInterest> TblUserInterests { get; set; }

    public virtual DbSet<TblUserPermission> TblUserPermissions { get; set; }

    public virtual DbSet<TblUserSqllogin> TblUserSqllogins { get; set; }

    public virtual DbSet<TblUtilAssessmentType> TblUtilAssessmentTypes { get; set; }

    public virtual DbSet<TblUtilAsstLog> TblUtilAsstLogs { get; set; }

    public virtual DbSet<TblUtilCapacityHourlyUse> TblUtilCapacityHourlyUses { get; set; }

    public virtual DbSet<TblUtilCapacityTemplateType> TblUtilCapacityTemplateTypes { get; set; }

    public virtual DbSet<TblUtilCapacityTemplatesByInfType> TblUtilCapacityTemplatesByInfTypes { get; set; }

    public virtual DbSet<TblUtilDurationFormat> TblUtilDurationFormats { get; set; }

    public virtual DbSet<TblUtilHourlyBookingDatum> TblUtilHourlyBookingData { get; set; }

    public virtual DbSet<TblUtilResultsByDayHourlyPatternBySlotCode> TblUtilResultsByDayHourlyPatternBySlotCodes { get; set; }

    public virtual DbSet<TblUtilResultsPcbyDay> TblUtilResultsPcbyDays { get; set; }

    public virtual DbSet<TblUtilTimeCode> TblUtilTimeCodes { get; set; }

    public virtual DbSet<TblUtilTimePeriodsByLga> TblUtilTimePeriodsByLgas { get; set; }

    public virtual DbSet<TblUtilUtilTemplateType> TblUtilUtilTemplateTypes { get; set; }

    public virtual DbSet<TblWeekday> TblWeekdays { get; set; }

    public virtual DbSet<TblWorkerZonesForecastArea> TblWorkerZonesForecastAreas { get; set; }

    public virtual DbSet<TblWorkersByTravelZone> TblWorkersByTravelZones { get; set; }

    public virtual DbSet<TblWorkersByWorkerZone> TblWorkersByWorkerZones { get; set; }

    public virtual DbSet<TblWorkersSplitTzntoWorkerZone> TblWorkersSplitTzntoWorkerZones { get; set; }

    public virtual DbSet<TbltmpGeccscopeId> TbltmpGeccscopeIds { get; set; }

    public virtual DbSet<TbltmpSa2copy> TbltmpSa2copies { get; set; }

    public virtual DbSet<TbltmpSa2copyKisp> TbltmpSa2copyKisps { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears0> TmptblGetRatiosAggregatedAllYears0s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears104> TmptblGetRatiosAggregatedAllYears104s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears105> TmptblGetRatiosAggregatedAllYears105s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears107> TmptblGetRatiosAggregatedAllYears107s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears109> TmptblGetRatiosAggregatedAllYears109s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears110> TmptblGetRatiosAggregatedAllYears110s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears18> TmptblGetRatiosAggregatedAllYears18s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears21> TmptblGetRatiosAggregatedAllYears21s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears24> TmptblGetRatiosAggregatedAllYears24s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears27> TmptblGetRatiosAggregatedAllYears27s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears28> TmptblGetRatiosAggregatedAllYears28s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears31> TmptblGetRatiosAggregatedAllYears31s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears33> TmptblGetRatiosAggregatedAllYears33s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears37> TmptblGetRatiosAggregatedAllYears37s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears38> TmptblGetRatiosAggregatedAllYears38s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears40> TmptblGetRatiosAggregatedAllYears40s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears41> TmptblGetRatiosAggregatedAllYears41s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears46> TmptblGetRatiosAggregatedAllYears46s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears47> TmptblGetRatiosAggregatedAllYears47s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears49> TmptblGetRatiosAggregatedAllYears49s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears53> TmptblGetRatiosAggregatedAllYears53s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears54> TmptblGetRatiosAggregatedAllYears54s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears55> TmptblGetRatiosAggregatedAllYears55s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears56> TmptblGetRatiosAggregatedAllYears56s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears57> TmptblGetRatiosAggregatedAllYears57s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears6> TmptblGetRatiosAggregatedAllYears6s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears61> TmptblGetRatiosAggregatedAllYears61s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears62> TmptblGetRatiosAggregatedAllYears62s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears63> TmptblGetRatiosAggregatedAllYears63s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears64> TmptblGetRatiosAggregatedAllYears64s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears68> TmptblGetRatiosAggregatedAllYears68s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears69> TmptblGetRatiosAggregatedAllYears69s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears70> TmptblGetRatiosAggregatedAllYears70s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears82> TmptblGetRatiosAggregatedAllYears82s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears84> TmptblGetRatiosAggregatedAllYears84s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears88> TmptblGetRatiosAggregatedAllYears88s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears89> TmptblGetRatiosAggregatedAllYears89s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears90> TmptblGetRatiosAggregatedAllYears90s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears91> TmptblGetRatiosAggregatedAllYears91s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears92> TmptblGetRatiosAggregatedAllYears92s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears94> TmptblGetRatiosAggregatedAllYears94s { get; set; }

    public virtual DbSet<TmptblGetRatiosAggregatedAllYears95> TmptblGetRatiosAggregatedAllYears95s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears0> TmptblGetRatiosForecastAllYears0s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears101> TmptblGetRatiosForecastAllYears101s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears102> TmptblGetRatiosForecastAllYears102s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears104> TmptblGetRatiosForecastAllYears104s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears105> TmptblGetRatiosForecastAllYears105s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears106> TmptblGetRatiosForecastAllYears106s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears107> TmptblGetRatiosForecastAllYears107s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears109> TmptblGetRatiosForecastAllYears109s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears110> TmptblGetRatiosForecastAllYears110s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears18> TmptblGetRatiosForecastAllYears18s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears24> TmptblGetRatiosForecastAllYears24s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears27> TmptblGetRatiosForecastAllYears27s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears28> TmptblGetRatiosForecastAllYears28s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears31> TmptblGetRatiosForecastAllYears31s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears33> TmptblGetRatiosForecastAllYears33s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears37> TmptblGetRatiosForecastAllYears37s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears38> TmptblGetRatiosForecastAllYears38s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears40> TmptblGetRatiosForecastAllYears40s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears41> TmptblGetRatiosForecastAllYears41s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears42> TmptblGetRatiosForecastAllYears42s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears43> TmptblGetRatiosForecastAllYears43s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears44> TmptblGetRatiosForecastAllYears44s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears46> TmptblGetRatiosForecastAllYears46s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears47> TmptblGetRatiosForecastAllYears47s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears48> TmptblGetRatiosForecastAllYears48s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears49> TmptblGetRatiosForecastAllYears49s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears53> TmptblGetRatiosForecastAllYears53s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears54> TmptblGetRatiosForecastAllYears54s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears55> TmptblGetRatiosForecastAllYears55s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears56> TmptblGetRatiosForecastAllYears56s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears57> TmptblGetRatiosForecastAllYears57s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears58> TmptblGetRatiosForecastAllYears58s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears59> TmptblGetRatiosForecastAllYears59s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears6> TmptblGetRatiosForecastAllYears6s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears61> TmptblGetRatiosForecastAllYears61s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears62> TmptblGetRatiosForecastAllYears62s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears63> TmptblGetRatiosForecastAllYears63s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears64> TmptblGetRatiosForecastAllYears64s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears68> TmptblGetRatiosForecastAllYears68s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears69> TmptblGetRatiosForecastAllYears69s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears70> TmptblGetRatiosForecastAllYears70s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears74> TmptblGetRatiosForecastAllYears74s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears75> TmptblGetRatiosForecastAllYears75s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears76> TmptblGetRatiosForecastAllYears76s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears80> TmptblGetRatiosForecastAllYears80s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears82> TmptblGetRatiosForecastAllYears82s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears83> TmptblGetRatiosForecastAllYears83s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears84> TmptblGetRatiosForecastAllYears84s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears88> TmptblGetRatiosForecastAllYears88s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears89> TmptblGetRatiosForecastAllYears89s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears90> TmptblGetRatiosForecastAllYears90s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears91> TmptblGetRatiosForecastAllYears91s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears92> TmptblGetRatiosForecastAllYears92s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears94> TmptblGetRatiosForecastAllYears94s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears95> TmptblGetRatiosForecastAllYears95s { get; set; }

    public virtual DbSet<TmptblGetRatiosForecastAllYears999> TmptblGetRatiosForecastAllYears999s { get; set; }

    public virtual DbSet<TmptblPopulationForecastByCohortAndYear> TmptblPopulationForecastByCohortAndYears { get; set; }

    public virtual DbSet<TmptblResidentPopulationByAggregatedArea> TmptblResidentPopulationByAggregatedAreas { get; set; }

    public virtual DbSet<VwAaaRctestKispSa2> VwAaaRctestKispSa2s { get; set; }

    public virtual DbSet<VwAcecqaregisterByLga> VwAcecqaregisterByLgas { get; set; }

    public virtual DbSet<VwAggregatedAreaAllCombination> VwAggregatedAreaAllCombinations { get; set; }

    public virtual DbSet<VwAggregatedAreaWithForcastArea> VwAggregatedAreaWithForcastAreas { get; set; }

    public virtual DbSet<VwAggregatedAreasDistinct> VwAggregatedAreasDistincts { get; set; }

    public virtual DbSet<VwAggregatedComponentForecastArea> VwAggregatedComponentForecastAreas { get; set; }

    public virtual DbSet<VwAssetCondition> VwAssetConditions { get; set; }

    public virtual DbSet<VwAssetConditionConcatenated> VwAssetConditionConcatenateds { get; set; }

    public virtual DbSet<VwAssetsByFacility> VwAssetsByFacilities { get; set; }

    public virtual DbSet<VwAssetsConcatenatedByFacility> VwAssetsConcatenatedByFacilities { get; set; }

    public virtual DbSet<VwBenchmarkingComparisonRatio> VwBenchmarkingComparisonRatios { get; set; }

    public virtual DbSet<VwBenchmarkingCurrentRatio> VwBenchmarkingCurrentRatios { get; set; }

    public virtual DbSet<VwBenchmarkingTest1> VwBenchmarkingTest1s { get; set; }

    public virtual DbSet<VwBoundariesForecastArea> VwBoundariesForecastAreas { get; set; }

    public virtual DbSet<VwCustomUseGroupByLga> VwCustomUseGroupByLgas { get; set; }

    public virtual DbSet<VwCustomUseGroupsByService> VwCustomUseGroupsByServices { get; set; }

    public virtual DbSet<VwCustomUseGroupsByServiceConcatenated> VwCustomUseGroupsByServiceConcatenateds { get; set; }

    public virtual DbSet<VwCustomUseGroupsConcatenated> VwCustomUseGroupsConcatenateds { get; set; }

    public virtual DbSet<VwDevTestRc> VwDevTestRcs { get; set; }

    public virtual DbSet<VwFacilitiesRelatedUsesForGi> VwFacilitiesRelatedUsesForGis { get; set; }

    public virtual DbSet<VwFacilitiesUsesQuantitiesForGi> VwFacilitiesUsesQuantitiesForGis { get; set; }

    public virtual DbSet<VwFacilityDateLastUpdated> VwFacilityDateLastUpdateds { get; set; }

    public virtual DbSet<VwFacilityDateLastUpdatedBaseQ> VwFacilityDateLastUpdatedBaseQs { get; set; }

    public virtual DbSet<VwFfpasstOverallScoreBaseQQn> VwFfpasstOverallScoreBaseQQns { get; set; }

    public virtual DbSet<VwFfpasstOverallScoreBaseQSec> VwFfpasstOverallScoreBaseQSecs { get; set; }

    public virtual DbSet<VwFfpasstOverallScoreFinal> VwFfpasstOverallScoreFinals { get; set; }

    public virtual DbSet<VwFfpasstOverallScoreSecWtAvgStep0> VwFfpasstOverallScoreSecWtAvgStep0s { get; set; }

    public virtual DbSet<VwFfpasstOverallScoreSecWtAvgStep1> VwFfpasstOverallScoreSecWtAvgStep1s { get; set; }

    public virtual DbSet<VwFfpasstOverallScoreStep0> VwFfpasstOverallScoreStep0s { get; set; }

    public virtual DbSet<VwFfpasstOverallScoreStep1> VwFfpasstOverallScoreStep1s { get; set; }

    public virtual DbSet<VwFfpasstOverallScoreSubQDynamic> VwFfpasstOverallScoreSubQDynamics { get; set; }

    public virtual DbSet<VwFfpasstOverallScoreSubQQnAvg> VwFfpasstOverallScoreSubQQnAvgs { get; set; }

    public virtual DbSet<VwFfpasstOverallScoreSubQQnSum> VwFfpasstOverallScoreSubQQnSums { get; set; }

    public virtual DbSet<VwFfpasstOverallScoreSubQSecAvg> VwFfpasstOverallScoreSubQSecAvgs { get; set; }

    public virtual DbSet<VwFfpasstOverallScoreSubQSecAvgTodelete> VwFfpasstOverallScoreSubQSecAvgTodeletes { get; set; }

    public virtual DbSet<VwFfpasstOverallScoreSubQSecSum> VwFfpasstOverallScoreSubQSecSums { get; set; }

    public virtual DbSet<VwFfpasstOverallScoreSubQSecWtAvg> VwFfpasstOverallScoreSubQSecWtAvgs { get; set; }

    public virtual DbSet<VwFfpasstOverallScoreSubQSecWtAvgStep0> VwFfpasstOverallScoreSubQSecWtAvgStep0s { get; set; }

    public virtual DbSet<VwFfpasstOverallScoreSubQSecWtAvgTodelete> VwFfpasstOverallScoreSubQSecWtAvgTodeletes { get; set; }

    public virtual DbSet<VwFfpasstSectionScoresRangeText> VwFfpasstSectionScoresRangeTexts { get; set; }

    public virtual DbSet<VwFfpresultsOverallScore> VwFfpresultsOverallScores { get; set; }

    public virtual DbSet<VwFfpscoreSysScoreMin> VwFfpscoreSysScoreMins { get; set; }

    public virtual DbSet<VwFlaggedRecord> VwFlaggedRecords { get; set; }

    public virtual DbSet<VwFlaggedRecordsAttribute1> VwFlaggedRecordsAttribute1s { get; set; }

    public virtual DbSet<VwFlaggedRecordsAttribute2> VwFlaggedRecordsAttribute2s { get; set; }

    public virtual DbSet<VwFlaggedRecordsHierarchy> VwFlaggedRecordsHierarchies { get; set; }

    public virtual DbSet<VwFlaggedRecordsUnitQuantity> VwFlaggedRecordsUnitQuantities { get; set; }

    public virtual DbSet<VwForecastAreaAllCombination> VwForecastAreaAllCombinations { get; set; }

    public virtual DbSet<VwForecastAreaBoundaryDistinct> VwForecastAreaBoundaryDistincts { get; set; }

    public virtual DbSet<VwForecastAreasDistinct> VwForecastAreasDistincts { get; set; }

    public virtual DbSet<VwFrTableViewMasterQry> VwFrTableViewMasterQries { get; set; }

    public virtual DbSet<VwFrTableViewMasterQryStep0> VwFrTableViewMasterQryStep0s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears0> VwGetRatiosAggregatedAllYears0s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears104> VwGetRatiosAggregatedAllYears104s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears105> VwGetRatiosAggregatedAllYears105s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears107> VwGetRatiosAggregatedAllYears107s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears109> VwGetRatiosAggregatedAllYears109s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears110> VwGetRatiosAggregatedAllYears110s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears18> VwGetRatiosAggregatedAllYears18s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears24> VwGetRatiosAggregatedAllYears24s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears27> VwGetRatiosAggregatedAllYears27s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears28> VwGetRatiosAggregatedAllYears28s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears31> VwGetRatiosAggregatedAllYears31s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears33> VwGetRatiosAggregatedAllYears33s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears37> VwGetRatiosAggregatedAllYears37s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears38> VwGetRatiosAggregatedAllYears38s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears40> VwGetRatiosAggregatedAllYears40s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears41> VwGetRatiosAggregatedAllYears41s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears46> VwGetRatiosAggregatedAllYears46s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears47> VwGetRatiosAggregatedAllYears47s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears49> VwGetRatiosAggregatedAllYears49s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears53> VwGetRatiosAggregatedAllYears53s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears54> VwGetRatiosAggregatedAllYears54s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears55> VwGetRatiosAggregatedAllYears55s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears56> VwGetRatiosAggregatedAllYears56s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears57> VwGetRatiosAggregatedAllYears57s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears6> VwGetRatiosAggregatedAllYears6s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears61> VwGetRatiosAggregatedAllYears61s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears62> VwGetRatiosAggregatedAllYears62s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears63> VwGetRatiosAggregatedAllYears63s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears64> VwGetRatiosAggregatedAllYears64s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears68> VwGetRatiosAggregatedAllYears68s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears69> VwGetRatiosAggregatedAllYears69s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears70> VwGetRatiosAggregatedAllYears70s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears82> VwGetRatiosAggregatedAllYears82s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears84> VwGetRatiosAggregatedAllYears84s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears88> VwGetRatiosAggregatedAllYears88s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears89> VwGetRatiosAggregatedAllYears89s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears90> VwGetRatiosAggregatedAllYears90s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears91> VwGetRatiosAggregatedAllYears91s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears92> VwGetRatiosAggregatedAllYears92s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears94> VwGetRatiosAggregatedAllYears94s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYears95> VwGetRatiosAggregatedAllYears95s { get; set; }

    public virtual DbSet<VwGetRatiosAggregatedAllYearsLgacopy> VwGetRatiosAggregatedAllYearsLgacopies { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears0> VwGetRatiosForecastAllYears0s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears101> VwGetRatiosForecastAllYears101s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears102> VwGetRatiosForecastAllYears102s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears104> VwGetRatiosForecastAllYears104s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears105> VwGetRatiosForecastAllYears105s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears106> VwGetRatiosForecastAllYears106s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears107> VwGetRatiosForecastAllYears107s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears109> VwGetRatiosForecastAllYears109s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears110> VwGetRatiosForecastAllYears110s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears18> VwGetRatiosForecastAllYears18s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears24> VwGetRatiosForecastAllYears24s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears27> VwGetRatiosForecastAllYears27s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears28> VwGetRatiosForecastAllYears28s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears31> VwGetRatiosForecastAllYears31s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears33> VwGetRatiosForecastAllYears33s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears37> VwGetRatiosForecastAllYears37s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears38> VwGetRatiosForecastAllYears38s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears40> VwGetRatiosForecastAllYears40s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears41> VwGetRatiosForecastAllYears41s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears42> VwGetRatiosForecastAllYears42s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears43> VwGetRatiosForecastAllYears43s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears44> VwGetRatiosForecastAllYears44s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears46> VwGetRatiosForecastAllYears46s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears47> VwGetRatiosForecastAllYears47s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears48> VwGetRatiosForecastAllYears48s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears49> VwGetRatiosForecastAllYears49s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears53> VwGetRatiosForecastAllYears53s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears54> VwGetRatiosForecastAllYears54s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears55> VwGetRatiosForecastAllYears55s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears56> VwGetRatiosForecastAllYears56s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears57> VwGetRatiosForecastAllYears57s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears58> VwGetRatiosForecastAllYears58s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears59> VwGetRatiosForecastAllYears59s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears6> VwGetRatiosForecastAllYears6s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears61> VwGetRatiosForecastAllYears61s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears62> VwGetRatiosForecastAllYears62s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears63> VwGetRatiosForecastAllYears63s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears64> VwGetRatiosForecastAllYears64s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears68> VwGetRatiosForecastAllYears68s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears69> VwGetRatiosForecastAllYears69s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears70> VwGetRatiosForecastAllYears70s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears74> VwGetRatiosForecastAllYears74s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears75> VwGetRatiosForecastAllYears75s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears76> VwGetRatiosForecastAllYears76s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears80> VwGetRatiosForecastAllYears80s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears82> VwGetRatiosForecastAllYears82s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears83> VwGetRatiosForecastAllYears83s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears84> VwGetRatiosForecastAllYears84s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears88> VwGetRatiosForecastAllYears88s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears89> VwGetRatiosForecastAllYears89s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears90> VwGetRatiosForecastAllYears90s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears91> VwGetRatiosForecastAllYears91s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears92> VwGetRatiosForecastAllYears92s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears94> VwGetRatiosForecastAllYears94s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears95> VwGetRatiosForecastAllYears95s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYears999> VwGetRatiosForecastAllYears999s { get; set; }

    public virtual DbSet<VwGetRatiosForecastAllYearsLgacopy> VwGetRatiosForecastAllYearsLgacopies { get; set; }

    public virtual DbSet<VwInfGroupClassTypeByLga> VwInfGroupClassTypeByLgas { get; set; }

    public virtual DbSet<VwInfGroupClassTypeByLgawithQtyStandard> VwInfGroupClassTypeByLgawithQtyStandards { get; set; }

    public virtual DbSet<VwInfGroupClassTypeWithLgacriticality> VwInfGroupClassTypeWithLgacriticalities { get; set; }

    public virtual DbSet<VwInfTypeByLga> VwInfTypeByLgas { get; set; }

    public virtual DbSet<VwInfTypeHierarchyAttributeCombination> VwInfTypeHierarchyAttributeCombinations { get; set; }

    public virtual DbSet<VwInfTypeHierarchyLevelsAttribute> VwInfTypeHierarchyLevelsAttributes { get; set; }

    public virtual DbSet<VwInfTypeUnit> VwInfTypeUnits { get; set; }

    public virtual DbSet<VwInfTypeUnitsByLga> VwInfTypeUnitsByLgas { get; set; }

    public virtual DbSet<VwInfTypeUnitsConcatenated> VwInfTypeUnitsConcatenateds { get; set; }

    public virtual DbSet<VwLgacopyCasimoFfpresultsOverallScore> VwLgacopyCasimoFfpresultsOverallScores { get; set; }

    public virtual DbSet<VwLgacopyCasimoFfpresultsOverallScoresTempbackup> VwLgacopyCasimoFfpresultsOverallScoresTempbackups { get; set; }

    public virtual DbSet<VwLgacopyCasimoFfpresultsQuestionResponse> VwLgacopyCasimoFfpresultsQuestionResponses { get; set; }

    public virtual DbSet<VwLgacopyCasimoFfpresultsSectionResponse> VwLgacopyCasimoFfpresultsSectionResponses { get; set; }

    public virtual DbSet<VwLgacopyCasimoFfpresultsSectionResponsesComboMethod> VwLgacopyCasimoFfpresultsSectionResponsesComboMethods { get; set; }

    public virtual DbSet<VwLgacopyCasimoQuantityAsstAggregatedArea> VwLgacopyCasimoQuantityAsstAggregatedAreas { get; set; }

    public virtual DbSet<VwLgacopyCasimoQuantityAsstForecastArea> VwLgacopyCasimoQuantityAsstForecastAreas { get; set; }

    public virtual DbSet<VwLgacopyCasimoQuantityAsstStandard> VwLgacopyCasimoQuantityAsstStandards { get; set; }

    public virtual DbSet<VwLgacopyCasimofacilitiesOld> VwLgacopyCasimofacilitiesOlds { get; set; }

    public virtual DbSet<VwLgacopyCasimofacilitiesUse> VwLgacopyCasimofacilitiesUses { get; set; }

    public virtual DbSet<VwLgacopyCasimofacilitiesUsesQuantity> VwLgacopyCasimofacilitiesUsesQuantities { get; set; }

    public virtual DbSet<VwLgacopyCasimofacility> VwLgacopyCasimofacilities { get; set; }

    public virtual DbSet<VwPlanYearsDistinct> VwPlanYearsDistincts { get; set; }

    public virtual DbSet<VwPopulationByAggregatedArea> VwPopulationByAggregatedAreas { get; set; }

    public virtual DbSet<VwPopulationByAggregatedAreaForAppend> VwPopulationByAggregatedAreaForAppends { get; set; }

    public virtual DbSet<VwPopulationByAggregatedForecastArea> VwPopulationByAggregatedForecastAreas { get; set; }

    public virtual DbSet<VwPopulationByAggregatedForecastAreaForAppend> VwPopulationByAggregatedForecastAreaForAppends { get; set; }

    public virtual DbSet<VwPopulationForecastByAgeAndYear> VwPopulationForecastByAgeAndYears { get; set; }

    public virtual DbSet<VwPopulationForecastByCohortAndYearCreateTbl> VwPopulationForecastByCohortAndYearCreateTbls { get; set; }

    public virtual DbSet<VwPopulationRecordsByAggregatedArea> VwPopulationRecordsByAggregatedAreas { get; set; }

    public virtual DbSet<VwPopulationRecordsByAggregatedAreaForAppend> VwPopulationRecordsByAggregatedAreaForAppends { get; set; }

    public virtual DbSet<VwPopulationRecordsByForecastArea> VwPopulationRecordsByForecastAreas { get; set; }

    public virtual DbSet<VwPopulationSumByAggregatedArea> VwPopulationSumByAggregatedAreas { get; set; }

    public virtual DbSet<VwPopulationSumByAggregatedAreaForAppend> VwPopulationSumByAggregatedAreaForAppends { get; set; }

    public virtual DbSet<VwPopulationSumByForecastArea> VwPopulationSumByForecastAreas { get; set; }

    public virtual DbSet<VwPopulationSumByForecastAreaForAppend> VwPopulationSumByForecastAreaForAppends { get; set; }

    public virtual DbSet<VwPublicUnitsByAggregatedArea> VwPublicUnitsByAggregatedAreas { get; set; }

    public virtual DbSet<VwPublicUnitsByForecastArea> VwPublicUnitsByForecastAreas { get; set; }

    public virtual DbSet<VwPublicUnitsByForecastArea1> VwPublicUnitsByForecastArea1s { get; set; }

    public virtual DbSet<VwPublicUnitsRecordsByAggregatedArea> VwPublicUnitsRecordsByAggregatedAreas { get; set; }

    public virtual DbSet<VwPublicUnitsRecordsByForecastArea> VwPublicUnitsRecordsByForecastAreas { get; set; }

    public virtual DbSet<VwPublicUnitsSumByAggregatedArea> VwPublicUnitsSumByAggregatedAreas { get; set; }

    public virtual DbSet<VwPublicUnitsSumByForecastArea> VwPublicUnitsSumByForecastAreas { get; set; }

    public virtual DbSet<VwPublicUnitsSumByForecastArea1> VwPublicUnitsSumByForecastArea1s { get; set; }

    public virtual DbSet<VwPublicUnitsSumByForecastAreaBkup> VwPublicUnitsSumByForecastAreaBkups { get; set; }

    public virtual DbSet<VwPublicUnitsSumByForecastAreaBkup05012023> VwPublicUnitsSumByForecastAreaBkup05012023s { get; set; }

    public virtual DbSet<VwQtyAssessmentStdWithId> VwQtyAssessmentStdWithIds { get; set; }

    public virtual DbSet<VwQtyAssessmentStdsId> VwQtyAssessmentStdsIds { get; set; }

    public virtual DbSet<VwQtyAssessmentStdsIdsConcatenated> VwQtyAssessmentStdsIdsConcatenateds { get; set; }

    public virtual DbSet<VwQtyStandard> VwQtyStandards { get; set; }

    public virtual DbSet<VwResPopSingleYrsByComparisonArea> VwResPopSingleYrsByComparisonAreas { get; set; }

    public virtual DbSet<VwResidentPopulationByAggregatedArea> VwResidentPopulationByAggregatedAreas { get; set; }

    public virtual DbSet<VwResidentPopulationByAggregatedAreaCreateTbl> VwResidentPopulationByAggregatedAreaCreateTbls { get; set; }

    public virtual DbSet<VwResidentPopulationByAggregatedForecastArea> VwResidentPopulationByAggregatedForecastAreas { get; set; }

    public virtual DbSet<VwResidentPopulationByForecastArea> VwResidentPopulationByForecastAreas { get; set; }

    public virtual DbSet<VwResidentTotalPopulationByAggregatedArea> VwResidentTotalPopulationByAggregatedAreas { get; set; }

    public virtual DbSet<VwResidentTotalPopulationByAggregatedForecastArea> VwResidentTotalPopulationByAggregatedForecastAreas { get; set; }

    public virtual DbSet<VwResidentTotalPopulationByForecastArea> VwResidentTotalPopulationByForecastAreas { get; set; }

    public virtual DbSet<VwServicesByLgaid> VwServicesByLgaids { get; set; }

    public virtual DbSet<VwSingleAssetsByFaciity> VwSingleAssetsByFaciities { get; set; }

    public virtual DbSet<VwSubFrmService> VwSubFrmServices { get; set; }

    public virtual DbSet<VwTestAggrByUserLive> VwTestAggrByUserLives { get; set; }

    public virtual DbSet<VwTestrc> VwTestrcs { get; set; }

    public virtual DbSet<VwUtilExportAvailableTargetHoursBySpace> VwUtilExportAvailableTargetHoursBySpaces { get; set; }

    public virtual DbSet<VwUtilExportBookingDataBySpace> VwUtilExportBookingDataBySpaces { get; set; }

    public virtual DbSet<VwUtilExportResultsBookingProfileBySpaceByTime> VwUtilExportResultsBookingProfileBySpaceByTimes { get; set; }

    public virtual DbSet<VwUtilExportResultsPercentHourlyBooking> VwUtilExportResultsPercentHourlyBookings { get; set; }

    public virtual DbSet<VwUtilExportResultsUniqueBookingId> VwUtilExportResultsUniqueBookingIds { get; set; }

    public virtual DbSet<VwUtilFrmUtilTableView> VwUtilFrmUtilTableViews { get; set; }

    public virtual DbSet<VwWorkerPopulationByAggregeatedArea> VwWorkerPopulationByAggregeatedAreas { get; set; }

    public virtual DbSet<VwWorkerPopulationByAggregeatedForecastArea> VwWorkerPopulationByAggregeatedForecastAreas { get; set; }

    public virtual DbSet<VwWorkerPopulationByForecastArea> VwWorkerPopulationByForecastAreas { get; set; }

    public virtual DbSet<VwfrmFacilityReg> VwfrmFacilityRegs { get; set; }

    public virtual DbSet<VwxlsFacilitiesAndRelatedUse> VwxlsFacilitiesAndRelatedUses { get; set; }

    public virtual DbSet<VwxlsFacilitiesRelatedUsesAndQuantity> VwxlsFacilitiesRelatedUsesAndQuantities { get; set; }

    public virtual DbSet<VwxlsPopulationStandard> VwxlsPopulationStandards { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AS");

        modelBuilder.Entity<BoundariesImportFormatted>(entity =>
        {
            entity.HasKey(e => e.RecordId)
                .HasName("PK__tblBound__FBDF78C99A85BD9F")
                .HasFillFactor(90);

            entity.ToTable("BoundariesImportFormatted");

            entity.Property(e => e.RecordId).HasColumnName("RecordID");
            entity.Property(e => e.BoundaryName).HasMaxLength(120);
            entity.Property(e => e.BoundaryTypeId).HasColumnName("BoundaryTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.Municipality).HasDefaultValue(false);
            entity.Property(e => e.OldBoundaryId).HasColumnName("OldBoundaryID");
            entity.Property(e => e.SmallArea).HasDefaultValue(false);
            entity.Property(e => e.StateCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.Suburb).HasDefaultValue(false);
        });

        modelBuilder.Entity<TblAccessType>(entity =>
        {
            entity.HasKey(e => e.AccessTypeId)
                .HasName("aaaaatblAccessType_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblAccessType", tb => tb.HasComment("Level of access to the facility by the general public"));

            entity.HasIndex(e => e.AccessType, "Access")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => e.Order, "OrderCode").HasFillFactor(90);

            entity.Property(e => e.AccessTypeId)
                .HasComment("Unique ID of the type of public access to each service")
                .HasColumnName("AccessTypeID");
            entity.Property(e => e.AccessType)
                .HasMaxLength(25)
                .HasComment("Public (free or paid access by general public), Limited (certain public), Private");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Order)
                .HasDefaultValue(0)
                .HasComment("Rank order for sorting and prioritisation purposes ('Public' = highest rank)");
        });

        modelBuilder.Entity<TblAcecqaLga>(entity =>
        {
            entity.HasKey(e => e.ServiceApprovalNumber);

            entity.ToTable("tblACECQA_LGA");

            entity.Property(e => e.ServiceApprovalNumber)
                .HasMaxLength(50)
                .HasColumnName("Service_Approval_Number");
            entity.Property(e => e.LgaBoundaryId).HasColumnName("LGA_BoundaryID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAID");
            entity.Property(e => e.Lganame)
                .HasMaxLength(120)
                .HasColumnName("LGAname");
            entity.Property(e => e.ServiceName)
                .HasMaxLength(150)
                .HasColumnName("Service_name");
        });

        modelBuilder.Entity<TblAcecqaforecastArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblACECQAforecastArea");

            entity.Property(e => e.ForecastAreaBoundaryId).HasColumnName("ForecastAreaBoundaryID");
            entity.Property(e => e.ForecastAreaBoundaryName).HasMaxLength(120);
            entity.Property(e => e.ForecastAreaLgaid)
                .HasMaxLength(4)
                .HasColumnName("ForecastAreaLGAID");
            entity.Property(e => e.ServiceApprovalNumber)
                .HasMaxLength(50)
                .HasColumnName("Service_Approval_Number");
            entity.Property(e => e.ServiceName)
                .HasMaxLength(150)
                .HasColumnName("Service_name");
        });

        modelBuilder.Entity<TblAcecqaregister>(entity =>
        {
            entity.HasKey(e => e.ServiceApprovalNumber);

            entity.ToTable("tblACECQAregister");

            entity.Property(e => e.ServiceApprovalNumber)
                .HasMaxLength(50)
                .HasColumnName("Service_Approval_Number");
            entity.Property(e => e.AfterSchoolCare)
                .HasMaxLength(10)
                .HasColumnName("After_school_care");
            entity.Property(e => e.AnyPreschool)
                .HasMaxLength(10)
                .HasColumnName("Any_preschool");
            entity.Property(e => e.AnyPreschoolOrLdc)
                .HasMaxLength(10)
                .HasColumnName("Any_preschool_or_LDC");
            entity.Property(e => e.ApprovedPlaces).HasColumnName("Approved_Places");
            entity.Property(e => e.BeforeSchoolCare)
                .HasMaxLength(10)
                .HasColumnName("Before_school_care");
            entity.Property(e => e.LgaNameAbs)
                .HasMaxLength(50)
                .HasColumnName("LGA_name_ABS");
            entity.Property(e => e.LgaNameShort)
                .HasMaxLength(50)
                .HasColumnName("LGA__name_short");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(10)
                .HasColumnName("LGAid");
            entity.Property(e => e.LongDayCare)
                .HasMaxLength(10)
                .HasColumnName("Long_Day_Care");
            entity.Property(e => e.PreschoolPartOfSchool)
                .HasMaxLength(10)
                .HasColumnName("Preschool_part_of_school");
            entity.Property(e => e.PreschoolStandAlone)
                .HasMaxLength(10)
                .HasColumnName("Preschool_stand_alone");
            entity.Property(e => e.ProviderApprovalNumber)
                .HasMaxLength(50)
                .HasColumnName("Provider_Approval_Number");
            entity.Property(e => e.ProviderName)
                .HasMaxLength(150)
                .HasColumnName("Provider_Name");
            entity.Property(e => e.ServiceAddress)
                .HasMaxLength(100)
                .HasColumnName("Service_Address");
            entity.Property(e => e.ServiceName)
                .HasMaxLength(150)
                .HasColumnName("Service_Name");
            entity.Property(e => e.ServiceType)
                .HasMaxLength(50)
                .HasColumnName("Service_Type");
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.Suburb).HasMaxLength(50);
            entity.Property(e => e.VacationCare)
                .HasMaxLength(10)
                .HasColumnName("Vacation_care");
            entity.Property(e => e.XLongitude)
                .HasDefaultValue(0.0)
                .HasColumnName("X_longitude");
            entity.Property(e => e.YLatitude)
                .HasDefaultValue(0.0)
                .HasColumnName("Y_latitude");
        });

        modelBuilder.Entity<TblAgeRange>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("aaaaatblAgeRanges_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblAgeRanges");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AgeHigh).HasDefaultValue(0);
            entity.Property(e => e.AgeLow).HasDefaultValue(0);
            entity.Property(e => e.CohortId)
                .HasDefaultValue(0)
                .HasColumnName("CohortID");

            entity.HasOne(d => d.Cohort).WithMany(p => p.TblAgeRanges)
                .HasForeignKey(d => d.CohortId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("tblAgeRanges_FK00");
        });

        modelBuilder.Entity<TblAggrBoundary>(entity =>
        {
            entity.HasKey(e => e.AggrBoundaryId)
                .HasName("aaaaatblAggrBoundaries_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblAggrBoundaries");

            entity.HasIndex(e => e.UserLgaid, "IX_tblAggrBoundaries").HasFillFactor(90);

            entity.Property(e => e.AggrBoundaryId)
                .HasComment("Unique ID of relationship between aggregated and component boundaries")
                .HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AddedBy).HasMaxLength(100);
            entity.Property(e => e.AddedTime).HasColumnType("datetime");
            entity.Property(e => e.AggrBoundaryName)
                .HasMaxLength(150)
                .HasComment("Name of the aggregated boundary");
            entity.Property(e => e.ChangedBy).HasMaxLength(100);
            entity.Property(e => e.ChangedTime).HasColumnType("datetime");
            entity.Property(e => e.CommonYearFrom).HasDefaultValue(0);
            entity.Property(e => e.CommonYearTo).HasDefaultValue(0);
            entity.Property(e => e.LockedBy).HasMaxLength(100);
            entity.Property(e => e.LockedTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserLgaid)
                .HasMaxLength(4)
                .HasComment("ID of the user who has defined these aggrgated areas")
                .HasColumnName("UserLGAid");
        });

        modelBuilder.Entity<TblAggrBoundaryForecastArea>(entity =>
        {
            entity.HasKey(e => e.AggrBoundaryForecastAreaId)
                .HasName("PK_AggrBoundaryForecastAreas")
                .HasFillFactor(90);

            entity.ToTable("tblAggrBoundaryForecastAreas");

            entity.HasIndex(e => e.AggrBoundaryId, "IX_tblAggrBoundaryForecastAreas").HasFillFactor(90);

            entity.HasIndex(e => e.ForecastAreaBoundaryId, "IX_tblAggrBoundaryForecastAreas_1").HasFillFactor(90);

            entity.Property(e => e.AggrBoundaryForecastAreaId).HasColumnName("AggrBoundaryForecastAreaID");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.ForecastAreaBoundaryId).HasColumnName("ForecastAreaBoundaryID");
        });

        modelBuilder.Entity<TblAltInfType>(entity =>
        {
            entity.HasKey(e => e.AltInfTypeId)
                .HasName("aaaaatblAltInfTypes_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblAltInfTypes");

            entity.HasIndex(e => e.AltInfTypeId, "ID").HasFillFactor(90);

            entity.HasIndex(e => e.InfTypeId, "InfTypeID").HasFillFactor(90);

            entity.HasIndex(e => e.UserId, "LGAid").HasFillFactor(90);

            entity.HasIndex(e => e.LocalName, "LocalName").HasFillFactor(90);

            entity.HasIndex(e => e.InfTypeId, "tblInfTypetblAltInfTypes").HasFillFactor(90);

            entity.HasIndex(e => e.UserId, "tblUserstblAltInfTypes").HasFillFactor(90);

            entity.Property(e => e.AltInfTypeId)
                .HasComment("Unique ID of relationship between InfTypeID and alternative user-defined 'LocalName'")
                .HasColumnName("AltInfTypeID");
            entity.Property(e => e.InfTypeId)
                .HasDefaultValue(0)
                .HasComment("InfType ID used by this database")
                .HasColumnName("InfTypeID");
            entity.Property(e => e.LocalName)
                .HasMaxLength(100)
                .HasComment("Alternative name of the infrastructure type (defined by the user)");
            entity.Property(e => e.UserId)
                .HasComment("Lookup to tblUsers")
                .HasColumnName("UserID");

            entity.HasOne(d => d.InfType).WithMany(p => p.TblAltInfTypes)
                .HasForeignKey(d => d.InfTypeId)
                .HasConstraintName("tblAltInfTypes_FK00");

            entity.HasOne(d => d.User).WithMany(p => p.TblAltInfTypes)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("tblAltInfTypes_FK01");
        });

        modelBuilder.Entity<TblAssessmentList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblAsses__3214EC27A055C728");

            entity.ToTable("tblAssessmentList");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.DateAdded)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ListName).HasMaxLength(255);
        });

        modelBuilder.Entity<TblAssessmentListAssessment>(entity =>
        {
            entity.HasKey(e => new { e.ListId, e.LogId }).HasName("PK__tblAsses__766661FF408F86B4");

            entity.ToTable("tblAssessmentListAssessments");

            entity.HasIndex(e => e.LogId, "IX_tblAssessmentListAssessments_LogID");

            entity.Property(e => e.ListId).HasColumnName("ListID");
            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.DateAdded)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.List).WithMany(p => p.TblAssessmentListAssessments)
                .HasForeignKey(d => d.ListId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblAssess__ListI__3DCA6032");

            entity.HasOne(d => d.Log).WithMany(p => p.TblAssessmentListAssessments)
                .HasForeignKey(d => d.LogId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblAssess__LogID__3EBE846B");
        });

        modelBuilder.Entity<TblAssessmentStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblAsses__3214EC27FDDD0BE1");

            entity.ToTable("tblAssessmentStatus");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblAsset>(entity =>
        {
            entity.HasKey(e => e.AssetId)
                .HasName("aaaaatblAssets_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblAssets");

            entity.HasIndex(e => e.AssetRef, "AssetID").HasFillFactor(90);

            entity.HasIndex(e => e.FacilityId, "FacilityID").HasFillFactor(90);

            entity.HasIndex(e => e.Lgaid, "LGAid").HasFillFactor(90);

            entity.HasIndex(e => e.FacilityId, "tblFacilitiestblAssets").HasFillFactor(90);

            entity.HasIndex(e => e.Lgaid, "tblLGAstblAssets").HasFillFactor(90);

            entity.Property(e => e.AssetId)
                .HasComment("Unique ID for each asset")
                .HasColumnName("AssetID");
            entity.Property(e => e.AddedBy).HasMaxLength(100);
            entity.Property(e => e.AddedTime).HasColumnType("datetime");
            entity.Property(e => e.Additionalident)
                .HasMaxLength(30)
                .HasDefaultValue("n/a")
                .HasComment("Name of the LGA asset register (e.g. Buildings, Playspaces) on which the asset is recorded");
            entity.Property(e => e.AssetRef)
                .HasMaxLength(20)
                .HasComment("Asset reference used by the LGA (not unique to table)");
            entity.Property(e => e.AssetRegisterName1).HasMaxLength(150);
            entity.Property(e => e.AssetRegisterName2).HasMaxLength(150);
            entity.Property(e => e.ChangedBy).HasMaxLength(100);
            entity.Property(e => e.ChangedTime).HasColumnType("datetime");
            entity.Property(e => e.ConditionDescriptionOverall1)
                .HasMaxLength(50)
                .HasDefaultValue("unknown");
            entity.Property(e => e.ConditionScoreOverallNumeric1).HasColumnType("decimal(4, 1)");
            entity.Property(e => e.FacilityId)
                .HasDefaultValue(0)
                .HasComment("ID of the facility related to the asset")
                .HasColumnName("FacilityID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasComment("ID of the LGA in which the asset is located")
                .HasColumnName("LGAid");
            entity.Property(e => e.LockedBy).HasMaxLength(100);
            entity.Property(e => e.LockedTime).HasColumnType("datetime");

            entity.HasOne(d => d.Facility).WithMany(p => p.TblAssets)
                .HasForeignKey(d => d.FacilityId)
                .HasConstraintName("tblAssets_FK00");

            entity.HasOne(d => d.Lga).WithMany(p => p.TblAssets)
                .HasForeignKey(d => d.Lgaid)
                .HasConstraintName("tblAssets_FK01");
        });

        modelBuilder.Entity<TblAssetCondition>(entity =>
        {
            entity.ToTable("tblAssetCondition");

            entity.HasIndex(e => e.FacilityId, "InxAssetsCondFacilityID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AltAssetName1).HasMaxLength(150);
            entity.Property(e => e.AssetClassPrimary).HasMaxLength(50);
            entity.Property(e => e.AssetClassSecondry).HasMaxLength(50);
            entity.Property(e => e.AssetConditionScoreOverallNumeric1)
                .HasColumnType("decimal(4, 1)")
                .HasColumnName("AssetConditionScoreOverall_Numeric1");
            entity.Property(e => e.AssetConditionScoringDescription)
                .HasMaxLength(150)
                .HasColumnName("AssetConditionScoring_Description");
            entity.Property(e => e.AssetHierarchyPrimary).HasMaxLength(50);
            entity.Property(e => e.AssetHierarchySecondary).HasMaxLength(50);
            entity.Property(e => e.AssetLocationFromRegister1).HasMaxLength(150);
            entity.Property(e => e.AssetLocationFromRegister2).HasMaxLength(150);
            entity.Property(e => e.AssetLocationFromRegister3).HasMaxLength(150);
            entity.Property(e => e.AssetLocationFromRegister4).HasMaxLength(150);
            entity.Property(e => e.AssetNamePrimary).HasMaxLength(150);
            entity.Property(e => e.AssetOwner).HasMaxLength(150);
            entity.Property(e => e.AssetRefPrimary)
                .HasMaxLength(20)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.AssetRefSecondary)
                .HasMaxLength(20)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.AssetTypePrimary).HasMaxLength(50);
            entity.Property(e => e.AssetTypeSecondary).HasMaxLength(50);
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
        });

        modelBuilder.Entity<TblAttribute>(entity =>
        {
            entity.HasKey(e => e.AttributeId);

            entity.ToTable("tblAttributes");

            entity.Property(e => e.AttributeId).HasColumnName("AttributeID");
            entity.Property(e => e.Attribute).HasMaxLength(100);
            entity.Property(e => e.AttributeNameId)
                .HasComment("4 digit LGAid for the municipality in which the facility is located")
                .HasColumnName("AttributeNameID");

            entity.HasOne(d => d.AttributeName).WithMany(p => p.TblAttributes)
                .HasForeignKey(d => d.AttributeNameId)
                .HasConstraintName("FK_tblAttributes_tblAttributeNames");
        });

        modelBuilder.Entity<TblAttributeExampleAttribute>(entity =>
        {
            entity.ToTable("tblAttribute_ExampleAttributes");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AttributeExampleAttribute)
                .HasMaxLength(100)
                .HasColumnName("Attribute_ExampleAttribute");
            entity.Property(e => e.AttributeExampleNameId).HasColumnName("Attribute_ExampleNameID");
        });

        modelBuilder.Entity<TblAttributeExampleName>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Attribute_ExampleNames");

            entity.ToTable("tblAttribute_ExampleNames");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AttributeName).HasMaxLength(100);
        });

        modelBuilder.Entity<TblAttributeName>(entity =>
        {
            entity.HasKey(e => e.AttributeNameId).HasName("PK_AttributeNames");

            entity.ToTable("tblAttributeNames");

            entity.Property(e => e.AttributeNameId).HasColumnName("AttributeNameID");
            entity.Property(e => e.AddedBy).HasMaxLength(100);
            entity.Property(e => e.AddedTime).HasColumnType("datetime");
            entity.Property(e => e.AttributeName).HasMaxLength(100);
            entity.Property(e => e.ChangedBy).HasMaxLength(100);
            entity.Property(e => e.ChangedTime).HasColumnType("datetime");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasComment("4 digit LGAid for the municipality in which the facility is located")
                .HasColumnName("LGAid");
            entity.Property(e => e.LockedBy).HasMaxLength(100);
            entity.Property(e => e.LockedTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblBoundariesWorkerZone>(entity =>
        {
            entity.HasKey(e => e.RecordId)
                .HasName("PK__tblBound__FBDF78C91C9093FD")
                .HasFillFactor(90);

            entity.ToTable("tblBoundaries_WorkerZone");

            entity.Property(e => e.RecordId).HasColumnName("RecordID");
            entity.Property(e => e.TravelZone).HasMaxLength(255);
            entity.Property(e => e.WorkerZoneId).HasColumnName("WorkerZoneID");
        });

        modelBuilder.Entity<TblBoundary>(entity =>
        {
            entity.HasKey(e => e.BoundaryId)
                .HasName("aaaaatblBoundaries_PK")
                .HasFillFactor(90);

            entity.ToTable("tblBoundaries");

            entity.HasIndex(e => e.BoundaryTypeId, "IX_tblBoundaries_BoundaryTypeID");

            entity.HasIndex(e => e.Lgaid, "IX_tblBoundaries_LGAid");

            entity.Property(e => e.BoundaryId)
                .HasComment("Unique ID for the boundary")
                .HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryName)
                .HasMaxLength(120)
                .HasComment("Unique name of boundary / area (e.g. town, suburb or locality name)");
            entity.Property(e => e.BoundaryTypeId)
                .HasComment("Type of settlement boundary - lookup tblBoundaryTypes")
                .HasColumnName("BoundaryTypeID");
            entity.Property(e => e.Exclude).HasDefaultValue(false);
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasComment("ID of the municipality in which the area is located (use spatial link instead of field?)")
                .HasColumnName("LGAid");
            entity.Property(e => e.MeshBlock).HasDefaultValue(false);
            entity.Property(e => e.Municipality).HasDefaultValue(false);
            entity.Property(e => e.SmallArea).HasDefaultValue(false);
            entity.Property(e => e.StateCode)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.Suburb).HasDefaultValue(false);
        });

        modelBuilder.Entity<TblBoundaryType>(entity =>
        {
            entity.HasKey(e => e.BoundaryTypeId)
                .HasName("aaaaatblBoundaryTypes_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblBoundaryTypes");

            entity.HasIndex(e => e.BoundaryTypeId, "ID").HasFillFactor(90);

            entity.HasIndex(e => e.BoundaryType, "Type")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.BoundaryTypeId).HasColumnName("BoundaryTypeID");
            entity.Property(e => e.BoundaryType).HasMaxLength(255);
        });

        modelBuilder.Entity<TblCasimoFacilitiesUse>(entity =>
        {
            entity.HasKey(e => e.UniqueRecordId);

            entity.ToTable("tblCASIMO_FacilitiesUses");

            entity.Property(e => e.UniqueRecordId).HasColumnName("UniqueRecordID");
            entity.Property(e => e.AccessType)
                .HasMaxLength(25)
                .HasColumnName("Access_Type");
            entity.Property(e => e.ActiveFromYear).HasColumnName("Active_From_Year");
            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.AlternativeIdentifier)
                .HasMaxLength(30)
                .HasColumnName("Alternative_identifier");
            entity.Property(e => e.CasimoFacilityId).HasColumnName("CASIMO_FacilityID");
            entity.Property(e => e.CasimoLgaId)
                .HasMaxLength(4)
                .HasColumnName("CASIMO_LGA_ID");
            entity.Property(e => e.CasimoLgaName)
                .HasMaxLength(60)
                .HasColumnName("CASIMO_LGA_name");
            entity.Property(e => e.CasimoUseId).HasColumnName("CASIMO_Use_ID");
            entity.Property(e => e.CouncilAssetRef)
                .HasMaxLength(20)
                .HasColumnName("Council_Asset_Ref");
            entity.Property(e => e.CouncilContactPerson)
                .HasMaxLength(120)
                .HasColumnName("Council_Contact_Person");
            entity.Property(e => e.CustomGroups)
                .HasMaxLength(255)
                .HasColumnName("Custom_groups");
            entity.Property(e => e.DateLastUpdated).HasColumnType("datetime");
            entity.Property(e => e.FacilityNameComponent)
                .HasMaxLength(150)
                .HasColumnName("Facility_name_(component)");
            entity.Property(e => e.FacilityNameFull)
                .HasMaxLength(255)
                .HasColumnName("Facility_name_full");
            entity.Property(e => e.FacilityNameSite)
                .HasMaxLength(150)
                .HasColumnName("Facility_name_(site)");
            entity.Property(e => e.FacilityNotes)
                .HasMaxLength(1000)
                .HasColumnName("Facility_Notes");
            entity.Property(e => e.FacilityStatus)
                .HasMaxLength(25)
                .HasColumnName("Facility_Status");
            entity.Property(e => e.LatitudeY).HasColumnName("Latitude_Y");
            entity.Property(e => e.LongitudeX).HasColumnName("Longitude_X");
            entity.Property(e => e.Operator).HasMaxLength(150);
            entity.Property(e => e.Owner).HasMaxLength(150);
            entity.Property(e => e.RelatedUseNotes)
                .HasMaxLength(255)
                .HasColumnName("Related_Use_Notes");
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.Use).HasMaxLength(100);
            entity.Property(e => e.UseHierarchyAttribute)
                .HasMaxLength(255)
                .HasColumnName("Use_Hierarchy_Attribute");
        });

        modelBuilder.Entity<TblCasimoFacilitiesUsesQuantity>(entity =>
        {
            entity.HasKey(e => e.UniqueRecordId);

            entity.ToTable("tblCASIMO_FacilitiesUsesQuantities");

            entity.Property(e => e.UniqueRecordId).HasColumnName("UniqueRecordID");
            entity.Property(e => e.AccessType)
                .HasMaxLength(25)
                .HasColumnName("Access_Type");
            entity.Property(e => e.ActiveFromYear).HasColumnName("Active_From_Year");
            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.AlternativeIdentifier)
                .HasMaxLength(30)
                .HasColumnName("Alternative_identifier");
            entity.Property(e => e.CasimoFacilityId).HasColumnName("CASIMO_FacilityID");
            entity.Property(e => e.CasimoLgaId)
                .HasMaxLength(4)
                .HasColumnName("CASIMO_LGA_ID");
            entity.Property(e => e.CasimoLgaName)
                .HasMaxLength(60)
                .HasColumnName("CASIMO_LGA_name");
            entity.Property(e => e.CasimoUnitTypeId).HasColumnName("CASIMO_Unit_Type_ID");
            entity.Property(e => e.CasimoUseId).HasColumnName("CASIMO_Use_ID");
            entity.Property(e => e.CouncilAssetRef)
                .HasMaxLength(20)
                .HasColumnName("Council_Asset_Ref");
            entity.Property(e => e.CouncilContactPerson)
                .HasMaxLength(120)
                .HasColumnName("Council_Contact_Person");
            entity.Property(e => e.CustomGroups)
                .HasMaxLength(255)
                .HasColumnName("Custom_groups");
            entity.Property(e => e.DateLastUpdated).HasColumnType("datetime");
            entity.Property(e => e.FacilityNameComponent)
                .HasMaxLength(150)
                .HasColumnName("Facility_name_(component)");
            entity.Property(e => e.FacilityNameFull)
                .HasMaxLength(255)
                .HasColumnName("Facility_name_full");
            entity.Property(e => e.FacilityNameSite)
                .HasMaxLength(150)
                .HasColumnName("Facility_name_(site)");
            entity.Property(e => e.FacilityNotes)
                .HasMaxLength(1000)
                .HasColumnName("Facility_Notes");
            entity.Property(e => e.FacilityStatus)
                .HasMaxLength(25)
                .HasColumnName("Facility_Status");
            entity.Property(e => e.LatitudeY).HasColumnName("Latitude_Y");
            entity.Property(e => e.LongitudeX).HasColumnName("Longitude_X");
            entity.Property(e => e.Operator).HasMaxLength(150);
            entity.Property(e => e.Owner).HasMaxLength(150);
            entity.Property(e => e.RelatedUseNotes)
                .HasMaxLength(255)
                .HasColumnName("Related_Use_Notes");
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.UnitType)
                .HasMaxLength(50)
                .HasColumnName("Unit_Type");
            entity.Property(e => e.Use).HasMaxLength(100);
            entity.Property(e => e.UseHierarchyAttribute)
                .HasMaxLength(255)
                .HasColumnName("Use_Hierarchy_Attribute");
        });

        modelBuilder.Entity<TblCasimoFacility>(entity =>
        {
            entity.HasKey(e => e.UniqueRecordId);

            entity.ToTable("tblCASIMO_Facilities");

            entity.Property(e => e.UniqueRecordId)
                .ValueGeneratedNever()
                .HasColumnName("UniqueRecordID");
            entity.Property(e => e.ActiveFromYear).HasColumnName("Active_From_Year");
            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.AlternativeIdentifier)
                .HasMaxLength(30)
                .HasColumnName("Alternative_identifier");
            entity.Property(e => e.CasimoFacilityId).HasColumnName("CASIMO_FacilityID");
            entity.Property(e => e.CasimoLgaId)
                .HasMaxLength(4)
                .HasColumnName("CASIMO_LGA_ID");
            entity.Property(e => e.CasimoLgaName)
                .HasMaxLength(60)
                .HasColumnName("CASIMO_LGA_name");
            entity.Property(e => e.CouncilAssetRef)
                .HasMaxLength(20)
                .HasColumnName("Council_Asset_Ref");
            entity.Property(e => e.DateLastUpdated).HasColumnType("datetime");
            entity.Property(e => e.FacilityNameComponent)
                .HasMaxLength(150)
                .HasColumnName("Facility_name_(component)");
            entity.Property(e => e.FacilityNameFull)
                .HasMaxLength(255)
                .HasColumnName("Facility_name_full");
            entity.Property(e => e.FacilityNameSite)
                .HasMaxLength(150)
                .HasColumnName("Facility_name_(site)");
            entity.Property(e => e.FacilityNotes)
                .HasMaxLength(1000)
                .HasColumnName("Facility_Notes");
            entity.Property(e => e.FacilityStatus)
                .HasMaxLength(25)
                .HasColumnName("Facility_Status");
            entity.Property(e => e.LatitudeY).HasColumnName("Latitude_Y");
            entity.Property(e => e.LongitudeX).HasColumnName("Longitude_X");
            entity.Property(e => e.Operator).HasMaxLength(150);
            entity.Property(e => e.Owner).HasMaxLength(150);
            entity.Property(e => e.Settlement).HasMaxLength(100);
        });

        modelBuilder.Entity<TblCasimoQuantityAsstComparisonArea>(entity =>
        {
            entity.HasKey(e => e.UniqueRecordId);

            entity.ToTable("tblCASIMO_QuantityAsst_ComparisonAreas");

            entity.Property(e => e.UniqueRecordId).HasColumnName("UniqueRecordID");
            entity.Property(e => e.AgeCohort)
                .HasMaxLength(20)
                .HasColumnName("Age_Cohort");
            entity.Property(e => e.CasimoLgaName)
                .HasMaxLength(60)
                .HasColumnName("CASIMO_LGA_name");
            entity.Property(e => e.CasimoUserName)
                .HasMaxLength(100)
                .HasColumnName("CASIMO_user_name");
            entity.Property(e => e.CohortSize).HasColumnName("Cohort_Size");
            entity.Property(e => e.ComparisonArea)
                .HasMaxLength(255)
                .HasColumnName("Comparison_Area");
            entity.Property(e => e.ComponentForecastAreas)
                .HasMaxLength(1000)
                .HasColumnName("Component_forecast_areas");
            entity.Property(e => e.CurrentRatio)
                .HasMaxLength(255)
                .HasColumnName("Current_Ratio");
            entity.Property(e => e.Difference).HasColumnName("Difference_#");
            entity.Property(e => e.Difference1).HasColumnName("Difference_%");
            entity.Property(e => e.ExistingQuantity).HasColumnName("Existing_Quantity");
            entity.Property(e => e.ForecastAreaId).HasColumnName("Forecast_Area_ID");
            entity.Property(e => e.QuantityStandard)
                .HasMaxLength(255)
                .HasColumnName("Quantity_Standard");
            entity.Property(e => e.TargetQuantity).HasColumnName("Target_Quantity");
            entity.Property(e => e.TargetRatio)
                .HasMaxLength(255)
                .HasColumnName("Target_Ratio");
        });

        modelBuilder.Entity<TblCasimoQuantityAsstForecastArea>(entity =>
        {
            entity.HasKey(e => e.UniqueRecordId);

            entity.ToTable("tblCASIMO_QuantityAsst_ForecastAreas");

            entity.Property(e => e.UniqueRecordId).HasColumnName("UniqueRecordID");
            entity.Property(e => e.AgeCohort)
                .HasMaxLength(20)
                .HasColumnName("Age_Cohort");
            entity.Property(e => e.CasimoLgaName)
                .HasMaxLength(60)
                .HasColumnName("CASIMO_LGA_name");
            entity.Property(e => e.CohortSize).HasColumnName("Cohort_Size");
            entity.Property(e => e.CurrentRatio)
                .HasMaxLength(255)
                .HasColumnName("Current_Ratio");
            entity.Property(e => e.Difference).HasColumnName("Difference_#");
            entity.Property(e => e.Difference1).HasColumnName("Difference_%");
            entity.Property(e => e.ExistingQuantity).HasColumnName("Existing_Quantity");
            entity.Property(e => e.ForecastArea)
                .HasMaxLength(255)
                .HasColumnName("Forecast_Area");
            entity.Property(e => e.ForecastAreaId).HasColumnName("Forecast_Area_ID");
            entity.Property(e => e.Municipality).HasDefaultValue(false);
            entity.Property(e => e.QuantityStandard)
                .HasMaxLength(255)
                .HasColumnName("Quantity_Standard");
            entity.Property(e => e.SmallArea)
                .HasDefaultValue(false)
                .HasColumnName("Small_Area");
            entity.Property(e => e.StateCode)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("State_Code");
            entity.Property(e => e.Suburb).HasDefaultValue(false);
            entity.Property(e => e.TargetQuantity).HasColumnName("Target_Quantity");
            entity.Property(e => e.TargetRatio)
                .HasMaxLength(255)
                .HasColumnName("Target_Ratio");
        });

        modelBuilder.Entity<TblCasimoQuantityAsstStandard>(entity =>
        {
            entity.HasKey(e => e.UniqueRecordId).HasName("PK_tblCASIMO_PopulationStandards");

            entity.ToTable("tblCASIMO_QuantityAsst_Standards");

            entity.Property(e => e.UniqueRecordId)
                .ValueGeneratedNever()
                .HasColumnName("UniqueRecordID");
            entity.Property(e => e.CasimoLgaName)
                .HasMaxLength(60)
                .HasColumnName("CASIMO_LGA_name");
            entity.Property(e => e.PopulationStandard)
                .HasMaxLength(255)
                .HasColumnName("Population_Standard");
            entity.Property(e => e.Rationale).HasMaxLength(1000);
            entity.Property(e => e.StandardName)
                .HasMaxLength(100)
                .HasColumnName("Standard_Name");
            entity.Property(e => e.UnitType)
                .HasMaxLength(50)
                .HasColumnName("Unit_Type");
        });

        modelBuilder.Entity<TblCasimoSuitabilityAsstOverallScore>(entity =>
        {
            entity.HasKey(e => e.UniqueRecordId).HasName("PK_tblCASIMO_FFPresults_OverallScores");

            entity.ToTable("tblCASIMO_SuitabilityAsst_OverallScores");

            entity.Property(e => e.UniqueRecordId).HasColumnName("UniqueRecordID");
            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.AssetCondition)
                .HasMaxLength(255)
                .HasColumnName("Asset_Condition");
            entity.Property(e => e.CasimoFacilityId).HasColumnName("CASIMO_FacilityID");
            entity.Property(e => e.CasimoFfplogId).HasColumnName("CASIMO_FFPlogID");
            entity.Property(e => e.CasimoLgaId)
                .HasMaxLength(4)
                .HasColumnName("CASIMO_LGA_ID");
            entity.Property(e => e.CasimoLgaName)
                .HasMaxLength(60)
                .HasColumnName("CASIMO_LGA_name");
            entity.Property(e => e.CouncilAssetRef)
                .HasMaxLength(20)
                .HasColumnName("Council_asset_ref");
            entity.Property(e => e.CustomGroups)
                .HasMaxLength(255)
                .HasColumnName("Custom_groups");
            entity.Property(e => e.FacilityNameComponent)
                .HasMaxLength(150)
                .HasColumnName("Facility_name_(component)");
            entity.Property(e => e.FacilityNameFull)
                .HasMaxLength(255)
                .HasColumnName("Facility_name_full");
            entity.Property(e => e.FacilityNameSite)
                .HasMaxLength(150)
                .HasColumnName("Facility_name_(site)");
            entity.Property(e => e.FfpAssessedUse)
                .HasMaxLength(100)
                .HasColumnName("FFP_Assessed_Use");
            entity.Property(e => e.FfpOverallScore)
                .HasColumnType("numeric(11, 1)")
                .HasColumnName("FFP_Overall_Score");
            entity.Property(e => e.FfpOverallScore2)
                .HasColumnType("numeric(11, 1)")
                .HasColumnName("FFP_Overall_Score2");
            entity.Property(e => e.FfpOverallScore2Description)
                .HasMaxLength(255)
                .HasColumnName("FFP_Overall_Score2_Description");
            entity.Property(e => e.FfpOverallScoreDescription)
                .HasMaxLength(255)
                .HasColumnName("FFP_Overall_Score_Description");
            entity.Property(e => e.FfpTemplate)
                .HasMaxLength(100)
                .HasColumnName("FFP_Template");
            entity.Property(e => e.LatitudeY).HasColumnName("Latitude_Y");
            entity.Property(e => e.LongitudeX).HasColumnName("Longitude_X");
            entity.Property(e => e.NameAndAssessedUse)
                .HasMaxLength(400)
                .HasColumnName("Name_and_assessed_use");
            entity.Property(e => e.Operator).HasMaxLength(150);
            entity.Property(e => e.Owner).HasMaxLength(150);
            entity.Property(e => e.Settlement).HasMaxLength(100);
        });

        modelBuilder.Entity<TblCasimoSuitabilityAsstQuestionResponse>(entity =>
        {
            entity.HasKey(e => e.UniqueRecordId).HasName("PK_tblCASIMO_FFPresults_QuestionResponses");

            entity.ToTable("tblCASIMO_SuitabilityAsst_QuestionResponses");

            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.AssetCondition)
                .HasMaxLength(1000)
                .HasColumnName("Asset_Condition");
            entity.Property(e => e.CasimoFacilityId).HasColumnName("CASIMO_FacilityID");
            entity.Property(e => e.CasimoFfplogId).HasColumnName("CASIMO_FFPlogID");
            entity.Property(e => e.CasimoLgaId)
                .HasMaxLength(4)
                .HasColumnName("CASIMO_LGA_ID");
            entity.Property(e => e.CasimoLgaName)
                .HasMaxLength(60)
                .HasColumnName("CASIMO_LGA_name");
            entity.Property(e => e.CouncilAssetRef)
                .HasMaxLength(20)
                .HasColumnName("Council_asset_ref");
            entity.Property(e => e.CustomGroups)
                .HasMaxLength(1000)
                .HasColumnName("Custom_groups");
            entity.Property(e => e.FacilityNameComponent)
                .HasMaxLength(255)
                .HasColumnName("Facility_name_(component)");
            entity.Property(e => e.FacilityNameFull)
                .HasMaxLength(255)
                .HasColumnName("Facility_name_full");
            entity.Property(e => e.FacilityNameSite)
                .HasMaxLength(255)
                .HasColumnName("Facility_name_(site)");
            entity.Property(e => e.FfpAssessedUse)
                .HasMaxLength(255)
                .HasColumnName("FFP_Assessed_Use");
            entity.Property(e => e.FfpCategory)
                .HasMaxLength(255)
                .HasColumnName("FFP_Category");
            entity.Property(e => e.FfpQuestion)
                .HasMaxLength(255)
                .HasColumnName("FFP_Question");
            entity.Property(e => e.FfpQuestionScore)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("FFP_Question_Score");
            entity.Property(e => e.FfpQuestionScore2)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("FFP_Question_Score2");
            entity.Property(e => e.FfpQuestionTitle)
                .HasMaxLength(255)
                .HasColumnName("FFP_Question_Title");
            entity.Property(e => e.FfpResponse2Selection)
                .HasMaxLength(50)
                .HasColumnName("FFP_Response2_Selection");
            entity.Property(e => e.FfpResponse2Text)
                .HasMaxLength(1000)
                .HasColumnName("FFP_Response2_Text");
            entity.Property(e => e.FfpResponseSelection)
                .HasMaxLength(255)
                .HasColumnName("FFP_Response_Selection");
            entity.Property(e => e.FfpResponseText)
                .HasMaxLength(2000)
                .HasColumnName("FFP_Response_Text");
            entity.Property(e => e.FfpTemplate)
                .HasMaxLength(255)
                .HasColumnName("FFP_Template");
            entity.Property(e => e.LatitudeY).HasColumnName("Latitude_Y");
            entity.Property(e => e.LongitudeX).HasColumnName("Longitude_X");
            entity.Property(e => e.Operator).HasMaxLength(150);
            entity.Property(e => e.Owner).HasMaxLength(150);
            entity.Property(e => e.Settlement).HasMaxLength(150);
        });

        modelBuilder.Entity<TblCasimoSuitabilityAsstSectionResponse>(entity =>
        {
            entity.HasKey(e => e.UniqueRecordId).HasName("PK_tblCASIMO_FFPresults_SectionResponses");

            entity.ToTable("tblCASIMO_SuitabilityAsst_SectionResponses");

            entity.Property(e => e.UniqueRecordId).HasColumnName("UniqueRecordID");
            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.AssetCondition)
                .HasMaxLength(1000)
                .HasColumnName("Asset_Condition");
            entity.Property(e => e.CasimoFacilityId).HasColumnName("CASIMO_FacilityID");
            entity.Property(e => e.CasimoFfplogId).HasColumnName("CASIMO_FFPlogID");
            entity.Property(e => e.CasimoLgaId)
                .HasMaxLength(4)
                .HasColumnName("CASIMO_LGA_ID");
            entity.Property(e => e.CasimoLgaName)
                .HasMaxLength(60)
                .HasColumnName("CASIMO_LGA_name");
            entity.Property(e => e.CouncilAssetRef)
                .HasMaxLength(20)
                .HasColumnName("Council_asset_ref");
            entity.Property(e => e.CustomGroups)
                .HasMaxLength(1000)
                .HasColumnName("Custom_groups");
            entity.Property(e => e.FacilityNameComponent)
                .HasMaxLength(150)
                .HasColumnName("Facility_name_(component)");
            entity.Property(e => e.FacilityNameFull)
                .HasMaxLength(1000)
                .HasColumnName("Facility_name_full");
            entity.Property(e => e.FacilityNameSite)
                .HasMaxLength(150)
                .HasColumnName("Facility_name_(site)");
            entity.Property(e => e.FfpAssessedUse)
                .HasMaxLength(150)
                .HasColumnName("FFP_Assessed_Use");
            entity.Property(e => e.FfpCategory)
                .HasMaxLength(150)
                .HasColumnName("FFP_Category");
            entity.Property(e => e.FfpCategoryRating)
                .HasMaxLength(100)
                .HasColumnName("FFP_Category_Rating");
            entity.Property(e => e.FfpCategoryRating2)
                .HasMaxLength(100)
                .HasColumnName("FFP_Category_Rating2");
            entity.Property(e => e.FfpCategoryScore)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("FFP_Category_Score");
            entity.Property(e => e.FfpCategoryScore2)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("FFP_Category_Score2");
            entity.Property(e => e.FfpCategorySummary)
                .HasMaxLength(2000)
                .HasColumnName("FFP_Category_Summary");
            entity.Property(e => e.FfpTemplate)
                .HasMaxLength(150)
                .HasColumnName("FFP_Template");
            entity.Property(e => e.LatitudeY).HasColumnName("Latitude_Y");
            entity.Property(e => e.LongitudeX).HasColumnName("Longitude_X");
            entity.Property(e => e.Operator).HasMaxLength(150);
            entity.Property(e => e.Owner).HasMaxLength(150);
            entity.Property(e => e.Settlement).HasMaxLength(150);
        });

        modelBuilder.Entity<TblCohort>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("aaaaatblCohorts_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblCohorts");

            entity.Property(e => e.Id)
                .HasComment("Unique ID for service cohort")
                .HasColumnName("ID");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasComment("Full description of service cohort");
            entity.Property(e => e.Order)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(3, 1)");
            entity.Property(e => e.ShortName)
                .HasMaxLength(20)
                .HasComment("Short name for service cohort");
            entity.Property(e => e.Type)
                .HasMaxLength(25)
                .HasComment("Lookup to tblCohortTypes");
        });

        modelBuilder.Entity<TblCohortType>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("aaaaatblCohortTypes_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblCohortTypes");

            entity.Property(e => e.Id)
                .HasComment("Unique ID for each cohort type")
                .HasColumnName("ID");
            entity.Property(e => e.Type)
                .HasMaxLength(25)
                .HasComment("Age or other");
        });

        modelBuilder.Entity<TblCriticalityType>(entity =>
        {
            entity.HasKey(e => e.CriticalityTypeId)
                .HasName("aaaaatblCriticalityTypes_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblCriticalityTypes");

            entity.HasIndex(e => e.CriticalityType, "Criticality")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => e.CriticalityTypeId, "ID").HasFillFactor(90);

            entity.HasIndex(e => e.Order, "OrderCOde").HasFillFactor(90);

            entity.Property(e => e.CriticalityTypeId)
                .HasComment("Unique ID of the criticality type")
                .HasColumnName("CriticalityTypeID");
            entity.Property(e => e.CriticalityType)
                .HasMaxLength(50)
                .HasComment("Criticality levels for different types of infrastructure");
            entity.Property(e => e.Order)
                .HasDefaultValue(0)
                .HasComment("Hierarchy of criticality types");
        });

        modelBuilder.Entity<TblCustomUseGroup>(entity =>
        {
            entity.HasKey(e => e.CustomUseGroupId);

            entity.ToTable("tblCustomUseGroup");

            entity.Property(e => e.CustomUseGroupId).HasColumnName("CustomUseGroupID");
            entity.Property(e => e.AddedBy).HasMaxLength(100);
            entity.Property(e => e.AddedTime).HasColumnType("datetime");
            entity.Property(e => e.ChangedBy).HasMaxLength(100);
            entity.Property(e => e.ChangedTime).HasColumnType("datetime");
            entity.Property(e => e.CustomUseGroupName).HasMaxLength(100);
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.LockedBy).HasMaxLength(100);
            entity.Property(e => e.LockedTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblCustomUseGroupId>(entity =>
        {
            entity.ToTable("tblCustomUseGroup_IDs");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Attribute1Id).HasColumnName("Attribute1ID");
            entity.Property(e => e.Attribute2Id).HasColumnName("Attribute2ID");
            entity.Property(e => e.CustomUseGroupId).HasColumnName("CustomUseGroupID");
            entity.Property(e => e.HierarchyLevelId).HasColumnName("HierarchyLevelID");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
        });

        modelBuilder.Entity<TblDevTestTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_tblDevTestTable");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TblExportList>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("tblExportLists");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CurrentMode).HasMaxLength(50);
            entity.Property(e => e.ExportFilters).HasMaxLength(100);
            entity.Property(e => e.ExportItem).HasMaxLength(50);
            entity.Property(e => e.ExportMnec)
                .HasDefaultValue(false)
                .HasColumnName("ExportMNEC");
            entity.Property(e => e.ExportQuery).HasMaxLength(100);
            entity.Property(e => e.ExportTypes).HasMaxLength(100);
        });

        modelBuilder.Entity<TblFacilitiesForecastArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblFacilitiesForecastArea");

            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilitySite).HasMaxLength(150);
            entity.Property(e => e.ForecastAreaBoundaryId).HasColumnName("ForecastAreaBoundaryID");
            entity.Property(e => e.ForecastAreaBoundaryName).HasMaxLength(120);
            entity.Property(e => e.ForecastAreaLgaid)
                .HasMaxLength(4)
                .HasColumnName("ForecastAreaLGAID");
        });

        modelBuilder.Entity<TblFacilitiesPoint>(entity =>
        {
            entity.HasKey(e => e.FacilityId);

            entity.ToTable("tblFacilitiesPoints");

            entity.Property(e => e.FacilityId)
                .ValueGeneratedNever()
                .HasColumnName("FacilityID");
        });

        modelBuilder.Entity<TblFacilitiesSa2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblFacilitiesSA2");

            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.Sa2boundaryId).HasColumnName("SA2BoundaryID");
            entity.Property(e => e.Sa2boundaryName)
                .HasMaxLength(120)
                .HasColumnName("SA2BoundaryName");
        });

        modelBuilder.Entity<TblFacility>(entity =>
        {
            entity.HasKey(e => e.FacilityId)
                .HasName("aaaaatblFacilities_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblFacilities", tb => tb.HasComment("Attribute information for facilities (note, information on services, activities or infrastructure type provided through the facility are stored in tblServices)"));

            entity.HasIndex(e => e.ActiveFrom, "IX_tblFacilities").HasFillFactor(90);

            entity.HasIndex(e => e.Lgaid, "LGAcode").HasFillFactor(90);

            entity.HasIndex(e => e.ParentId, "ParentID").HasFillFactor(90);

            entity.HasIndex(e => e.Settlement, "tblBoundariestblFacilities").HasFillFactor(90);

            entity.HasIndex(e => e.StatusId, "tblFacilityStatustblFacilities").HasFillFactor(90);

            entity.HasIndex(e => e.UserInterestId, "tblUserInteresttblFacilities").HasFillFactor(90);

            entity.HasIndex(e => e.CreatorUserId, "tblUserstblFacilities").HasFillFactor(90);

            entity.Property(e => e.FacilityId)
                .HasComment("Unique ID for each facility")
                .HasColumnName("FacilityID");
            entity.Property(e => e.ActiveFrom)
                .HasDefaultValue(2016)
                .HasComment("Earliest year that facility should be included in modelling");
            entity.Property(e => e.ActiveUntil).HasDefaultValue(9999);
            entity.Property(e => e.AddedBy).HasMaxLength(100);
            entity.Property(e => e.AddedTime).HasColumnType("datetime");
            entity.Property(e => e.Address)
                .HasMaxLength(150)
                .HasDefaultValue("")
                .HasComment("Street number and name");
            entity.Property(e => e.ChangedBy).HasMaxLength(100);
            entity.Property(e => e.ChangedTime).HasColumnType("datetime");
            entity.Property(e => e.Comments)
                .HasDefaultValue("")
                .HasComment("General comments about the facility");
            entity.Property(e => e.CoordsCorrectLga)
                .HasDefaultValue(false)
                .HasColumnName("CoordsCorrectLGA");
            entity.Property(e => e.CreatorUserId)
                .HasComment("4 digit UserID of the user that first created the record")
                .HasColumnName("CreatorUserID");
            entity.Property(e => e.FacilityComponent)
                .HasMaxLength(150)
                .HasDefaultValue("")
                .HasComment("A specific component of the overall facility. Different components are usually spatially separate from each other.");
            entity.Property(e => e.FacilitySite)
                .HasMaxLength(150)
                .HasDefaultValue("")
                .HasComment("Name of the overall facility or site");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasComment("4 digit LGAid for the municipality in which the facility is located")
                .HasColumnName("LGAid");
            entity.Property(e => e.LockedBy).HasMaxLength(100);
            entity.Property(e => e.LockedTime).HasColumnType("datetime");
            entity.Property(e => e.Operator)
                .HasMaxLength(150)
                .HasComment("Facility operator / manager name");
            entity.Property(e => e.Owner)
                .HasMaxLength(150)
                .HasDefaultValue("")
                .HasComment("Landowner name");
            entity.Property(e => e.ParentId)
                .HasDefaultValue(0)
                .HasComment("Facility ID of parent facility where current facility is a child (not required)")
                .HasColumnName("ParentID");
            entity.Property(e => e.Postcode).HasComment("Postcode");
            entity.Property(e => e.Settlement)
                .HasMaxLength(100)
                .HasComment("Settlement name (this may be town, suburb or locality)");
            entity.Property(e => e.StatusId)
                .HasComment("Existing, planned, hypothetical")
                .HasColumnName("StatusID");
            entity.Property(e => e.TempId).HasColumnName("TempID");
            entity.Property(e => e.UserInterestId)
                .HasDefaultValue(0)
                .HasComment("Ownership or financial interest in the facility")
                .HasColumnName("UserInterestID");
            entity.Property(e => e.XLongitude)
                .HasDefaultValue(0.0)
                .HasComment("X coordinates (GDA94) longitude for link to GIS")
                .HasColumnName("X_longitude");
            entity.Property(e => e.YLatitude)
                .HasDefaultValue(0.0)
                .HasComment("Y coordinates (GDA94) latitude for link to GIS")
                .HasColumnName("Y_latitude");

            entity.HasOne(d => d.CreatorUser).WithMany(p => p.TblFacilities)
                .HasForeignKey(d => d.CreatorUserId)
                .HasConstraintName("tblFacilities_FK03");

            entity.HasOne(d => d.Status).WithMany(p => p.TblFacilities)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("tblFacilities_FK01");

            entity.HasOne(d => d.UserInterest).WithMany(p => p.TblFacilities)
                .HasForeignKey(d => d.UserInterestId)
                .HasConstraintName("tblFacilities_FK02");
        });

        modelBuilder.Entity<TblFacilityFilterVal>(entity =>
        {
            entity.HasKey(e => e.Filter)
                .HasName("aaaaatblFacilityFilterVals_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblFacilityFilterVals");

            entity.Property(e => e.Filter).HasMaxLength(100);
            entity.Property(e => e.Order).HasDefaultValue(0);
        });

        modelBuilder.Entity<TblFacilitySortVal>(entity =>
        {
            entity.HasKey(e => e.Sort)
                .HasName("aaaaatblFacilitySortVals_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblFacilitySortVals");

            entity.Property(e => e.Sort).HasMaxLength(100);
            entity.Property(e => e.Order).HasDefaultValue(0);
        });

        modelBuilder.Entity<TblFacilityStatus>(entity =>
        {
            entity.HasKey(e => e.FacilityStatusId)
                .HasName("aaaaatblFacilityStatus_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblFacilityStatus");

            entity.HasIndex(e => e.FacilityStatusId, "ID").HasFillFactor(90);

            entity.HasIndex(e => e.OrderCode, "OrderCode").HasFillFactor(90);

            entity.HasIndex(e => e.FacilityStatus, "Status")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.FacilityStatusId)
                .HasComment("Unique ID of facility statuses")
                .HasColumnName("FacilityStatusID");
            entity.Property(e => e.FacilityStatus).HasMaxLength(25);
            entity.Property(e => e.OrderCode).HasDefaultValue(0);
        });

        modelBuilder.Entity<TblFfpDraftTemplateQuestion>(entity =>
        {
            entity.ToTable("tblFFP_DraftTemplateQuestions");

            entity.Property(e => e.Id)
                .HasComment("QuestionID")
                .HasColumnName("ID");
            entity.Property(e => e.HelpComments)
                .HasMaxLength(255)
                .HasComment("Comments / prompts to help respondees answer the question");
            entity.Property(e => e.QuestionOrder).HasComment("Numeric order that questions appear in");
            entity.Property(e => e.QuestionText)
                .HasMaxLength(150)
                .HasDefaultValue("")
                .HasComment("Question text (max 150 characters)");
            entity.Property(e => e.QuestionTitle)
                .HasMaxLength(100)
                .HasComment("Short title or name for each question (max 100 characters)");
            entity.Property(e => e.SectionId)
                .HasComment("ID from tblFFPtemplateSections")
                .HasColumnName("SectionID");
            entity.Property(e => e.Subsection)
                .HasMaxLength(5)
                .HasComment("Numeric or character suffix to section number (e.g. 'a', 'b', or 'i', 'ii', or '-1', '-2')");
        });

        modelBuilder.Entity<TblFfpDraftTemplateSection>(entity =>
        {
            entity.ToTable("tblFFP_DraftTemplateSections");

            entity.Property(e => e.Id)
                .HasComment("SectionID")
                .HasColumnName("ID");
            entity.Property(e => e.SectionNumber).HasComment("Section / category number");
            entity.Property(e => e.SectionTitle)
                .HasMaxLength(150)
                .HasComment("Section / category name");
            entity.Property(e => e.SummaryRequired)
                .HasDefaultValue(false)
                .HasComment("Is a record in tblFFPasstSectionSummaries required? i.e. is a summary comment for this section/category required?\r\n");
            entity.Property(e => e.TemplateId)
                .HasComment("ID from tblFFPtemplateTitles")
                .HasColumnName("TemplateID");
            entity.Property(e => e.WeightPercent).HasComment("The % weighting, where this section contributes to an overall facility score. Must be 100 or less.");
        });

        modelBuilder.Entity<TblFfpDraftTemplateTitle>(entity =>
        {
            entity.ToTable("tblFFP_DraftTemplateTitles");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasComment("Extra description of template purpose");
            entity.Property(e => e.LastEdited).HasColumnType("datetime");
            entity.Property(e => e.LastEditedByUserId).HasColumnName("LastEditedByUserID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasComment("LGA short code from from tblLGA")
                .HasColumnName("LGAid");
            entity.Property(e => e.LockedBy).HasMaxLength(100);
            entity.Property(e => e.LockedTime).HasColumnType("datetime");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasComment("Template title");
        });

        modelBuilder.Entity<TblFfpassessmentScheme>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("tblFFPassessmentSchemes$PrimaryKey")
                .HasFillFactor(90);

            entity.ToTable("tblFFPassessmentSchemes");

            entity.HasIndex(e => e.Lgaid, "tblFFPassessmentSchemes$LGAid").HasFillFactor(90);

            entity.HasIndex(e => e.ScoreSystemId, "tblFFPassessmentSchemes$ScoreSystemID").HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasComment("SchemeID")
                .HasColumnName("ID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasComment("Short code from tblLGA")
                .HasColumnName("LGAid");
            entity.Property(e => e.OverallScoreMethod)
                .HasMaxLength(9)
                .HasDefaultValue("SecWtAvg")
                .HasComment("Method to determine overall score(s): Manual, SecSum, SecAvg, SecWtAvg, QSum, QAvg, QWtAvg");
            entity.Property(e => e.Response1title)
                .HasMaxLength(50)
                .HasDefaultValue("not set")
                .HasComment("Short name / title for Response 2 (e.g. 'FFP now')");
            entity.Property(e => e.Response2title)
                .HasMaxLength(50)
                .HasDefaultValue("not set")
                .HasComment("Short name / title for Response 2 (e.g. 'Suggested solutions')");
            entity.Property(e => e.Score1title)
                .HasMaxLength(50)
                .HasDefaultValue("not set")
                .HasComment("Short name / title for Score 1 (e.g. 'FFP now')");
            entity.Property(e => e.Score2title)
                .HasMaxLength(50)
                .HasDefaultValue("not set")
                .HasComment("Short name / title for Score 2 (e.g. 'FFP future')");
            entity.Property(e => e.ScoreBy)
                .HasMaxLength(9)
                .HasDefaultValue("Sections")
                .HasComment("Questions or Sections");
            entity.Property(e => e.ScoreSystemId)
                .HasComment("ID from tblScoreSysTitles")
                .HasColumnName("ScoreSystemID");
            entity.Property(e => e.SectionScoreMethod)
                .HasMaxLength(6)
                .HasDefaultValue("Manual")
                .HasComment("Method to determine section scores: Manual (manual entry), Sum, Avg (sum or simple average of question scores, ONLY where questions scored)");
            entity.Property(e => e.ShowScoreDescriptions)
                .HasDefaultValue(false)
                .HasComment("Show a short textual description / explanation next to each selected score e.g 'No impact' or 'Moderate impact'");
            entity.Property(e => e.UseHelpComments)
                .HasDefaultValue(false)
                .HasComment("Option to provide prompts / additional comments next to each question to aid respondees\n");
            entity.Property(e => e.UseOverallScore)
                .HasDefaultValue(false)
                .HasComment("Option to calculate at least 1 overall assessment (facility) score");
            entity.Property(e => e.UseOverallScoreRanges).HasDefaultValue(false);
            entity.Property(e => e.UseResponse2)
                .HasDefaultValue(false)
                .HasComment("Option to require a 2nd response");
            entity.Property(e => e.UseResponseSelections1)
                .HasDefaultValue(false)
                .HasComment("Option to use drop-down selection responses as well as text response #1");
            entity.Property(e => e.UseResponseSelections2)
                .HasDefaultValue(false)
                .HasComment("Option to use drop-down selection responses as well as text response #2");
            entity.Property(e => e.UseScore2)
                .HasDefaultValue(false)
                .HasComment("Option to select whether a 2nd score is required");
            entity.Property(e => e.UseSectionScores)
                .HasDefaultValue(false)
                .HasComment("Option to require at least 1 score for each section / category");
            entity.Property(e => e.UseSectionSummaries)
                .HasDefaultValue(false)
                .HasComment("Option to use text summaries for each section / category for which the value in tblFFPtemplateSections.SummaryRequired = Yes");
        });

        modelBuilder.Entity<TblFfpasstLog>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("tblFFPasstLog$PrimaryKey")
                .HasFillFactor(90);

            entity.ToTable("tblFFPasstLog");

            entity.HasIndex(e => e.StatusId, "IX_tblFFPasslog_StatusId");

            entity.HasIndex(e => e.FacilityId, "tblFFPasstLog$FacilityId").HasFillFactor(90);

            entity.HasIndex(e => e.InfTypeId, "tblFFPasstLog$InfTypeID").HasFillFactor(90);

            entity.HasIndex(e => e.TemplateId, "tblFFPasstLog$TemplateID").HasFillFactor(90);

            entity.HasIndex(e => e.TemplateId, "tblFFPasstLog${3544CEF8-C9B5-4DBC-A824-8C41FBFB7319}").HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasComment("LogID")
                .HasColumnName("ID");
            entity.Property(e => e.AssessmentDate)
                .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))")
                .HasComment("Date the assessment was completed or last updated")
                .HasColumnType("datetime");
            entity.Property(e => e.AssessmentNotes).HasComment("Additional comments on the assessment");
            entity.Property(e => e.AssessmentPersons)
                .HasMaxLength(255)
                .HasComment("Name(s) of assessor and/or respondees");
            entity.Property(e => e.FacilityId)
                .HasComment("ID from tblFacilities")
                .HasColumnName("FacilityID");
            entity.Property(e => e.InfTypeId)
                .HasComment("ID from tblInfType")
                .HasColumnName("InfTypeID");
            entity.Property(e => e.LastEdited).HasColumnType("datetime");
            entity.Property(e => e.LastEditedBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.StatusId).HasDefaultValue(4);
            entity.Property(e => e.TemplateId)
                .HasComment("ID from tblFFPtemplateTitles")
                .HasColumnName("TemplateID");

            entity.HasOne(d => d.Status).WithMany(p => p.TblFfpasstLogs)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FFPasstLog_AssessmentStatus");

            entity.HasOne(d => d.Template).WithMany(p => p.TblFfpasstLogs)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("tblFFPasstLog${3544CEF8-C9B5-4DBC-A824-8C41FBFB7319}");
        });

        modelBuilder.Entity<TblFfpasstQuestionResponse>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("tblFFPasstQuestionResponses$PrimaryKey")
                .HasFillFactor(90);

            entity.ToTable("tblFFPasstQuestionResponses");

            entity.HasIndex(e => e.Id, "tblFFPasstQuestionResponses$ID").HasFillFactor(90);

            entity.HasIndex(e => e.LogId, "tblFFPasstQuestionResponses$LogID").HasFillFactor(90);

            entity.HasIndex(e => e.QuestionId, "tblFFPasstQuestionResponses$QuestionID").HasFillFactor(90);

            entity.HasIndex(e => e.Selection1Id, "tblFFPasstQuestionResponses$Selection1ID").HasFillFactor(90);

            entity.HasIndex(e => e.Selection2Id, "tblFFPasstQuestionResponses$Selection2ID").HasFillFactor(90);

            entity.HasIndex(e => e.QuestionId, "tblFFPasstQuestionResponses${68124A89-9BA9-48E2-A02E-C33B9117F656}").HasFillFactor(90);

            entity.HasIndex(e => e.LogId, "tblFFPasstQuestionResponses${DF2041E5-D0A1-4C04-B536-6199E2187A9F}").HasFillFactor(90);

            entity.HasIndex(e => e.Selection1Id, "tblFFPasstQuestionResponses${E0C4058A-4A93-46E6-8E6E-BEA63A187C1F}").HasFillFactor(90);

            entity.HasIndex(e => e.Selection2Id, "tblFFPasstQuestionResponses${E159A6AD-3CF1-4D8F-89BF-B47C62475BA0}").HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasComment("TextResponseID")
                .HasColumnName("ID");
            entity.Property(e => e.LogId)
                .HasComment("ID from tblFFPasstLog")
                .HasColumnName("LogID");
            entity.Property(e => e.Qscore1)
                .HasDefaultValue(0)
                .HasComment("Numeric score #1 for question");
            entity.Property(e => e.Qscore2)
                .HasDefaultValue(0)
                .HasComment("Numeric score #2 for question");
            entity.Property(e => e.QuestionId)
                .HasComment("ID from tblFFPtemplateQuestions")
                .HasColumnName("QuestionID");
            entity.Property(e => e.ResponseText1).HasComment("Text response to each question (optional)");
            entity.Property(e => e.ResponseText2).HasComment("Text response to each question (optional)");
            entity.Property(e => e.Selection1Id)
                .HasDefaultValue(1)
                .HasComment("ID from tblFFPasstSelections")
                .HasColumnName("Selection1ID");
            entity.Property(e => e.Selection2Id)
                .HasDefaultValue(1)
                .HasComment("ID from tblFFPasstSelections")
                .HasColumnName("Selection2ID");

            entity.HasOne(d => d.Log).WithMany(p => p.TblFfpasstQuestionResponses)
                .HasForeignKey(d => d.LogId)
                .HasConstraintName("tblFFPasstQuestionResponses${DF2041E5-D0A1-4C04-B536-6199E2187A9F}");

            entity.HasOne(d => d.Question).WithMany(p => p.TblFfpasstQuestionResponses)
                .HasForeignKey(d => d.QuestionId)
                .HasConstraintName("tblFFPasstQuestionResponses${68124A89-9BA9-48E2-A02E-C33B9117F656}");

            entity.HasOne(d => d.Selection1).WithMany(p => p.TblFfpasstQuestionResponseSelection1s)
                .HasForeignKey(d => d.Selection1Id)
                .HasConstraintName("tblFFPasstQuestionResponses${E0C4058A-4A93-46E6-8E6E-BEA63A187C1F}");

            entity.HasOne(d => d.Selection2).WithMany(p => p.TblFfpasstQuestionResponseSelection2s)
                .HasForeignKey(d => d.Selection2Id)
                .HasConstraintName("tblFFPasstQuestionResponses${E159A6AD-3CF1-4D8F-89BF-B47C62475BA0}");
        });

        modelBuilder.Entity<TblFfpasstSectionResponse>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("tblFFPasstSectionResponses$PrimaryKey")
                .HasFillFactor(90);

            entity.ToTable("tblFFPasstSectionResponses");

            entity.HasIndex(e => e.LogId, "tblFFPasstSectionResponses$LogID").HasFillFactor(90);

            entity.HasIndex(e => e.SectionId, "tblFFPasstSectionResponses$SectionID").HasFillFactor(90);

            entity.HasIndex(e => e.SectionId, "tblFFPasstSectionResponses${06C7A963-F808-4190-B7CE-6623F70DE5AF}").HasFillFactor(90);

            entity.HasIndex(e => e.LogId, "tblFFPasstSectionResponses${5C4621F7-BDA0-412F-9EB9-2A3972F24596}").HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasComment("SummaryID")
                .HasColumnName("ID");
            entity.Property(e => e.LogId)
                .HasComment("ID from tblFFPasstLog")
                .HasColumnName("LogID");
            entity.Property(e => e.SectionId)
                .HasComment("ID from tblFFPtemplateSection")
                .HasColumnName("SectionID");
            entity.Property(e => e.SectionScore1)
                .HasComment("Numeric score #1 for section")
                .HasColumnType("decimal(6, 2)");
            entity.Property(e => e.SectionScore2)
                .HasComment("Numeric score #2 for section")
                .HasColumnType("decimal(6, 2)");
            entity.Property(e => e.Summary).HasComment("Text summary of responses to questions within the section/category");

            entity.HasOne(d => d.Log).WithMany(p => p.TblFfpasstSectionResponses)
                .HasForeignKey(d => d.LogId)
                .HasConstraintName("tblFFPasstSectionResponses${5C4621F7-BDA0-412F-9EB9-2A3972F24596}");

            entity.HasOne(d => d.Section).WithMany(p => p.TblFfpasstSectionResponses)
                .HasForeignKey(d => d.SectionId)
                .HasConstraintName("tblFFPasstSectionResponses${06C7A963-F808-4190-B7CE-6623F70DE5AF}");
        });

        modelBuilder.Entity<TblFfpasstSelection>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("tblFFPasstSelections$PrimaryKey")
                .HasFillFactor(90);

            entity.ToTable("tblFFPasstSelections");

            entity.HasIndex(e => e.TemplateId, "tblFFPasstSelections$TemplateID").HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasComment("SelectionID")
                .HasColumnName("ID");
            entity.Property(e => e.FormatColour)
                .HasDefaultValue(16777215)
                .HasComment("Access VBA value for conditional formatting backcolour of text box");
            entity.Property(e => e.SchemeId).HasColumnName("SchemeID");
            entity.Property(e => e.SelectionOrder).HasComment("Order that each option appears in the list");
            entity.Property(e => e.SelectionPrompt)
                .HasMaxLength(50)
                .HasComment("Text prompt to indicate whether a text response (record in tblFFPasstTextResponses) is required or optional (50 chars max)");
            entity.Property(e => e.SelectionText)
                .HasMaxLength(50)
                .HasComment("Text for each drop-down option (50 chars max)");
            entity.Property(e => e.TemplateId)
                .HasDefaultValue(0)
                .HasComment("ID from tblFFPtemplateTitles")
                .HasColumnName("TemplateID");
        });

        modelBuilder.Entity<TblFfpcommentType>(entity =>
        {
            entity.ToTable("tblFFPcommentTypes");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CommentText).HasMaxLength(255);
            entity.Property(e => e.CommentType).HasMaxLength(100);
        });

        modelBuilder.Entity<TblFfpscoreSysOverride>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("tblFFPScoreSysOverrides$PrimaryKey")
                .HasFillFactor(90);

            entity.ToTable("tblFFPScoreSysOverrides");

            entity.HasIndex(e => e.LogId, "tblFFPScoreSysOverrides$FacilityID").HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasComment("OverrideID")
                .HasColumnName("ID");
            entity.Property(e => e.Explanation).HasComment("Long text explanation of the rationale for applying the override");
            entity.Property(e => e.LogId)
                .HasComment("ID from tblFacilities")
                .HasColumnName("LogID");
            entity.Property(e => e.Score1Applied)
                .HasDefaultValue(false)
                .HasComment("Yes, where override is applied. No, only where an override has been applied previously but has since been de-applied");
            entity.Property(e => e.Score1override).HasComment("Score1 or Score2 (if in use) e.g. FFP now and FFP future (optional)");
            entity.Property(e => e.Score2Applied).HasDefaultValue(false);
            entity.Property(e => e.Score2override).HasComment("Numeric score to override calculated overall score");
        });

        modelBuilder.Entity<TblFfpscoreSysRange>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("tblFFPScoreSysRanges$PrimaryKey")
                .HasFillFactor(90);

            entity.ToTable("tblFFPScoreSysRanges");

            entity.HasIndex(e => e.ScoreSystemId, "tblFFPScoreSysRanges$ScoreSysTitleID").HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasComment("ScoreSysRangeID")
                .HasColumnName("ID");
            entity.Property(e => e.AppliesTo)
                .HasMaxLength(9)
                .HasComment("Questions, Sections or Overall");
            entity.Property(e => e.FormatColour)
                .HasDefaultValue(16777215)
                .HasComment("Access VBA value for conditional formatting backcolour of text box");
            entity.Property(e => e.RangeOrder).HasComment("Numeric hierarchy for ranges, where 1 = BEST POSITIVE range");
            entity.Property(e => e.RangeText)
                .HasMaxLength(100)
                .HasComment("Short text value for each range (100 chars max)");
            entity.Property(e => e.ScoreLower)
                .HasComment("Lowest numeric score that range applies to; score is INCLUDED in range (>=)")
                .HasColumnType("decimal(12, 2)");
            entity.Property(e => e.ScoreSystemId)
                .HasComment("ID from tblFFPscoreSysTitles")
                .HasColumnName("ScoreSystemID");
            entity.Property(e => e.ScoreUpper)
                .HasComment("Highest numeric score that range applies to; score is EXCLUDED from range (<)")
                .HasColumnType("decimal(12, 2)");
        });

        modelBuilder.Entity<TblFfpscoreSysScore>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("tblFFPScoreSysScores$PrimaryKey")
                .HasFillFactor(90);

            entity.ToTable("tblFFPScoreSysScores");

            entity.HasIndex(e => e.ScoreSysTitleId, "tblFFPScoreSysScores$ScoreSysTilteID").HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasComment("ScoreSysScoreID")
                .HasColumnName("ID");
            entity.Property(e => e.AppliesTo)
                .HasMaxLength(9)
                .HasComment("Questions, Sections or Overall");
            entity.Property(e => e.Description)
                .HasMaxLength(60)
                .HasComment("Additional explanation or definiton of score / text value meaning (150 chars max)");
            entity.Property(e => e.DisplayAs)
                .HasMaxLength(7)
                .HasDefaultValue("Number")
                .HasComment("Number, Percent or Text");
            entity.Property(e => e.Score)
                .HasComment("Numeric (or percentage?) score")
                .HasColumnType("decimal(6, 2)");
            entity.Property(e => e.ScoreOrder).HasComment("Numeric order in which scores appear in list, where 1 = highest or BEST POSITIVE score.");
            entity.Property(e => e.ScoreSysTitleId)
                .HasComment("ID from tblScoreSysTitles")
                .HasColumnName("ScoreSysTitleID");
            entity.Property(e => e.ShownValue)
                .HasMaxLength(25)
                .HasComment("Where .DisplayAs = Number, shown = number. Where .DisplayAs = Percent, shown = number & \"%\". Where .DisplayAs = Text, shown = entered text value");
        });

        modelBuilder.Entity<TblFfpscoreSysTitle>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("tblFFPScoreSysTitles$PrimaryKey")
                .HasFillFactor(90);

            entity.ToTable("tblFFPScoreSysTitles");

            entity.HasIndex(e => e.Lgaid, "tblFFPScoreSysTitles$LGAid").HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasComment("ScoreSystemID")
                .HasColumnName("ID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasComment("LGA short code from from tblLGA")
                .HasColumnName("LGAid");
            entity.Property(e => e.ModificationPercent).HasColumnType("decimal(3, 2)");
            entity.Property(e => e.Title)
                .HasMaxLength(150)
                .HasComment("Score system title (150 chars max)");
        });

        modelBuilder.Entity<TblFfptemplateQuestion>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("tblFFPtemplateQuestions$PrimaryKey")
                .HasFillFactor(90);

            entity.ToTable("tblFFPtemplateQuestions");

            entity.HasIndex(e => e.Id, "tblFFPtemplateQuestions$ID").HasFillFactor(90);

            entity.HasIndex(e => e.SectionId, "tblFFPtemplateQuestions$SectionID").HasFillFactor(90);

            entity.HasIndex(e => e.SectionId, "tblFFPtemplateQuestions${6E3221BB-E874-4143-8768-D712EA64A5AD}").HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasComment("QuestionID")
                .HasColumnName("ID");
            entity.Property(e => e.HelpComments)
                .HasMaxLength(255)
                .HasComment("Comments / prompts to help respondees answer the question");
            entity.Property(e => e.QuestionOrder).HasComment("Numeric order that questions appear in");
            entity.Property(e => e.QuestionText)
                .HasMaxLength(150)
                .HasDefaultValue("")
                .HasComment("Question text (max 150 characters)");
            entity.Property(e => e.QuestionTitle)
                .HasMaxLength(110)
                .HasComment("Short title or name for each question (max 100 characters)");
            entity.Property(e => e.SectionId)
                .HasComment("ID from tblFFPtemplateSections")
                .HasColumnName("SectionID");
            entity.Property(e => e.Subsection)
                .HasMaxLength(5)
                .HasComment("Numeric or character suffix to section number (e.g. 'a', 'b', or 'i', 'ii', or '-1', '-2')");

            entity.HasOne(d => d.Section).WithMany(p => p.TblFfptemplateQuestions)
                .HasForeignKey(d => d.SectionId)
                .HasConstraintName("tblFFPtemplateQuestions${6E3221BB-E874-4143-8768-D712EA64A5AD}");
        });

        modelBuilder.Entity<TblFfptemplateSection>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("tblFFPtemplateSections$PrimaryKey")
                .HasFillFactor(90);

            entity.ToTable("tblFFPtemplateSections");

            entity.HasIndex(e => e.TemplateId, "tblFFPtemplateSections$TemplateID").HasFillFactor(90);

            entity.HasIndex(e => e.TemplateId, "tblFFPtemplateSections${7F7F5171-D9A1-4492-9DB6-A4BA79986BAE}").HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasComment("SectionID")
                .HasColumnName("ID");
            entity.Property(e => e.AssetComment).HasDefaultValue(false);
            entity.Property(e => e.CommentNumber).HasComment("Section / category number");
            entity.Property(e => e.GenComment).HasDefaultValue(false);
            entity.Property(e => e.LockedDateTimeString).HasMaxLength(50);
            entity.Property(e => e.SectionNumber).HasComment("Section / category number");
            entity.Property(e => e.SectionTitle)
                .HasMaxLength(150)
                .HasComment("Section / category name");
            entity.Property(e => e.SummaryRequired)
                .HasDefaultValue(false)
                .HasComment("Is a record in tblFFPasstSectionSummaries required? i.e. is a summary comment for this section/category required?\n");
            entity.Property(e => e.TemplateId)
                .HasComment("ID from tblFFPtemplateTitles")
                .HasColumnName("TemplateID");
            entity.Property(e => e.WeightPercent)
                .HasComment("The % weighting, where this section contributes to an overall facility score. Must be 100 or less.")
                .HasColumnType("decimal(3, 1)");

            entity.HasOne(d => d.Template).WithMany(p => p.TblFfptemplateSections)
                .HasForeignKey(d => d.TemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tblFFPtemplateSections${7F7F5171-D9A1-4492-9DB6-A4BA79986BAE}");
        });

        modelBuilder.Entity<TblFfptemplateTitle>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("tblFFPtemplateTitles$PrimaryKey")
                .HasFillFactor(90);

            entity.ToTable("tblFFPtemplateTitles");

            entity.HasIndex(e => e.Lgaid, "tblFFPtemplateTitles$LGAid").HasFillFactor(90);

            entity.HasIndex(e => e.SchemeId, "tblFFPtemplateTitles$SchemeID").HasFillFactor(90);

            entity.HasIndex(e => e.SchemeId, "tblFFPtemplateTitles${1659F811-9644-4D20-AA65-B4E95824465C}").HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasComment("Template ID")
                .HasColumnName("ID");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasComment("Extra description of template purpose");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasComment("LGA short code from from tblLGA")
                .HasColumnName("LGAid");
            entity.Property(e => e.SchemeId)
                .HasDefaultValue(0)
                .HasComment("ID from tblFFPassessmentSchemes")
                .HasColumnName("SchemeID");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasComment("Template title");

            entity.HasOne(d => d.Scheme).WithMany(p => p.TblFfptemplateTitles)
                .HasForeignKey(d => d.SchemeId)
                .HasConstraintName("tblFFPtemplateTitles${1659F811-9644-4D20-AA65-B4E95824465C}");
        });

        modelBuilder.Entity<TblFfptemplatesByInfType>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("tblFFPtemplatesByInfType$PrimaryKey")
                .HasFillFactor(90);

            entity.ToTable("tblFFPtemplatesByInfType");

            entity.HasIndex(e => e.Id, "tblFFPtemplatesByInfType$ID").HasFillFactor(90);

            entity.HasIndex(e => e.InfTypeId, "tblFFPtemplatesByInfType$InfTypeID").HasFillFactor(90);

            entity.HasIndex(e => e.Lgaid, "tblFFPtemplatesByInfType$LGAid").HasFillFactor(90);

            entity.HasIndex(e => e.TemplateId, "tblFFPtemplatesByInfType$TemplateID").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InfTypeId)
                .HasComment("ID from tblInfType")
                .HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasComment("LGA short code from from tblLGA")
                .HasColumnName("LGAid");
            entity.Property(e => e.Status)
                .HasMaxLength(7)
                .HasDefaultValue("Primary")
                .HasComment("Primary or Test");
            entity.Property(e => e.TemplateId)
                .HasComment("ID from tblFFPtemplateTitle")
                .HasColumnName("TemplateID");
        });

        modelBuilder.Entity<TblForecastAreasCopy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblForecastAreasCopy");

            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryName).HasMaxLength(120);
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.Suburb).HasMaxLength(120);
        });

        modelBuilder.Entity<TblHierarchy>(entity =>
        {
            entity.HasKey(e => e.HierarchyId)
                .HasName("aaaaatblHierarchy_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblHierarchy");

            entity.HasIndex(e => e.Hierarchy, "Hierarchy")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => e.HierarchyId, "ID").HasFillFactor(90);

            entity.Property(e => e.HierarchyId)
                .HasComment("Unique ID for the entry in the provision hierarchy")
                .HasColumnName("HierarchyID");
            entity.Property(e => e.Hierarchy)
                .HasMaxLength(25)
                .HasComment("Strategic hierarchy of provision (local, neighbourhood, district, regional)");
            entity.Property(e => e.Order)
                .HasDefaultValue(0)
                .HasComment("Hierarchy of types");
        });

        modelBuilder.Entity<TblHierarchyExampleLevel>(entity =>
        {
            entity.ToTable("tblHierarchy_ExampleLevels");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.HierarchyExampleLevel)
                .HasMaxLength(100)
                .HasColumnName("Hierarchy_ExampleLevel");
            entity.Property(e => e.HierarchyExampleNameId)
                .HasComment("4 digit LGAid for the municipality in which the facility is located")
                .HasColumnName("Hierarchy_ExampleNameID");
        });

        modelBuilder.Entity<TblHierarchyExampleName>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Hierarchy_ExampleNames");

            entity.ToTable("tblHierarchy_ExampleNames");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.HierarchyName).HasMaxLength(100);
        });

        modelBuilder.Entity<TblHierarchyLevel>(entity =>
        {
            entity.HasKey(e => e.HierarchyLevelId);

            entity.ToTable("tblHierarchyLevels");

            entity.Property(e => e.HierarchyLevelId).HasColumnName("HierarchyLevelID");
            entity.Property(e => e.HierarchyLevel).HasMaxLength(100);
            entity.Property(e => e.HierarchyNameId)
                .HasComment("4 digit LGAid for the municipality in which the facility is located")
                .HasColumnName("HierarchyNameID");

            entity.HasOne(d => d.HierarchyName).WithMany(p => p.TblHierarchyLevels)
                .HasForeignKey(d => d.HierarchyNameId)
                .HasConstraintName("FK_tblHierarchyLevels_tblHierarchyNames");
        });

        modelBuilder.Entity<TblHierarchyName>(entity =>
        {
            entity.HasKey(e => e.HierarchyNameId).HasName("PK_HierarchyNames");

            entity.ToTable("tblHierarchyNames");

            entity.Property(e => e.HierarchyNameId).HasColumnName("HierarchyNameID");
            entity.Property(e => e.AddedBy).HasMaxLength(100);
            entity.Property(e => e.AddedTime).HasColumnType("datetime");
            entity.Property(e => e.ChangedBy).HasMaxLength(100);
            entity.Property(e => e.ChangedTime).HasColumnType("datetime");
            entity.Property(e => e.HierarchyName).HasMaxLength(100);
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasComment("4 digit LGAid for the municipality in which the facility is located")
                .HasColumnName("LGAid");
            entity.Property(e => e.LockedBy).HasMaxLength(100);
            entity.Property(e => e.LockedTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblInfClass>(entity =>
        {
            entity.HasKey(e => e.InfClassId)
                .HasName("aaaaatblInfClass_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblInfClass", tb =>
                {
                    tb.HasComment("Tier 2 of the typology - infrastructure classes that may require further definition as infrastructure types");
                    tb.HasTrigger("InfGroupID_OnUpdate");
                });

            entity.HasIndex(e => e.InfClassId, "ID").HasFillFactor(90);

            entity.HasIndex(e => e.Class, "InfrastructureClass")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => e.InfGroupId, "ServiceClass").HasFillFactor(90);

            entity.Property(e => e.InfClassId)
                .HasComment("Unique ID for each infrastructure class")
                .HasColumnName("InfClassID");
            entity.Property(e => e.Class)
                .HasMaxLength(100)
                .HasComment("Infrastructure Class is the second tier of the typology and is the first breakdown of infrastructure under the Infrastructure Group");
            entity.Property(e => e.InfGroupId)
                .HasDefaultValue(0)
                .HasComment("Related Infrastructure Group ID from tblInfGroup")
                .HasColumnName("InfGroupID");
        });

        modelBuilder.Entity<TblInfGroup>(entity =>
        {
            entity.HasKey(e => e.InfGroupId)
                .HasName("aaaaatblInfGroup_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblInfGroup", tb => tb.HasComment("Tier 1 of the typology - broad service groupings (class)"));

            entity.HasIndex(e => e.Group, "ServiceClass")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.InfGroupId)
                .HasComment("Unique ID for the Infrastructure Group")
                .HasColumnName("InfGroupID");
            entity.Property(e => e.Group)
                .HasMaxLength(100)
                .HasComment("Infrastructure Group is the highest tier of the typology. This is the broadest grouping of infrastructure types.");
        });

        modelBuilder.Entity<TblInfType>(entity =>
        {
            entity.HasKey(e => e.InfTypeId)
                .HasName("aaaaatblInfType_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblInfType", tb =>
                {
                    tb.HasComment("Tier 3 of the typology - specific and unique names for each infrastructure type. Provision standards are based on infrastructure types.");
                    tb.HasTrigger("InfType_OnDelete");
                });

            entity.HasIndex(e => e.InfTypeId, "ID").HasFillFactor(90);

            entity.HasIndex(e => e.InfClassId, "InfrastructureClass").HasFillFactor(90);

            entity.HasIndex(e => e.Type, "Infrastructure_type_detail")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.InfTypeId)
                .HasComment("Unique ID for each Infrastructure Class")
                .HasColumnName("InfTypeID");
            entity.Property(e => e.DefaultCohortId).HasColumnName("DefaultCohortID");
            entity.Property(e => e.DefaultUnitTypeId).HasColumnName("DefaultUnitTypeID");
            entity.Property(e => e.Definition)
                .HasDefaultValue("")
                .HasComment("Description of the Use")
                .HasColumnType("ntext");
            entity.Property(e => e.InfClassId)
                .HasDefaultValue(0)
                .HasComment("Related Infrastructure Class ID from tblInfClass")
                .HasColumnName("InfClassID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasComment("4 digit LGAid for the municipality in which the facility is located")
                .HasColumnName("LGAid");
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .HasComment("Infrastructure Type is the third and finest tier of the typology and is the specific unique name assigned to distinct types of infrastructure.");
        });

        modelBuilder.Entity<TblInfTypeCohort>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("tblInfType_Cohorts");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddedBy).HasMaxLength(100);
            entity.Property(e => e.AddedTime).HasColumnType("datetime");
            entity.Property(e => e.ChangedBy).HasMaxLength(100);
            entity.Property(e => e.ChangedTime).HasColumnType("datetime");
            entity.Property(e => e.InfTypeId)
                .HasDefaultValue(0)
                .HasComment("Lookup tblInfType")
                .HasColumnName("InfTypeID");
            entity.Property(e => e.LockedBy).HasMaxLength(100);
            entity.Property(e => e.LockedTime).HasColumnType("datetime");
            entity.Property(e => e.PreferredCohortId)
                .HasDefaultValue(0)
                .HasComment("ID of the cohort preferred by user")
                .HasColumnName("PreferredCohortID");
            entity.Property(e => e.Ts)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ts");
            entity.Property(e => e.UserLgaid)
                .HasMaxLength(4)
                .HasComment("User ID")
                .HasColumnName("UserLGAid");
        });

        modelBuilder.Entity<TblInfTypeHierarchyAttribute>(entity =>
        {
            entity.HasKey(e => new { e.InfTypeId, e.Lgaid });

            entity.ToTable("tblInfType_Hierarchy_Attribute");

            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasComment("4 digit LGAid for the municipality in which the facility is located")
                .HasColumnName("LGAid");
            entity.Property(e => e.AttributeName1Id)
                .HasDefaultValue(0)
                .HasColumnName("AttributeName1ID");
            entity.Property(e => e.AttributeName2Id)
                .HasDefaultValue(0)
                .HasColumnName("AttributeName2ID");
            entity.Property(e => e.HierarchyNameId)
                .HasDefaultValue(0)
                .HasColumnName("HierarchyNameID");
        });

        modelBuilder.Entity<TblInfTypeUnit>(entity =>
        {
            entity.HasKey(e => e.InfTypeUnitId)
                .HasName("aaaaatblInfTypeUnits_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblInfTypeUnits", tb => tb.HasTrigger("InfTypeUnits_OnDelete"));

            entity.HasIndex(e => e.InfTypeUnitId, "ID").HasFillFactor(90);

            entity.HasIndex(e => e.InfTypeId, "InfTypeID").HasFillFactor(90);

            entity.HasIndex(e => e.UnitTypeId, "UnitType").HasFillFactor(90);

            entity.HasIndex(e => e.UnitTypeId, "tblUnitTypestblInfTypeUnits").HasFillFactor(90);

            entity.Property(e => e.InfTypeUnitId)
                .HasComment("Unique ID for the relationship between ifn types and applicable unit types")
                .HasColumnName("InfTypeUnitID");
            entity.Property(e => e.InfTypeId)
                .HasDefaultValue(0)
                .HasComment("Unique ID of the infrastructure type to which the unit measure applies")
                .HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.UnitTypeId)
                .HasComment("Lookup to unit types")
                .HasColumnName("UnitTypeID");

            entity.HasOne(d => d.InfType).WithMany(p => p.TblInfTypeUnits)
                .HasForeignKey(d => d.InfTypeId)
                .HasConstraintName("tblInfTypeUnits_FK00");

            entity.HasOne(d => d.UnitType).WithMany(p => p.TblInfTypeUnits)
                .HasForeignKey(d => d.UnitTypeId)
                .HasConstraintName("tblInfTypeUnits_FK01");
        });

        modelBuilder.Entity<TblIntersectingForecastArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblIntersectingForecastAreas");

            entity.Property(e => e.FromBoundaryId).HasColumnName("FromBoundaryID");
            entity.Property(e => e.FromBoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("FromBoundaryLGAID");
            entity.Property(e => e.FromBoundaryName).HasMaxLength(120);
            entity.Property(e => e.ToBoundaryId).HasColumnName("ToBoundaryID");
            entity.Property(e => e.ToBoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("ToBoundaryLGAID");
            entity.Property(e => e.ToBoundaryName).HasMaxLength(120);
        });

        modelBuilder.Entity<TblKinderLdcmodelDefaultConstant>(entity =>
        {
            entity.ToTable("tblKinderLDCmodel_DefaultConstants");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ConTypes).HasMaxLength(50);
            entity.Property(e => e.DefaultValue).HasMaxLength(50);
        });

        modelBuilder.Entity<TblKinderLdcmodelDefaultVariable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblKinderLDCmodel_StdVariableTypes");

            entity.ToTable("tblKinderLDCmodel_DefaultVariables");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DefaultValue).HasMaxLength(50);
            entity.Property(e => e.FacilityVariable).HasDefaultValue(false);
            entity.Property(e => e.VarTypes).HasMaxLength(50);
            entity.Property(e => e.YearVariable).HasDefaultValue(false);
        });

        modelBuilder.Entity<TblKinderLdcmodelGlobalAssumptionsDelete>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblKinderLDCmodel_GlobalAssumptions");

            entity.ToTable("tblKinderLDCmodel_GlobalAssumptionsDELETE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GlobalAdjustmentRateLdc)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(3, 2)")
                .HasColumnName("GlobalAdjustmentRate_LDC");
            entity.Property(e => e.GlobalAdjustmentRatePreschoolChangeMgmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(3, 2)")
                .HasColumnName("GlobalAdjustmentRate_Preschool_ChangeMgmt");
            entity.Property(e => e.GlobalAdjustmentRatePreschoolStdMgmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(3, 2)")
                .HasColumnName("GlobalAdjustmentRate_Preschool_StdMgmt");
            entity.Property(e => e.GlobalCapacityMultiplierLdc)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(3, 2)")
                .HasColumnName("GlobalCapacityMultiplier_LDC");
            entity.Property(e => e.GlobalCapacityMultiplierPreschoolChangeMgmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(3, 2)")
                .HasColumnName("GlobalCapacityMultiplier_Preschool_ChangeMgmt");
            entity.Property(e => e.GlobalCapacityMultiplierPreschoolStdMgmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(3, 2)")
                .HasColumnName("GlobalCapacityMultiplier_Preschool_StdMgmt");
            entity.Property(e => e.GlobalEnrolmentDataYear).HasDefaultValue(0);
            entity.Property(e => e.ModellingLgaid)
                .HasMaxLength(4)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasColumnName("Modelling_LGAid");
        });

        modelBuilder.Entity<TblKinderLdcmodelInclFacility>(entity =>
        {
            entity.ToTable("tblKinderLDCmodel_InclFacilities");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FacilityId)
                .HasDefaultValue(0)
                .HasColumnName("FacilityID");
            entity.Property(e => e.FacilityLgaid)
                .HasMaxLength(4)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasColumnName("Facility_LGAid");
            entity.Property(e => e.ModellingLgaid)
                .HasMaxLength(4)
                .HasDefaultValueSql("((0))")
                .IsFixedLength()
                .HasColumnName("Modelling_LGAid");
        });

        modelBuilder.Entity<TblKinderLdcmodelInclForecastArea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblIncludeForecastAreaLookup");

            entity.ToTable("tblKinderLDCmodel_InclForecastAreas");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IncludeForecastAreaId).HasColumnName("IncludeForecastAreaID");
            entity.Property(e => e.IncludeForecastAreaLgaid)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("IncludeForecastArea_LGAid");
            entity.Property(e => e.ModellingLgaid)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("Modelling_LGAid");
        });

        modelBuilder.Entity<TblKinderLdcmodelInclSa2>(entity =>
        {
            entity.ToTable("tblKinderLDCmodel_InclSA2");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IncludeSa2BoundaryId)
                .HasDefaultValue(0)
                .HasColumnName("IncludeSA2_BoundaryID");
            entity.Property(e => e.ModellingLgaid)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("Modelling_LGAid");
            entity.Property(e => e.OldIncludeSa2BoundaryId).HasColumnName("OLD_IncludeSA2_BoundaryID");
            entity.Property(e => e.PopEstimateType)
                .HasMaxLength(50)
                .HasDefaultValue("(DE midpoints)");
        });

        modelBuilder.Entity<TblKinderLdcmodelKispdatum>(entity =>
        {
            entity.ToTable("tblKinderLDCmodel_KISPdata");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataTitle).HasMaxLength(100);
            entity.Property(e => e.DataType).HasMaxLength(100);
            entity.Property(e => e.ModellingLgaid)
                .HasMaxLength(50)
                .HasColumnName("ModellingLGAid");
            entity.Property(e => e.OldSa2areaId).HasColumnName("OLD_SA2areaID");
            entity.Property(e => e.Sa2areaId)
                .HasDefaultValue(0)
                .HasColumnName("SA2areaID");
        });

        modelBuilder.Entity<TblKinderLdcmodelServiceDataSharing>(entity =>
        {
            entity.ToTable("tblKinderLDCmodel_ServiceDataSharing");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SharedWithLgaid)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("SharedWithLGAid");
            entity.Property(e => e.SharingLgaid)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("SharingLGAid");
        });

        modelBuilder.Entity<TblKinderLdcmodelServiceDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblKinderLDCmodel");

            entity.ToTable("tblKinderLDCmodel_ServiceData");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AcecqaserviceApprovalId)
                .HasMaxLength(50)
                .HasDefaultValue("unknown")
                .HasColumnName("ACECQAserviceApprovalID");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FundedService)
                .HasMaxLength(3)
                .HasDefaultValue("Yes");
            entity.Property(e => e.KcaServiceTotalLps).HasColumnName("KCA_ServiceTotalLPs");
            entity.Property(e => e.Kinder3yoavgHours2023)
                .HasDefaultValue(15m)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Kinder_3YOavgHours_2023");
            entity.Property(e => e.Kinder3yoavgHours2024)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Kinder_3YOavgHours_2024");
            entity.Property(e => e.Kinder3yoavgHours2025)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Kinder_3YOavgHours_2025");
            entity.Property(e => e.Kinder3yoenrolments2023)
                .HasDefaultValue(0)
                .HasColumnName("Kinder_3YOenrolments_2023");
            entity.Property(e => e.Kinder3yoenrolments2023Unknown)
                .HasDefaultValue(false)
                .HasColumnName("Kinder_3YOenrolments_2023_unknown");
            entity.Property(e => e.Kinder3yoenrolments2024).HasColumnName("Kinder_3YOenrolments_2024");
            entity.Property(e => e.Kinder3yoenrolments2024Unknown).HasColumnName("Kinder_3YOenrolments_2024_unknown");
            entity.Property(e => e.Kinder3yoenrolments2025).HasColumnName("Kinder_3YOenrolments_2025");
            entity.Property(e => e.Kinder3yoenrolments2025Unknown)
                .HasDefaultValue(false)
                .HasColumnName("Kinder_3YOenrolments_2025_unknown");
            entity.Property(e => e.Kinder4yoenrolments2023)
                .HasDefaultValue(0)
                .HasColumnName("Kinder_4YOenrolments_2023");
            entity.Property(e => e.Kinder4yoenrolments2023Unknown)
                .HasDefaultValue(false)
                .HasColumnName("Kinder_4YOenrolments_2023_unknown");
            entity.Property(e => e.Kinder4yoenrolments2024).HasColumnName("Kinder_4YOenrolments_2024");
            entity.Property(e => e.Kinder4yoenrolments2024Unknown).HasColumnName("Kinder_4YOenrolments_2024_unknown");
            entity.Property(e => e.Kinder4yoenrolments2025).HasColumnName("Kinder_4YOenrolments_2025");
            entity.Property(e => e.Kinder4yoenrolments2025Unknown)
                .HasDefaultValue(false)
                .HasColumnName("Kinder_4YOenrolments_2025_unknown");
            entity.Property(e => e.LgaagreedServiceTotalLps).HasColumnName("LGAagreed_ServiceTotalLPs");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.RoomNumberAndLps)
                .HasMaxLength(255)
                .HasColumnName("RoomNumberAndLPs");
            entity.Property(e => e.ServiceType)
                .HasMaxLength(20)
                .HasDefaultValue("(select)");
            entity.Property(e => e.Sqltimestamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SQLtimestamp");
        });

        modelBuilder.Entity<TblKinderLdcmodelUserConstant>(entity =>
        {
            entity.ToTable("tblKinderLDCmodel_UserConstants");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ConType).HasMaxLength(50);
            entity.Property(e => e.ConValue).HasMaxLength(50);
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("LGAid");
        });

        modelBuilder.Entity<TblKinderLdcmodelUserVariable>(entity =>
        {
            entity.ToTable("tblKinderLDCmodel_UserVariables");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FacilityId)
                .HasDefaultValue(0)
                .HasColumnName("FacilityID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("LGAid");
            entity.Property(e => e.VarType).HasMaxLength(50);
            entity.Property(e => e.VarValue).HasMaxLength(250);
            entity.Property(e => e.Year).HasDefaultValue(0);
        });

        modelBuilder.Entity<TblLga>(entity =>
        {
            entity.HasKey(e => e.Lgaid)
                .HasName("aaaaatblLGAs_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblLGAs");

            entity.HasIndex(e => e.Lgaid, "LGAcode").HasFillFactor(90);

            entity.HasIndex(e => e.Lganame, "LGAname")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasComment("Unique ID for the LGA / council based on the organisation name")
                .HasColumnName("LGAid");
            entity.Property(e => e.CopyDb).HasColumnName("CopyDB");
            entity.Property(e => e.Lganame)
                .HasMaxLength(60)
                .HasComment("Name of the LGA / council")
                .HasColumnName("LGAname");
            entity.Property(e => e.QuantityModule).HasDefaultValue(true);
            entity.Property(e => e.SpatialObject)
                .HasMaxLength(255)
                .HasComment("Spatial object (polygon of LGA boundary)");
            entity.Property(e => e.SuitabilityModule).HasDefaultValue(false);
            entity.Property(e => e.UtilisationModule).HasDefaultValue(false);
        });

        modelBuilder.Entity<TblLgacriticality>(entity =>
        {
            entity.HasKey(e => e.LgacriticalityId)
                .HasName("aaaaatblLGAcriticality_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblLGAcriticality");

            entity.HasIndex(e => e.LgacriticalityId, "ID").HasFillFactor(90);

            entity.HasIndex(e => e.InfTypeId, "InfTypeID").HasFillFactor(90);

            entity.HasIndex(e => e.Lgaid, "LGAid").HasFillFactor(90);

            entity.HasIndex(e => e.CriticalityTypeId, "tblCriticalityTypestblLGAcriticality").HasFillFactor(90);

            entity.Property(e => e.LgacriticalityId).HasColumnName("LGACriticalityID");
            entity.Property(e => e.CriticalityTypeId).HasColumnName("CriticalityTypeID");
            entity.Property(e => e.InfTypeId)
                .HasDefaultValue(0)
                .HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(255)
                .HasColumnName("LGAid");

            entity.HasOne(d => d.CriticalityType).WithMany(p => p.TblLgacriticalities)
                .HasForeignKey(d => d.CriticalityTypeId)
                .HasConstraintName("tblLGAcriticality_FK00");
        });

        modelBuilder.Entity<TblLgaresponsibility>(entity =>
        {
            entity.HasKey(e => e.LgaresponsibilityId)
                .HasName("aaaaatblLGAResponsibility_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblLGAResponsibility");

            entity.HasIndex(e => e.LgaresponsibilityId, "ID").HasFillFactor(90);

            entity.HasIndex(e => e.InfTypeId, "InfTypeID").HasFillFactor(90);

            entity.HasIndex(e => e.Lgaid, "LGAid").HasFillFactor(90);

            entity.HasIndex(e => e.InfTypeId, "tblInfTypetblLGAresponsibility").HasFillFactor(90);

            entity.HasIndex(e => e.Lgaid, "tblLGAstblLGAresponsibility").HasFillFactor(90);

            entity.HasIndex(e => e.ResponsibilityTypeId, "tblResponsibilityTypestblLGAresponsibility").HasFillFactor(90);

            entity.Property(e => e.LgaresponsibilityId).HasColumnName("LGAResponsibilityID");
            entity.Property(e => e.InfTypeId)
                .HasDefaultValue(0)
                .HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(255)
                .HasColumnName("LGAid");
            entity.Property(e => e.ResponsibilityTypeId)
                .HasComment("Service delivery role or the LGA for each inf type")
                .HasColumnName("ResponsibilityTypeID");
        });

        modelBuilder.Entity<TblLocalitiesForecastArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblLocalitiesForecastArea");

            entity.Property(e => e.ForecastAreaBoundaryId).HasColumnName("ForecastAreaBoundaryID");
            entity.Property(e => e.ForecastAreaBoundaryName).HasMaxLength(120);
            entity.Property(e => e.ForecastAreaLgaid)
                .HasMaxLength(4)
                .HasColumnName("ForecastAreaLGAID");
            entity.Property(e => e.LocalitiesBoundaryId).HasColumnName("LocalitiesBoundaryID");
            entity.Property(e => e.LocalitiesBoundaryName).HasMaxLength(120);
        });

        modelBuilder.Entity<TblLocalitiesLga>(entity =>
        {
            entity.ToTable("tblLocalitiesLGA");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LGAID");
            entity.Property(e => e.Lganame)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LGAName");
            entity.Property(e => e.LocalitiesBoundaryId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LocalitiesBoundaryID");
            entity.Property(e => e.LocalitiesBoundaryName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblMainMenuItem>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("aaaaatblMainMenuItems_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblMainMenuItems");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MenuItem)
                .HasMaxLength(100)
                .HasComment("Max 100 ch");
            entity.Property(e => e.MenuNumber)
                .HasMaxLength(10)
                .HasComment("Use format 'Menu01'");
            entity.Property(e => e.MenuOrder).HasDefaultValue(0);
        });

        modelBuilder.Entity<TblNonResDemandProportionRate>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("tblNonResDemand_ProportionRates");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InfTypeId)
                .HasDefaultValue(0)
                .HasComment("Lookup tblInfType")
                .HasColumnName("InfTypeID");
            entity.Property(e => e.NonResType).HasMaxLength(100);
            entity.Property(e => e.PerResident).HasColumnType("decimal(8, 2)");
        });

        modelBuilder.Entity<TblOperator>(entity =>
        {
            entity.HasKey(e => e.OperatorId)
                .HasName("PK_tblOperator")
                .HasFillFactor(90);

            entity.ToTable("tblOperators");

            entity.Property(e => e.OperatorId)
                .HasComment("Unique ID for the service owner")
                .HasColumnName("OperatorID");
            entity.Property(e => e.Operator)
                .HasMaxLength(150)
                .HasComment("Person or position within LGA with responsibility for each infrastructure type");
        });

        modelBuilder.Entity<TblOwner>(entity =>
        {
            entity.HasKey(e => e.OwnerId).HasFillFactor(90);

            entity.ToTable("tblOwners");

            entity.Property(e => e.OwnerId)
                .HasComment("Unique ID for the service owner")
                .HasColumnName("OwnerID");
            entity.Property(e => e.Owner)
                .HasMaxLength(150)
                .HasComment("Person or position within LGA with responsibility for each infrastructure type");
        });

        modelBuilder.Entity<TblPermissionType>(entity =>
        {
            entity.HasKey(e => e.PermissionTypeId)
                .HasName("aaaaatblPermissionTypes_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblPermissionTypes");

            entity.HasIndex(e => e.PermissionTypeId, "ID").HasFillFactor(90);

            entity.HasIndex(e => e.PermissionType, "Type")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.PermissionTypeId)
                .HasComment("Unique ID for each permission type")
                .HasColumnName("PermissionTypeID");
            entity.Property(e => e.PermissionType)
                .HasMaxLength(20)
                .HasComment("Read or Write");
        });

        modelBuilder.Entity<TblPlanYearsDistinct>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblPlanYearsDistinct");

            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
        });

        modelBuilder.Entity<TblPlanYr>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("aaaaatblPlanYrs_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblPlanYrs");

            entity.HasIndex(e => e.Lgaid, "IX_tblPlanYrs").HasFillFactor(90);

            entity.HasIndex(e => e.ActualYear, "IX_tblPlanYrs_1").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActualYear)
                .HasDefaultValue(0)
                .HasComment("Actual year of each model horizon");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasComment("LGA id")
                .HasColumnName("LGAid");
            entity.Property(e => e.YearTitle)
                .HasMaxLength(25)
                .HasComment("Lookup to tblPlanYrTitles");

            entity.HasOne(d => d.YearTitleNavigation).WithMany(p => p.TblPlanYrs)
                .HasForeignKey(d => d.YearTitle)
                .HasConstraintName("tblPlanYrs_FK00");
        });

        modelBuilder.Entity<TblPlanYrTitle>(entity =>
        {
            entity.HasKey(e => e.Title)
                .HasName("aaaaatblPlanYrTitles_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblPlanYrTitles");

            entity.Property(e => e.Title)
                .HasMaxLength(25)
                .HasComment("Unique name for each year that model uses (year / horizon)");
            entity.Property(e => e.Order)
                .HasDefaultValue(0)
                .HasComment("Sequential order of planning years");
        });

        modelBuilder.Entity<TblPopRatioStd>(entity =>
        {
            entity.HasKey(e => e.PopRatioStdId).HasFillFactor(90);

            entity.ToTable("tblPopRatioStds");

            entity.HasIndex(e => e.Lgaid, "IX_tblPopRatioStds").HasFillFactor(90);

            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.AddedBy).HasMaxLength(100);
            entity.Property(e => e.AddedTime).HasColumnType("datetime");
            entity.Property(e => e.ChangedBy).HasMaxLength(100);
            entity.Property(e => e.ChangedTime).HasColumnType("datetime");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.LockedBy).HasMaxLength(100);
            entity.Property(e => e.LockedTime).HasColumnType("datetime");
            entity.Property(e => e.PreferredCohortId)
                .HasDefaultValue(0)
                .HasComment("ID of the cohort preferred by user")
                .HasColumnName("PreferredCohortID");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Ts)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ts");
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TblPopRatioStdsInfType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblPopRatioStdsInfTypes");

            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
        });

        modelBuilder.Entity<TblPostcode>(entity =>
        {
            entity.HasKey(e => e.Postcode)
                .HasName("aaaaatblPostcodes_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblPostcodes");

            entity.HasIndex(e => e.Postcode, "Postcode").HasFillFactor(90);

            entity.Property(e => e.Postcode)
                .HasDefaultValue((short)9999)
                .HasComment("List of postcodes");
            entity.Property(e => e.SpatialObject)
                .HasMaxLength(255)
                .HasComment("Spatial object (postcode boundary)");
        });

        modelBuilder.Entity<TblQtyAssessmentStd>(entity =>
        {
            entity.HasKey(e => e.QtyAssessmentStdId);

            entity.ToTable("tblQtyAssessmentStds");

            entity.HasIndex(e => e.Lgaid, "IX_tblQtyAssessmentStds");

            entity.HasIndex(e => e.UnitTypeId, "IX_tblQtyAssessmentStds_1");

            entity.HasIndex(e => e.PreferredCohortId, "IX_tblQtyAssessmentStds_2");

            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.AddedBy).HasMaxLength(100);
            entity.Property(e => e.AddedTime).HasColumnType("datetime");
            entity.Property(e => e.ChangedBy).HasMaxLength(100);
            entity.Property(e => e.ChangedTime).HasColumnType("datetime");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.LockedBy).HasMaxLength(100);
            entity.Property(e => e.LockedTime).HasColumnType("datetime");
            entity.Property(e => e.PreferredCohortId)
                .HasDefaultValue(0)
                .HasComment("ID of the cohort preferred by user")
                .HasColumnName("PreferredCohortID");
            entity.Property(e => e.StdName).HasMaxLength(100);
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TblQtyAssessmentStdsId>(entity =>
        {
            entity.ToTable("tblQtyAssessmentStds_IDs");

            entity.HasIndex(e => e.InfTypeId, "IX_tblQtyAssessmentStds_IDs_1");

            entity.HasIndex(e => e.HierarchyLevelId, "IX_tblQtyAssessmentStds_IDs_2");

            entity.HasIndex(e => e.Attribute1Id, "IX_tblQtyAssessmentStds_IDs_3");

            entity.HasIndex(e => e.Attribute2Id, "IX_tblQtyAssessmentStds_IDs_4");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Attribute1Id).HasColumnName("Attribute1ID");
            entity.Property(e => e.Attribute2Id).HasColumnName("Attribute2ID");
            entity.Property(e => e.HierarchyLevelId).HasColumnName("HierarchyLevelID");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");

            entity.HasOne(d => d.QtyAssessmentStd).WithMany(p => p.TblQtyAssessmentStdsIds)
                .HasForeignKey(d => d.QtyAssessmentStdId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblQtyAssessmentStds_IDs_tblQtyAssessmentStds");
        });

        modelBuilder.Entity<TblResPopSa2SingleYr>(entity =>
        {
            entity.ToTable("tblResPop_SA2_SingleYrs");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Absid).HasColumnName("ABSid");
            entity.Property(e => e.AgeGroup).HasColumnName("Age_group");
            entity.Property(e => e.BoundaryId)
                .HasDefaultValue(0)
                .HasColumnName("BoundaryID");
            entity.Property(e => e.Gender).HasMaxLength(8);
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.OldBoundaryId).HasColumnName("OLD_BoundaryID");
            entity.Property(e => e.OldSa2name)
                .HasMaxLength(150)
                .HasColumnName("OLD_SA2name");
            entity.Property(e => e.Sa2Name)
                .HasMaxLength(150)
                .HasColumnName("SA2_name");
        });

        modelBuilder.Entity<TblResPopSingleYr>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("tblResPop_SingleYrs");

            entity.HasIndex(e => e.Area, "IX_Area").HasFillFactor(90);

            entity.HasIndex(e => e.Lgaid, "IX_tblResPop_SingleYrs").HasFillFactor(90);

            entity.HasIndex(e => e.Year, "IX_tblResPop_SingleYrs_1").HasFillFactor(90);

            entity.HasIndex(e => e.AgeGroup, "IX_tblResPop_SingleYrs_2").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AgeGroup)
                .HasComment("Age (in single yrs)")
                .HasColumnName("Age group");
            entity.Property(e => e.Area)
                .HasMaxLength(255)
                .HasComment("Name of the population forecast boundary / area");
            entity.Property(e => e.BoundaryId)
                .HasDefaultValue(0)
                .HasColumnName("BoundaryID");
            entity.Property(e => e.Gender)
                .HasMaxLength(255)
                .HasComment("Male, female or person");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasComment("LGA id")
                .HasColumnName("LGAid");
            entity.Property(e => e.Number).HasComment("Forecast population");
            entity.Property(e => e.Year).HasComment("Year of forecast");
        });

        modelBuilder.Entity<TblResPopSingleYrsArchive>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("tblResPop_SingleYrs_ARCHIVE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AgeGroup)
                .HasComment("Age (in single yrs)")
                .HasColumnName("Age group");
            entity.Property(e => e.ArchiveDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Area)
                .HasMaxLength(255)
                .HasComment("Name of the population forecast boundary / area");
            entity.Property(e => e.Gender)
                .HasMaxLength(255)
                .HasComment("Male, female or person");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasComment("LGA id")
                .HasColumnName("LGAid");
            entity.Property(e => e.Number).HasComment("Forecast population");
            entity.Property(e => e.Year).HasComment("Year of forecast");
        });

        modelBuilder.Entity<TblResponsibilityType>(entity =>
        {
            entity.HasKey(e => e.ResponsibilityTypeId)
                .HasName("aaaaatblResponsibilityTypes_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblResponsibilityTypes");

            entity.HasIndex(e => e.ResponsibilityTypeId, "ID").HasFillFactor(90);

            entity.HasIndex(e => e.Order, "OrderCode").HasFillFactor(90);

            entity.HasIndex(e => e.ResponsibilityType, "Responsibility")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.ResponsibilityTypeId)
                .HasComment("Unique ID for the type of responsibility")
                .HasColumnName("ResponsibilityTypeID");
            entity.Property(e => e.Order)
                .HasDefaultValue(0)
                .HasComment("Hierarchy of responsibility types");
            entity.Property(e => e.ResponsibilityType)
                .HasMaxLength(100)
                .HasComment("The responsibility that the user has for delivery of each infrastructure type");
        });

        modelBuilder.Entity<TblSa2Lga>(entity =>
        {
            entity.ToTable("tblSA2_LGA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAID");
            entity.Property(e => e.Sa2boundaryId).HasColumnName("SA2BoundaryID");
        });

        modelBuilder.Entity<TblService>(entity =>
        {
            entity.HasKey(e => e.ServiceId)
                .HasName("aaaaatblServices_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblServices", tb => tb.HasComment("Description of each service/activity delivered through each facility and the relevant service class, infrastructure class and infrastructure type under the typology."));

            entity.HasIndex(e => e.FacilityId, "Facility_ID1").HasFillFactor(90);

            entity.HasIndex(e => e.Attribute1Id, "IX_tblServices_Attribute1");

            entity.HasIndex(e => e.Attribute2Id, "IX_tblServices_Attribute2");

            entity.HasIndex(e => e.HierarchyLevelId, "IX_tblServices_HierarchyLevel");

            entity.HasIndex(e => e.InfTypeId, "InfType").HasFillFactor(90);

            entity.HasIndex(e => e.AccessTypeId, "tblAccessTypetblServices").HasFillFactor(90);

            entity.HasIndex(e => e.InfTypeId, "tblInfTypetblServices").HasFillFactor(90);

            entity.HasIndex(e => e.ServiceOwner, "tblServiceOwnerstblServices").HasFillFactor(90);

            entity.HasIndex(e => e.ServiceOwner, "tblServicesServiceOwner").HasFillFactor(90);

            entity.Property(e => e.ServiceId)
                .HasComment("Unique ID for the service delivered through the linked facility")
                .HasColumnName("ServiceID");
            entity.Property(e => e.AccessTypeId)
                .HasComment("Lookup to tblAccessType")
                .HasColumnName("AccessTypeID");
            entity.Property(e => e.AddedBy).HasMaxLength(100);
            entity.Property(e => e.AddedTime).HasColumnType("datetime");
            entity.Property(e => e.Attribute1Id).HasColumnName("Attribute1ID");
            entity.Property(e => e.Attribute2Id).HasColumnName("Attribute2ID");
            entity.Property(e => e.ChangedBy).HasMaxLength(100);
            entity.Property(e => e.ChangedTime).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasComment("Optional additional description of the item of infrastructure");
            entity.Property(e => e.FacilityId)
                .HasDefaultValue(0)
                .HasComment("Lookup to tblFacilities")
                .HasColumnName("FacilityID");
            entity.Property(e => e.HierarchyLevelId).HasColumnName("HierarchyLevelID");
            entity.Property(e => e.InfTypeId)
                .HasDefaultValue(0)
                .HasComment("Lookup to tblInfType")
                .HasColumnName("InfTypeID");
            entity.Property(e => e.LockedBy).HasMaxLength(100);
            entity.Property(e => e.LockedTime).HasColumnType("datetime");
            entity.Property(e => e.ServiceOwner)
                .HasMaxLength(120)
                .HasDefaultValue("(not applicable)")
                .HasComment("Lookup to tblServiceOwners");
            entity.Property(e => e.TempId).HasColumnName("TempID");
            entity.Property(e => e.Ts)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ts");

            entity.HasOne(d => d.AccessType).WithMany(p => p.TblServices)
                .HasForeignKey(d => d.AccessTypeId)
                .HasConstraintName("tblServices_FK00");

            entity.HasOne(d => d.InfType).WithMany(p => p.TblServices)
                .HasForeignKey(d => d.InfTypeId)
                .HasConstraintName("tblServices_FK04");
        });

        modelBuilder.Entity<TblServiceOwner>(entity =>
        {
            entity.HasKey(e => e.ServiceOwnerId)
                .HasName("aaaaatblServiceOwners_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblServiceOwners");

            entity.HasIndex(e => e.ServiceOwnerId, "ID").HasFillFactor(90);

            entity.HasIndex(e => e.Lgaid, "LGAid").HasFillFactor(90);

            entity.HasIndex(e => e.ServiceOwner, "Owner").HasFillFactor(90);

            entity.Property(e => e.ServiceOwnerId)
                .HasComment("Unique ID for the service owner")
                .HasColumnName("ServiceOwnerID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasComment("LGA ID")
                .HasColumnName("LGAid");
            entity.Property(e => e.ServiceOwner)
                .HasMaxLength(120)
                .HasComment("Person or position within LGA with responsibility for each infrastructure type");
        });

        modelBuilder.Entity<TblServiceUnitQuantity>(entity =>
        {
            entity.HasKey(e => e.ServiceUnitQuantityId)
                .HasName("aaaaatblServiceUnitQuantities_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblServiceUnitQuantities");

            entity.HasIndex(e => e.ServiceUnitQuantityId, "ID").HasFillFactor(90);

            entity.HasIndex(e => e.ServiceId, "ServiceID").HasFillFactor(90);

            entity.Property(e => e.ServiceUnitQuantityId)
                .HasComment("Unique ID of the quantity of units for the particular service")
                .HasColumnName("ServiceUnitQuantityID");
            entity.Property(e => e.AddedBy).HasMaxLength(100);
            entity.Property(e => e.AddedTime).HasColumnType("datetime");
            entity.Property(e => e.ChangedBy).HasMaxLength(100);
            entity.Property(e => e.ChangedTime).HasColumnType("datetime");
            entity.Property(e => e.LockedBy).HasMaxLength(100);
            entity.Property(e => e.LockedTime).HasColumnType("datetime");
            entity.Property(e => e.Quantity)
                .HasDefaultValue(0m)
                .HasComment("Quantity of units")
                .HasColumnType("decimal(12, 2)");
            entity.Property(e => e.ServiceId)
                .HasDefaultValue(0)
                .HasComment("Lookup to tblServices")
                .HasColumnName("ServiceID");
            entity.Property(e => e.UnitTypeId)
                .HasComment("Query tblInfTypeUnits where tblServices.InfTypeRef=tblInfUnitTypes.InfTypeRef and tblServices.ID=the current record")
                .HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TblSettlementPostcode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblSettlementPostcodes");

            entity.Property(e => e.LocalitiesBoundaryId).HasColumnName("LocalitiesBoundaryID");
            entity.Property(e => e.Postcode).HasMaxLength(10);
            entity.Property(e => e.Settlement)
                .HasMaxLength(120)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblSubSpace>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("tblSubSpaces");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FacilityId)
                .HasDefaultValue(0)
                .HasColumnName("FacilityID");
            entity.Property(e => e.SpaceName).HasMaxLength(255);
        });

        modelBuilder.Entity<TblToolTip>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("tblToolTips");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ShortName).HasMaxLength(25);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<TblTravelPropensity>(entity =>
        {
            entity.ToTable("tblTravelPropensity");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BoundaryIdFrom)
                .HasComment("Boundary ID of source area")
                .HasColumnName("BoundaryID_From");
            entity.Property(e => e.BoundaryIdTo)
                .HasComment("Boundary ID of destination area")
                .HasColumnName("BoundaryID_To");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasComment("LGAid of modelling LGA")
                .HasColumnName("LGAid");
            entity.Property(e => e.PropensityDecimal)
                .HasComment("1=100% propensity to travel from 'FROM' to 'TO', 0=0%")
                .HasColumnType("decimal(3, 2)")
                .HasColumnName("Propensity_decimal");
            entity.Property(e => e.UseId)
                .HasComment("InfTypeID of the Use that this propensity is for")
                .HasColumnName("UseID");
        });

        modelBuilder.Entity<TblTypologyLog>(entity =>
        {
            entity.ToTable("tblTypologyLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Actioned).HasDefaultValue(false);
            entity.Property(e => e.AttributeName1Id)
                .HasDefaultValue(0)
                .HasColumnName("AttributeName1ID");
            entity.Property(e => e.AttributeName2Id)
                .HasDefaultValue(0)
                .HasColumnName("AttributeName2ID");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.HierarchyNameId)
                .HasDefaultValue(0)
                .HasColumnName("HierarchyNameID");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasComment("4 digit LGAid for the municipality in which the facility is located")
                .HasColumnName("LGAid");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.Reason).HasMaxLength(255);
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TblUnitType>(entity =>
        {
            entity.HasKey(e => e.UnitTypeId)
                .HasName("aaaaatblUnitTypes_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblUnitTypes");

            entity.HasIndex(e => e.UnitTypeId, "ID").HasFillFactor(90);

            entity.HasIndex(e => e.UnitType, "Type")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.UnitTypeId)
                .HasComment("Unique ID for the unit type")
                .HasColumnName("UnitTypeID");
            entity.Property(e => e.Definition).HasMaxLength(150);
            entity.Property(e => e.Singular).HasMaxLength(50);
            entity.Property(e => e.UnitType)
                .HasMaxLength(50)
                .HasComment("Different units that quantity of provision may be measured in");
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.HasKey(e => e.UserId)
                .HasName("aaaaatblUsers_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblUsers");

            entity.HasIndex(e => e.UserId, "UserID").HasFillFactor(90);

            entity.HasIndex(e => e.UserName, "UserName")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Firstname).HasMaxLength(255);
            entity.Property(e => e.IdentityId)
                .HasMaxLength(450)
                .HasColumnName("IdentityID");
            entity.Property(e => e.IsActive).HasDefaultValue(false);
            entity.Property(e => e.IsTempUser).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasComment("LGA id")
                .HasColumnName("LGAid");
            entity.Property(e => e.NetworkUserName).HasMaxLength(50);
            entity.Property(e => e.Password)
                .HasMaxLength(15)
                .HasDefaultValue("Password1")
                .HasComment("Password (max 15 characters)");
            entity.Property(e => e.Surname).HasMaxLength(255);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasComment("Username");
        });

        modelBuilder.Entity<TblUserAssignedAssessmentList>(entity =>
        {
            entity.HasKey(e => e.AssignmentId).HasName("PK__tblUserA__32499E57D9E90258");

            entity.ToTable("tblUserAssignedAssessmentLists");

            entity.HasIndex(e => e.ListId, "IX_tblUserAssignedAssessmentLists_ListID");

            entity.HasIndex(e => e.UserId, "IX_tblUserAssignedAssessmentLists_UserID");

            entity.Property(e => e.AssignmentId).HasColumnName("AssignmentID");
            entity.Property(e => e.DateAssigned)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ListId).HasColumnName("ListID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.List).WithMany(p => p.TblUserAssignedAssessmentLists)
                .HasForeignKey(d => d.ListId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblUserAs__ListI__43833988");

            entity.HasOne(d => d.User).WithMany(p => p.TblUserAssignedAssessmentLists)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tblUserAs__UserI__428F154F");
        });

        modelBuilder.Entity<TblUserInterest>(entity =>
        {
            entity.HasKey(e => e.UserInterestId)
                .HasName("aaaaatblUserInterest_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblUserInterest");

            entity.HasIndex(e => e.UserInterestId, "ID").HasFillFactor(90);

            entity.HasIndex(e => e.UserInterest, "Interest")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.UserInterestId)
                .HasComment("Unique ID of the type of interest the user has in the facility")
                .HasColumnName("UserInterestID");
            entity.Property(e => e.Order)
                .HasDefaultValue(0)
                .HasComment("Hierarchy of interests");
            entity.Property(e => e.UserInterest)
                .HasMaxLength(10)
                .HasComment("The type of fiscal, ownership or other legal interest the user has in the facility");
        });

        modelBuilder.Entity<TblUserPermission>(entity =>
        {
            entity.HasKey(e => e.PermissionId)
                .HasName("aaaaatblUserPermissions_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblUserPermissions");

            entity.HasIndex(e => e.PermissionId, "ID").HasFillFactor(90);

            entity.HasIndex(e => e.Lgaid, "LGAcode").HasFillFactor(90);

            entity.HasIndex(e => e.Lgaid, "tblLGAstblPermissions").HasFillFactor(90);

            entity.Property(e => e.PermissionId)
                .HasComment("Unique ID for the particular permissions assigned to the user")
                .HasColumnName("PermissionID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasComment("LGA id")
                .HasColumnName("LGAid");
            entity.Property(e => e.PermissionToLgaid)
                .HasMaxLength(4)
                .HasColumnName("PermissionToLGAid");
            entity.Property(e => e.PermissionType).HasMaxLength(20);

            entity.HasOne(d => d.Lga).WithMany(p => p.TblUserPermissions)
                .HasForeignKey(d => d.Lgaid)
                .HasConstraintName("tblUserPermissions_FK00");
        });

        modelBuilder.Entity<TblUserSqllogin>(entity =>
        {
            entity.ToTable("tblUserSQLlogins");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KinderLdcuserId).HasColumnName("KinderLDCUserID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("LGAid");
            entity.Property(e => e.LgareadableDbsuffix)
                .HasMaxLength(50)
                .HasColumnName("LGAreadableDBsuffix");
            entity.Property(e => e.PrimaryUserId)
                .HasDefaultValue(0)
                .HasColumnName("PrimaryUserID");
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<TblUtilAssessmentType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tblUtil_AssessmentTypes$PrimaryKey");

            entity.ToTable("tblUtil_AssessmentTypes");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.TypeName).HasMaxLength(255);
        });

        modelBuilder.Entity<TblUtilAsstLog>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("tblUtil_AsstLog$tblFFPasstLog$PrimaryKey")
                .HasFillFactor(90);

            entity.ToTable("tblUtil_AsstLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AssessmentEndDate).HasColumnType("datetime");
            entity.Property(e => e.AssessmentStartDate).HasColumnType("datetime");
            entity.Property(e => e.CapacityRecordId).HasColumnName("CapacityRecordID");
            entity.Property(e => e.CapacityTemplateId)
                .HasComment("ID from tblUtil_CapacityTemplateTitles")
                .HasColumnName("CapacityTemplateID");
            entity.Property(e => e.DataSource)
                .HasMaxLength(255)
                .HasComment("Source of the utilisation data");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.SubSpaceId)
                .HasComment("'0' if assessment is for the whole facility")
                .HasColumnName("SubSpaceID");
            entity.Property(e => e.UtilTemplateId)
                .HasComment("ID from tblUtil_UtilTemplateTitles")
                .HasColumnName("UtilTemplateID");
            entity.Property(e => e.UtilisationDescription)
                .HasMaxLength(255)
                .HasComment("Describe the nature of the usage that the assessment data is for e.g. 'All bookings' or 'Sport club use'");
        });

        modelBuilder.Entity<TblUtilCapacityHourlyUse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tblUtil_Capacity_HourlyUse$PrimaryKey");

            entity.ToTable("tblUtil_Capacity_HourlyUse");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FacilityId)
                .HasDefaultValue(0)
                .HasComment("ID from tblFacilities")
                .HasColumnName("FacilityID");
            entity.Property(e => e.FriBookable)
                .HasDefaultValue(true)
                .HasComment("Facility is bookable on this day of the week")
                .HasColumnName("Fri_Bookable");
            entity.Property(e => e.FriCoreEndTime)
                .HasDefaultValue(2200)
                .HasComment("End of core / peak hours")
                .HasColumnName("Fri_CoreEndTime");
            entity.Property(e => e.FriCoreStartTime)
                .HasDefaultValue(1700)
                .HasComment("Start of core / peak hours")
                .HasColumnName("Fri_CoreStartTime");
            entity.Property(e => e.FriEndTime)
                .HasDefaultValue(2200.0)
                .HasComment("Latest time facility can be booked until")
                .HasColumnName("Fri_EndTime");
            entity.Property(e => e.FriStartTime)
                .HasDefaultValue(800.0)
                .HasComment("Earliest time facility can be booked from")
                .HasColumnName("Fri_StartTime");
            entity.Property(e => e.FriTotalHours)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("Fri_TotalHours");
            entity.Property(e => e.InfTypeId)
                .HasDefaultValue(0)
                .HasColumnName("InfTypeID");
            entity.Property(e => e.MonBookable)
                .HasDefaultValue(true)
                .HasComment("Facility is bookable on this day of the week")
                .HasColumnName("Mon_Bookable");
            entity.Property(e => e.MonCoreEndTime)
                .HasDefaultValue(2200)
                .HasComment("End of core / peak hours")
                .HasColumnName("Mon_CoreEndTime");
            entity.Property(e => e.MonCoreStartTime)
                .HasDefaultValue(1700)
                .HasComment("Start of core / peak hours")
                .HasColumnName("Mon_CoreStartTime");
            entity.Property(e => e.MonEndTime)
                .HasDefaultValue(2200.0)
                .HasComment("Latest time facility can be booked until")
                .HasColumnName("Mon_EndTime");
            entity.Property(e => e.MonStartTime)
                .HasDefaultValue(800.0)
                .HasComment("Earliest time facility can be booked from")
                .HasColumnName("Mon_StartTime");
            entity.Property(e => e.MonTotalHours)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("Mon_TotalHours");
            entity.Property(e => e.MonthTotalHours)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("Month_TotalHours");
            entity.Property(e => e.OldUseSpaceId)
                .HasDefaultValue(0)
                .HasColumnName("OLD_UseSpaceID");
            entity.Property(e => e.SatBookable)
                .HasDefaultValue(true)
                .HasComment("Facility is bookable on this day of the week")
                .HasColumnName("Sat_Bookable");
            entity.Property(e => e.SatCoreEndTime)
                .HasDefaultValue(2200)
                .HasComment("End of core / peak hours")
                .HasColumnName("Sat_CoreEndTime");
            entity.Property(e => e.SatCoreStartTime)
                .HasDefaultValue(1700)
                .HasComment("Start of core / peak hours")
                .HasColumnName("Sat_CoreStartTime");
            entity.Property(e => e.SatEndTime)
                .HasDefaultValue(2200.0)
                .HasComment("Latest time facility can be booked until")
                .HasColumnName("Sat_EndTime");
            entity.Property(e => e.SatStartTime)
                .HasDefaultValue(800.0)
                .HasComment("Earliest time facility can be booked from")
                .HasColumnName("Sat_StartTime");
            entity.Property(e => e.SatTotalHours)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("Sat_TotalHours");
            entity.Property(e => e.SeasonEnd)
                .HasDefaultValue(12)
                .HasComment("End month for each season, where 1 = January");
            entity.Property(e => e.SeasonName)
                .HasMaxLength(50)
                .HasDefaultValue("Entire year")
                .HasComment("Optional name for each season");
            entity.Property(e => e.SeasonNumber)
                .HasDefaultValue(1)
                .HasComment("Optional: user may define multiple seasons");
            entity.Property(e => e.SeasonStart)
                .HasDefaultValue(1)
                .HasComment("Start month for each season, where 1 = January");
            entity.Property(e => e.SimpleMaxCapacity).HasColumnType("decimal(4, 1)");
            entity.Property(e => e.SubSpaceId)
                .HasDefaultValue(0)
                .HasComment("ID fromtblSubSpaces")
                .HasColumnName("SubSpaceID");
            entity.Property(e => e.SunBookable)
                .HasDefaultValue(true)
                .HasComment("Facility is bookable on this day of the week")
                .HasColumnName("Sun_Bookable");
            entity.Property(e => e.SunCoreEndTime)
                .HasDefaultValue(2200)
                .HasComment("End of core / peak hours")
                .HasColumnName("Sun_CoreEndTime");
            entity.Property(e => e.SunCoreStartTime)
                .HasDefaultValue(1700)
                .HasComment("Start of core / peak hours")
                .HasColumnName("Sun_CoreStartTime");
            entity.Property(e => e.SunEndTime)
                .HasDefaultValue(2200.0)
                .HasComment("Latest time facility can be booked until")
                .HasColumnName("Sun_EndTime");
            entity.Property(e => e.SunStartTime)
                .HasDefaultValue(800.0)
                .HasComment("Earliest time facility can be booked from")
                .HasColumnName("Sun_StartTime");
            entity.Property(e => e.SunTotalHours)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("Sun_TotalHours");
            entity.Property(e => e.ThuBookable)
                .HasDefaultValue(true)
                .HasComment("Facility is bookable on this day of the week")
                .HasColumnName("Thu_Bookable");
            entity.Property(e => e.ThuCoreEndTime)
                .HasDefaultValue(2200)
                .HasComment("End of core / peak hours")
                .HasColumnName("Thu_CoreEndTime");
            entity.Property(e => e.ThuCoreStartTime)
                .HasDefaultValue(1700)
                .HasComment("Start of core / peak hours")
                .HasColumnName("Thu_CoreStartTime");
            entity.Property(e => e.ThuEndTime)
                .HasDefaultValue(2200.0)
                .HasComment("Latest time facility can be booked until")
                .HasColumnName("Thu_EndTime");
            entity.Property(e => e.ThuStartTime)
                .HasDefaultValue(800.0)
                .HasComment("Earliest time facility can be booked from")
                .HasColumnName("Thu_StartTime");
            entity.Property(e => e.ThuTotalHours)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("Thu_TotalHours");
            entity.Property(e => e.TueBookable)
                .HasDefaultValue(true)
                .HasComment("Facility is bookable on this day of the week")
                .HasColumnName("Tue_Bookable");
            entity.Property(e => e.TueCoreEndTime)
                .HasDefaultValue(2200)
                .HasComment("End of core / peak hours")
                .HasColumnName("Tue_CoreEndTime");
            entity.Property(e => e.TueCoreStartTime)
                .HasDefaultValue(1700)
                .HasComment("Start of core / peak hours")
                .HasColumnName("Tue_CoreStartTime");
            entity.Property(e => e.TueEndTime)
                .HasDefaultValue(2200.0)
                .HasComment("Latest time facility can be booked until")
                .HasColumnName("Tue_EndTime");
            entity.Property(e => e.TueStartTime)
                .HasDefaultValue(800.0)
                .HasComment("Earliest time facility can be booked from")
                .HasColumnName("Tue_StartTime");
            entity.Property(e => e.TueTotalHours)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("Tue_TotalHours");
            entity.Property(e => e.UseCoreHours).HasDefaultValue(true);
            entity.Property(e => e.WedBookable)
                .HasDefaultValue(true)
                .HasComment("Facility is bookable on this day of the week")
                .HasColumnName("Wed_Bookable");
            entity.Property(e => e.WedCoreEndTime)
                .HasDefaultValue(2200)
                .HasComment("End of core / peak hours")
                .HasColumnName("Wed_CoreEndTime");
            entity.Property(e => e.WedCoreStartTime)
                .HasDefaultValue(1700)
                .HasComment("Start of core / peak hours")
                .HasColumnName("Wed_CoreStartTime");
            entity.Property(e => e.WedEndTime)
                .HasDefaultValue(2200.0)
                .HasComment("Latest time facility can be booked until")
                .HasColumnName("Wed_EndTime");
            entity.Property(e => e.WedStartTime)
                .HasDefaultValue(800.0)
                .HasComment("Earliest time facility can be booked from")
                .HasColumnName("Wed_StartTime");
            entity.Property(e => e.WedTotalHours)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("Wed_TotalHours");
            entity.Property(e => e.WeekTotalHours)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("Week_TotalHours");
            entity.Property(e => e.YearTotalHours)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(4, 1)")
                .HasColumnName("Year_TotalHours");
        });

        modelBuilder.Entity<TblUtilCapacityTemplateType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tblUtil_CapacityTemplateTitles$PrimaryKey");

            entity.ToTable("tblUtil_CapacityTemplateTypes");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.TableName)
                .HasMaxLength(60)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<TblUtilCapacityTemplatesByInfType>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("tblUtil_CapacityTemplatesByInfType");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CapacityTemplateId).HasColumnName("CapacityTemplateID");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
        });

        modelBuilder.Entity<TblUtilDurationFormat>(entity =>
        {
            entity.ToTable("tblUtil_DurationFormats");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Format).HasMaxLength(50);
        });

        modelBuilder.Entity<TblUtilHourlyBookingDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tblUtil_HourlyBookingData$PrimaryKey");

            entity.ToTable("tblUtil_HourlyBookingData");

            entity.Property(e => e.Id)
                .HasComment("CASIMO unique booking reference")
                .HasColumnName("ID");
            entity.Property(e => e.BookingCategory)
                .HasMaxLength(50)
                .HasComment("LGA category for the type of ACTIVITY (e.g. community meeting)");
            entity.Property(e => e.BookingDate)
                .HasComment("Short date of booking")
                .HasColumnType("datetime");
            entity.Property(e => e.BookingDescription)
                .HasMaxLength(255)
                .HasComment("LGA detailed description of BOOKING (e.g. Historical Society)");
            entity.Property(e => e.DayRef)
                .HasDefaultValue(0)
                .HasComment("1=Sunday, 2=Monday etc");
            entity.Property(e => e.Duration)
                .HasDefaultValue(0.0)
                .HasComment("Duration of booking. Decimal expression of whole and half hours (e.g. 1.5 hours)");
            entity.Property(e => e.DurationFormat).HasDefaultValue(0);
            entity.Property(e => e.EndTime)
                .HasComment("Short time end")
                .HasColumnType("datetime");
            entity.Property(e => e.EndTimeCode)
                .HasDefaultValue(0)
                .HasComment("CASIMO time slot code equivalent for end time, rounded to nearest half hour");
            entity.Property(e => e.EndTimeRounded)
                .HasComment("Original end time rounded to nearest half hour")
                .HasColumnType("datetime");
            entity.Property(e => e.FacilityId)
                .HasDefaultValue(0)
                .HasComment("ID from tblFacilities")
                .HasColumnName("FacilityID");
            entity.Property(e => e.HirerCategory)
                .HasMaxLength(100)
                .HasComment("LGA category for the type of HIRER (e.g. community group)");
            entity.Property(e => e.HirerRef)
                .HasMaxLength(100)
                .HasComment("LGA unique reference for hirer");
            entity.Property(e => e.Include).HasDefaultValue(true);
            entity.Property(e => e.InfTypeId)
                .HasDefaultValue(0)
                .HasColumnName("InfTypeID");
            entity.Property(e => e.LgabookingRef)
                .HasMaxLength(50)
                .HasComment("LGA's unique reference for booking")
                .HasColumnName("LGAbookingRef");
            entity.Property(e => e.OldUseSpaceId).HasColumnName("OLD_UseSpaceID");
            entity.Property(e => e.ShortDayName)
                .HasMaxLength(3)
                .HasComment("Day of the week");
            entity.Property(e => e.StartTime)
                .HasComment("Short time start")
                .HasColumnType("datetime");
            entity.Property(e => e.StartTimeCode)
                .HasDefaultValue(0)
                .HasComment("CASIMO time slot code equivalent for start time, rounded to nearest half hour");
            entity.Property(e => e.StartTimeRounded)
                .HasComment("Original start time rounded to nearest half hour")
                .HasColumnType("datetime");
            entity.Property(e => e.SubSpaceId)
                .HasDefaultValue(0)
                .HasComment("ID from tblSubSpaces")
                .HasColumnName("SubSpaceID");
        });

        modelBuilder.Entity<TblUtilResultsByDayHourlyPatternBySlotCode>(entity =>
        {
            entity.ToTable("tblUtilResults_ByDayHourlyPatternBySlotCode");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CapacityRecordId)
                .HasDefaultValue(0)
                .HasColumnName("CapacityRecordID");
            entity.Property(e => e.CountSlotCode).HasDefaultValue(0);
            entity.Property(e => e.DayRef).HasDefaultValue(0);
            entity.Property(e => e.FacilityId)
                .HasDefaultValue(0)
                .HasColumnName("FacilityID");
            entity.Property(e => e.InfTypeId)
                .HasDefaultValue(0)
                .HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("LGAid");
            entity.Property(e => e.SlotCode).HasDefaultValue(0);
            entity.Property(e => e.SubSpaceId)
                .HasDefaultValue(0)
                .HasColumnName("SubSpaceID");
            entity.Property(e => e.UtilLogId)
                .HasDefaultValue(0)
                .HasColumnName("UtilLogID");
        });

        modelBuilder.Entity<TblUtilResultsPcbyDay>(entity =>
        {
            entity.ToTable("tblUtilResults_PCbyDay");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.DayName).HasMaxLength(20);
            entity.Property(e => e.DayRef).HasDefaultValue(0);
            entity.Property(e => e.FacilityId)
                .HasDefaultValue(0)
                .HasColumnName("FacilityID");
            entity.Property(e => e.InfTypeId)
                .HasDefaultValue(0)
                .HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.SubSpaceId)
                .HasDefaultValue(0)
                .HasColumnName("SubSpaceID");
            entity.Property(e => e.UtilLogId)
                .HasDefaultValue(0)
                .HasColumnName("UtilLogID");
            entity.Property(e => e.UtilPc)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Util_PC");
            entity.Property(e => e.UtilPcCore)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Util_PC_Core");
            entity.Property(e => e.UtilPcDaytime)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Util_PC_Daytime");
            entity.Property(e => e.UtilPcEvening)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Util_PC_Evening");
        });

        modelBuilder.Entity<TblUtilTimeCode>(entity =>
        {
            entity.HasKey(e => e.SlotCode).HasName("tblUtil_TimeCodes$TimeCode");

            entity.ToTable("tblUtil_TimeCodes");

            entity.Property(e => e.SlotCode).HasComment("Unique code for each 30 minute time slot");
            entity.Property(e => e.EndTimeDt)
                .HasComment("End time of the time slot as shown in a Date/Time (Short Time) formatted field")
                .HasColumnType("datetime")
                .HasColumnName("EndTime_DT");
            entity.Property(e => e.EndTimeStr)
                .HasMaxLength(10)
                .HasComment("string equivalent of end time")
                .HasColumnName("EndTime_str");
            entity.Property(e => e.EndTimeStrAmpm)
                .HasMaxLength(8)
                .HasColumnName("EndTime_strAMPM");
            entity.Property(e => e.Lgaequivalent)
                .HasColumnType("datetime")
                .HasColumnName("LGAequivalent");
            entity.Property(e => e.StartTimeDt)
                .HasComment("Start time of the time slot as shown in a Date/Time (Short Time) formatted field")
                .HasColumnType("datetime")
                .HasColumnName("StartTime_DT");
            entity.Property(e => e.StartTimeStr)
                .HasMaxLength(10)
                .HasComment("string equivalent of start time")
                .HasColumnName("StartTime_str");
            entity.Property(e => e.StartTimeStrAmpm)
                .HasMaxLength(8)
                .HasColumnName("StartTime_strAMPM");
        });

        modelBuilder.Entity<TblUtilTimePeriodsByLga>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("tblUtil_TimePeriodsByLGA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsLocked).HasDefaultValue(false);
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.LockedByUser).HasDefaultValue(0);
            entity.Property(e => e.UtilDayTimeEnd).HasColumnName("Util_DayTime_End");
            entity.Property(e => e.UtilDayTimeStart).HasColumnName("Util_DayTime_Start");
            entity.Property(e => e.UtilEveningEnd).HasColumnName("Util_Evening_End");
            entity.Property(e => e.UtilEveningStart).HasColumnName("Util_Evening_Start");
        });

        modelBuilder.Entity<TblUtilUtilTemplateType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tblUtil_UtilTemplateTitles$PrimaryKey");

            entity.ToTable("tblUtil_UtilTemplateTypes");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(false);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<TblWeekday>(entity =>
        {
            entity.HasKey(e => e.Ref).HasName("tblWeekdays$PrimaryKey");

            entity.ToTable("tblWeekdays");

            entity.Property(e => e.DisplayOrder).HasDefaultValue(0);
            entity.Property(e => e.FullDay).HasMaxLength(25);
            entity.Property(e => e.ShortDay).HasMaxLength(3);
        });

        modelBuilder.Entity<TblWorkerZonesForecastArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblWorkerZonesForecastArea");

            entity.Property(e => e.ForecastAreaBoundaryId).HasColumnName("ForecastAreaBoundaryID");
            entity.Property(e => e.ForecastAreaBoundaryName).HasMaxLength(100);
            entity.Property(e => e.ForecastAreaLgaid)
                .HasMaxLength(4)
                .HasColumnName("ForecastAreaLGAID");
            entity.Property(e => e.TravelZone).HasMaxLength(255);
            entity.Property(e => e.WorkerZoneId).HasColumnName("WorkerZoneID");
        });

        modelBuilder.Entity<TblWorkersByTravelZone>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("aaaaatblWorkersByTravelZone_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblWorkersByTravelZone");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TravelZoneId)
                .HasMaxLength(10)
                .HasColumnName("TravelZoneID");
            entity.Property(e => e.Type).HasMaxLength(25);
        });

        modelBuilder.Entity<TblWorkersByWorkerZone>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("aaaaatblWorkersByWorkerZone_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblWorkersByWorkerZone");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Type).HasMaxLength(25);
            entity.Property(e => e.WorkerZoneId)
                .HasDefaultValue(0)
                .HasColumnName("WorkerZoneID");
        });

        modelBuilder.Entity<TblWorkersSplitTzntoWorkerZone>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("aaaaatblWorkers_SplitTZNtoWorkerZones_PK")
                .IsClustered(false)
                .HasFillFactor(90);

            entity.ToTable("tblWorkers_SplitTZNtoWorkerZones");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Type).HasMaxLength(25);
            entity.Property(e => e.TznToSplit)
                .HasMaxLength(255)
                .HasColumnName("TZN_toSplit");
            entity.Property(e => e.UpsizeTs)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("upsize_ts");
        });

        modelBuilder.Entity<TbltmpGeccscopeId>(entity =>
        {
            entity.ToTable("_tbltmpGECCscopeIDs");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.UnitId).HasColumnName("UnitID");
        });

        modelBuilder.Entity<TbltmpSa2copy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_tbltmpSA2copy");

            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryName).HasMaxLength(120);
            entity.Property(e => e.BoundaryTypeId).HasColumnName("BoundaryTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.StateCode)
                .HasMaxLength(3)
                .IsFixedLength();
        });

        modelBuilder.Entity<TbltmpSa2copyKisp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbltmp_SA2copyKISP");

            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryName).HasMaxLength(120);
            entity.Property(e => e.BoundaryTypeId).HasColumnName("BoundaryTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.StateCode)
                .HasMaxLength(3)
                .IsFixedLength();
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears0>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_0");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears104>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_104");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears105>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_105");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears107>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_107");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears109>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_109");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears110>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_110");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears18>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_18");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears21>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_21");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears24>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_24");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears27>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_27");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears28>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_28");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears31>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_31");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears33>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_33");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears37>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_37");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears38>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_38");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears40>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_40");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears41>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_41");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears46>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_46");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears47>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_47");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears49>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_49");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears53>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_53");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears54>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_54");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears55>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_55");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears56>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_56");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears57>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_57");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears6>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_6");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears61>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_61");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears62>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_62");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears63>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_63");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears64>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_64");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears68>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_68");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears69>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_69");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears70>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_70");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears82>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_82");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears84>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_84");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears88>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_88");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears89>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_89");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears90>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_90");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears91>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_91");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears92>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_92");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears94>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_94");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosAggregatedAllYears95>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_AggregatedAllYears_95");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears0>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_0");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears101>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_101");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears102>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_102");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears104>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_104");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears105>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_105");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears106>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_106");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears107>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_107");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears109>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_109");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears110>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_110");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears18>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_18");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears24>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_24");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears27>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_27");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears28>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_28");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears31>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_31");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears33>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_33");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears37>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_37");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears38>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_38");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears40>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_40");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears41>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_41");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears42>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_42");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears43>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_43");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears44>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_44");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears46>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_46");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears47>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_47");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears48>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_48");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears49>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_49");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears53>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_53");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears54>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_54");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears55>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_55");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears56>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_56");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears57>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_57");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears58>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_58");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears59>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_59");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears6>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_6");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears61>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_61");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears62>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_62");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears63>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_63");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears64>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_64");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears68>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_68");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears69>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_69");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears70>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_70");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears74>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_74");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears75>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_75");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears76>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_76");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears80>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_80");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears82>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_82");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears83>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_83");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears84>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_84");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears88>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_88");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears89>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_89");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears90>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_90");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears91>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_91");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears92>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_92");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears94>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_94");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears95>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_95");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblGetRatiosForecastAllYears999>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblGetRatios_ForecastAllYears_999");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<TmptblPopulationForecastByCohortAndYear>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblPopulationForecastByCohortAndYear");

            entity.Property(e => e.Area).HasMaxLength(255);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Gender).HasMaxLength(255);
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
        });

        modelBuilder.Entity<TmptblResidentPopulationByAggregatedArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmptblResidentPopulationByAggregatedArea");

            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
        });

        modelBuilder.Entity<VwAaaRctestKispSa2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAAA_RCTEST_KISP_SA2");

            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryName).HasMaxLength(120);
            entity.Property(e => e.BoundaryTypeId).HasColumnName("BoundaryTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.StateCode)
                .HasMaxLength(3)
                .IsFixedLength();
        });

        modelBuilder.Entity<VwAcecqaregisterByLga>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwACECQAregisterByLGA");

            entity.Property(e => e.AfterSchoolCare)
                .HasMaxLength(10)
                .HasColumnName("After_school_care");
            entity.Property(e => e.AnyPreschool)
                .HasMaxLength(10)
                .HasColumnName("Any_preschool");
            entity.Property(e => e.AnyPreschoolOrLdc)
                .HasMaxLength(10)
                .HasColumnName("Any_preschool_or_LDC");
            entity.Property(e => e.ApprovedPlaces).HasColumnName("Approved_Places");
            entity.Property(e => e.BeforeSchoolCare)
                .HasMaxLength(10)
                .HasColumnName("Before_school_care");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAID");
            entity.Property(e => e.Lganame)
                .HasMaxLength(120)
                .HasColumnName("LGAname");
            entity.Property(e => e.LongDayCare)
                .HasMaxLength(10)
                .HasColumnName("Long_Day_Care");
            entity.Property(e => e.PreschoolPartOfSchool)
                .HasMaxLength(10)
                .HasColumnName("Preschool_part_of_school");
            entity.Property(e => e.PreschoolStandAlone)
                .HasMaxLength(10)
                .HasColumnName("Preschool_stand_alone");
            entity.Property(e => e.ProviderApprovalNumber)
                .HasMaxLength(50)
                .HasColumnName("Provider_Approval_Number");
            entity.Property(e => e.ProviderName)
                .HasMaxLength(150)
                .HasColumnName("Provider_Name");
            entity.Property(e => e.ServiceAddress)
                .HasMaxLength(100)
                .HasColumnName("Service_Address");
            entity.Property(e => e.ServiceApprovalNumber)
                .HasMaxLength(50)
                .HasColumnName("Service_Approval_Number");
            entity.Property(e => e.ServiceName)
                .HasMaxLength(150)
                .HasColumnName("Service_Name");
            entity.Property(e => e.ServiceType)
                .HasMaxLength(50)
                .HasColumnName("Service_Type");
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.Suburb).HasMaxLength(50);
            entity.Property(e => e.VacationCare)
                .HasMaxLength(10)
                .HasColumnName("Vacation_care");
            entity.Property(e => e.XLongitude).HasColumnName("X_longitude");
            entity.Property(e => e.YLatitude).HasColumnName("Y_latitude");
        });

        modelBuilder.Entity<VwAggregatedAreaAllCombination>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAggregatedAreaAllCombinations");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwAggregatedAreaWithForcastArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAggregatedAreaWithForcastArea");

            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.ForecastAreaBoundaryId).HasColumnName("ForecastAreaBoundaryID");
            entity.Property(e => e.ForecastAreaBoundaryName).HasMaxLength(120);
            entity.Property(e => e.ForecastAreaLgaid)
                .HasMaxLength(4)
                .HasColumnName("ForecastAreaLGAID");
        });

        modelBuilder.Entity<VwAggregatedAreasDistinct>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAggregatedAreasDistinct");

            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserLgaid)
                .HasMaxLength(4)
                .HasColumnName("UserLGAid");
        });

        modelBuilder.Entity<VwAggregatedComponentForecastArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAggregatedComponentForecastAreas");

            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
        });

        modelBuilder.Entity<VwAssetCondition>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAssetCondition");

            entity.Property(e => e.AddedBy).HasMaxLength(100);
            entity.Property(e => e.AddedTime).HasColumnType("datetime");
            entity.Property(e => e.Additionalident).HasMaxLength(30);
            entity.Property(e => e.AssetCondition).HasMaxLength(118);
            entity.Property(e => e.AssetId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AssetID");
            entity.Property(e => e.AssetRef).HasMaxLength(20);
            entity.Property(e => e.AssetRegisterName1).HasMaxLength(150);
            entity.Property(e => e.AssetRegisterName2).HasMaxLength(150);
            entity.Property(e => e.ChangedBy).HasMaxLength(100);
            entity.Property(e => e.ChangedTime).HasColumnType("datetime");
            entity.Property(e => e.ConditionDescriptionOverall1).HasMaxLength(50);
            entity.Property(e => e.ConditionScoreOverallNumeric1).HasColumnType("decimal(4, 1)");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.LockedBy).HasMaxLength(100);
            entity.Property(e => e.LockedTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<VwAssetConditionConcatenated>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAssetCondition_Concatenated");

            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
        });

        modelBuilder.Entity<VwAssetsByFacility>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAssetsByFacilities");

            entity.Property(e => e.AssetRef).HasMaxLength(20);
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
        });

        modelBuilder.Entity<VwAssetsConcatenatedByFacility>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAssetsConcatenatedByFacility");

            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
        });

        modelBuilder.Entity<VwBenchmarkingComparisonRatio>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("_vwBenchmarking_ComparisonRatios");

            entity.Property(e => e.AreaName)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Area_name");
            entity.Property(e => e.BenchmarkRatio)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("Benchmark_ratio");
            entity.Property(e => e.BenchmarkTitle)
                .HasMaxLength(100)
                .HasColumnName("Benchmark_title");
            entity.Property(e => e.BenchmarkTitleFull)
                .HasMaxLength(159)
                .HasColumnName("Benchmark_title_full");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.ShortTitle)
                .HasMaxLength(100)
                .HasColumnName("Short_title");
            entity.Property(e => e.ShortUse)
                .HasMaxLength(100)
                .HasColumnName("Short_use");
            entity.Property(e => e.UnitType).HasMaxLength(50);
        });

        modelBuilder.Entity<VwBenchmarkingCurrentRatio>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("_vwBenchmarking_CurrentRatios");

            entity.Property(e => e.AreaName)
                .HasMaxLength(150)
                .HasColumnName("Area_name");
            entity.Property(e => e.BenchmarkRatio).HasColumnName("Benchmark_ratio");
            entity.Property(e => e.BenchmarkTitle)
                .HasMaxLength(100)
                .HasColumnName("Benchmark_title");
            entity.Property(e => e.BenchmarkTitleFull)
                .HasMaxLength(159)
                .HasColumnName("Benchmark_title_full");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.ShortTitle)
                .HasMaxLength(100)
                .HasColumnName("Short_title");
            entity.Property(e => e.ShortUse)
                .HasMaxLength(100)
                .HasColumnName("Short_use");
            entity.Property(e => e.UnitType).HasMaxLength(50);
        });

        modelBuilder.Entity<VwBenchmarkingTest1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("_vwBenchmarkingTest1");

            entity.Property(e => e.AreaName)
                .HasMaxLength(150)
                .HasColumnName("Area_name");
            entity.Property(e => e.BenchmarkRatio).HasColumnName("Benchmark_ratio");
            entity.Property(e => e.BenchmarkTitle)
                .HasMaxLength(100)
                .HasColumnName("Benchmark_title");
            entity.Property(e => e.BenchmarkTitleFull)
                .HasMaxLength(159)
                .HasColumnName("Benchmark_title_full");
            entity.Property(e => e.CasimoLgaName)
                .HasMaxLength(60)
                .HasColumnName("CASIMO_LGA_name");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.UnitType)
                .HasMaxLength(50)
                .HasColumnName("Unit_type");
        });

        modelBuilder.Entity<VwBoundariesForecastArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBoundariesForecastArea");

            entity.Property(e => e.BoundaryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryName).HasMaxLength(120);
            entity.Property(e => e.BoundaryTypeId).HasColumnName("BoundaryTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.StateCode)
                .HasMaxLength(3)
                .IsFixedLength();
        });

        modelBuilder.Entity<VwCustomUseGroupByLga>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCustomUseGroupByLGA");

            entity.Property(e => e.CustomUseGroupId).HasColumnName("CustomUseGroupID");
            entity.Property(e => e.CustomUseGroupName).HasMaxLength(100);
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
        });

        modelBuilder.Entity<VwCustomUseGroupsByService>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCustomUseGroupsByService");

            entity.Property(e => e.CustomUseGroupId).HasColumnName("CustomUseGroupID");
            entity.Property(e => e.CustomUseGroupName).HasMaxLength(100);
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
        });

        modelBuilder.Entity<VwCustomUseGroupsByServiceConcatenated>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCustomUseGroupsByService_Concatenated");

            entity.Property(e => e.CustomGroups)
                .HasMaxLength(1000)
                .HasColumnName("Custom_groups");
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
        });

        modelBuilder.Entity<VwCustomUseGroupsConcatenated>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCustomUseGroups_Concatenated");

            entity.Property(e => e.CustomUseGroups).IsUnicode(false);
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
        });

        modelBuilder.Entity<VwDevTestRc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("_vwDevTestRC");

            entity.Property(e => e.AgeCohort)
                .HasMaxLength(20)
                .HasColumnName("Age_Cohort");
            entity.Property(e => e.CohortSize).HasColumnName("Cohort_Size");
            entity.Property(e => e.ComparisonArea)
                .HasMaxLength(150)
                .HasColumnName("Comparison_area");
            entity.Property(e => e.ComponentForecastAreas).HasColumnName("Component_Forecast_areas");
            entity.Property(e => e.CurrentRatio)
                .HasMaxLength(328)
                .HasColumnName("Current_Ratio");
            entity.Property(e => e.Difference).HasColumnName("Difference_#");
            entity.Property(e => e.ExistingQuantity).HasColumnName("Existing_Quantity");
            entity.Property(e => e.QuantityStandard)
                .HasMaxLength(159)
                .HasColumnName("Quantity_Standard");
            entity.Property(e => e.TargetQuantity).HasColumnName("Target_Quantity");
            entity.Property(e => e.TargetRatio)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("Target_Ratio");
        });

        modelBuilder.Entity<VwFacilitiesRelatedUsesForGi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFacilitiesRelatedUses_forGIS");

            entity.Property(e => e.AccessType).HasMaxLength(25);
            entity.Property(e => e.AccessTypeDescription)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("Access_type_description");
            entity.Property(e => e.Additionalident).HasMaxLength(30);
            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.AssetRef).HasMaxLength(20);
            entity.Property(e => e.Attribute1).HasMaxLength(100);
            entity.Property(e => e.Attribute2).HasMaxLength(100);
            entity.Property(e => e.FacilityComponent).HasMaxLength(150);
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilityNameFull)
                .HasMaxLength(303)
                .HasColumnName("FacilityName_full");
            entity.Property(e => e.FacilitySite).HasMaxLength(150);
            entity.Property(e => e.FacilityStatus).HasMaxLength(25);
            entity.Property(e => e.HierarchyLevel).HasMaxLength(100);
            entity.Property(e => e.InfTypeHierarchyAttributes)
                .HasMaxLength(409)
                .HasColumnName("InfType_Hierarchy_Attributes");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.Lganame)
                .HasMaxLength(60)
                .HasColumnName("LGAname");
            entity.Property(e => e.Operator).HasMaxLength(150);
            entity.Property(e => e.Owner).HasMaxLength(150);
            entity.Property(e => e.RelatedUseComment)
                .HasMaxLength(255)
                .HasColumnName("Related_use_comment");
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.Type).HasMaxLength(100);
            entity.Property(e => e.XLongitude).HasColumnName("X_longitude");
            entity.Property(e => e.YLatitude).HasColumnName("Y_latitude");
        });

        modelBuilder.Entity<VwFacilitiesUsesQuantitiesForGi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFacilitiesUsesQuantities_forGIS");

            entity.Property(e => e.AccessType).HasMaxLength(25);
            entity.Property(e => e.AccessTypeDescription)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("Access_type_description");
            entity.Property(e => e.Additionalident).HasMaxLength(30);
            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.AssetRef).HasMaxLength(20);
            entity.Property(e => e.Attribute1).HasMaxLength(100);
            entity.Property(e => e.Attribute2).HasMaxLength(100);
            entity.Property(e => e.FacilityComponent).HasMaxLength(150);
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilityNameFull)
                .HasMaxLength(303)
                .HasColumnName("FacilityName_full");
            entity.Property(e => e.FacilitySite).HasMaxLength(150);
            entity.Property(e => e.FacilityStatus).HasMaxLength(25);
            entity.Property(e => e.HierarchyLevel).HasMaxLength(100);
            entity.Property(e => e.InfTypeHierarchyAttributes)
                .HasMaxLength(409)
                .HasColumnName("InfType_Hierarchy_Attributes");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.Lganame)
                .HasMaxLength(60)
                .HasColumnName("LGAname");
            entity.Property(e => e.Operator).HasMaxLength(150);
            entity.Property(e => e.Owner).HasMaxLength(150);
            entity.Property(e => e.Quantity).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.RelatedUseComment)
                .HasMaxLength(255)
                .HasColumnName("Related_use_comment");
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.Type).HasMaxLength(100);
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.XLongitude).HasColumnName("X_longitude");
            entity.Property(e => e.YLatitude).HasColumnName("Y_latitude");
        });

        modelBuilder.Entity<VwFacilityDateLastUpdated>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFacilityDateLastUpdated");

            entity.Property(e => e.DateLastUpdated).HasColumnType("datetime");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
        });

        modelBuilder.Entity<VwFacilityDateLastUpdatedBaseQ>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFacilityDateLastUpdatedBaseQ");

            entity.Property(e => e.AddedTimeFacility).HasColumnType("datetime");
            entity.Property(e => e.AddedTimeService).HasColumnType("datetime");
            entity.Property(e => e.AddedTimeServiceQty).HasColumnType("datetime");
            entity.Property(e => e.ChangedTimeFacility).HasColumnType("datetime");
            entity.Property(e => e.ChangedTimeService).HasColumnType("datetime");
            entity.Property(e => e.ChangedTimeServiceQty).HasColumnType("datetime");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
        });

        modelBuilder.Entity<VwFfpasstOverallScoreBaseQQn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFFPasstOverallScore_BaseQ_Qn");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.Score1title).HasMaxLength(50);
            entity.Property(e => e.Score2title).HasMaxLength(50);
            entity.Property(e => e.ScoreSystemId).HasColumnName("ScoreSystemID");
            entity.Property(e => e.WeightPercent).HasColumnType("decimal(3, 1)");
        });

        modelBuilder.Entity<VwFfpasstOverallScoreBaseQSec>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFFPasstOverallScore_BaseQ_Sec");

            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.Score1title).HasMaxLength(50);
            entity.Property(e => e.Score2title).HasMaxLength(50);
            entity.Property(e => e.ScoreSystemId).HasColumnName("ScoreSystemID");
            entity.Property(e => e.SectionScore1).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.SectionScore2).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.WeightPercent).HasColumnType("decimal(3, 1)");
        });

        modelBuilder.Entity<VwFfpasstOverallScoreFinal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFFPasstOverallScore_Final");

            entity.Property(e => e.FacilityComponent).HasMaxLength(150);
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilitySite).HasMaxLength(150);
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.MaxScore1).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MaxScore2).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MinScore1).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MinScore2).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.OverallScore1).HasColumnType("numeric(10, 1)");
            entity.Property(e => e.OverallScore2).HasColumnType("numeric(10, 1)");
            entity.Property(e => e.RangeText1).HasMaxLength(119);
            entity.Property(e => e.RangeText2).HasMaxLength(119);
            entity.Property(e => e.Score1title).HasMaxLength(50);
            entity.Property(e => e.Score2title).HasMaxLength(50);
            entity.Property(e => e.ScoreSystemId).HasColumnName("ScoreSystemID");
            entity.Property(e => e.SectionScore1).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.SectionScore2).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
            entity.Property(e => e.TemplateTitle).HasMaxLength(100);
            entity.Property(e => e.Type).HasMaxLength(100);
        });

        modelBuilder.Entity<VwFfpasstOverallScoreSecWtAvgStep0>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFFPasstOverallScore_SecWtAvg_Step0");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.MinSectionScore1).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MinSectionScore2).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.Score1title).HasMaxLength(50);
            entity.Property(e => e.Score2title).HasMaxLength(50);
            entity.Property(e => e.ScoreSystemId).HasColumnName("ScoreSystemID");
            entity.Property(e => e.UnroundedOverallScore1).HasColumnType("decimal(38, 7)");
            entity.Property(e => e.UnroundedOverallScore2).HasColumnType("decimal(38, 7)");
        });

        modelBuilder.Entity<VwFfpasstOverallScoreSecWtAvgStep1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFFPasstOverallScore_SecWtAvg_Step1");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.Score1title).HasMaxLength(50);
            entity.Property(e => e.Score2title).HasMaxLength(50);
            entity.Property(e => e.ScoreSystemId).HasColumnName("ScoreSystemID");
        });

        modelBuilder.Entity<VwFfpasstOverallScoreStep0>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFFPasstOverallScore_Step0");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.MaxScore1).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MaxScore2).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MinScore1).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MinScore2).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.OverallScore1).HasColumnType("numeric(10, 1)");
            entity.Property(e => e.OverallScore2).HasColumnType("numeric(10, 1)");
            entity.Property(e => e.OverrideSuffix1)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.OverrideSuffix2)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.Score1title).HasMaxLength(50);
            entity.Property(e => e.Score2title).HasMaxLength(50);
            entity.Property(e => e.ScoreSystemId).HasColumnName("ScoreSystemID");
        });

        modelBuilder.Entity<VwFfpasstOverallScoreStep1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFFPasstOverallScore_Step1");

            entity.Property(e => e.FacilityComponent).HasMaxLength(150);
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilitySite).HasMaxLength(150);
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.MaxScore1).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MaxScore2).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MinScore1).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MinScore2).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.OverallScore1).HasColumnType("numeric(10, 1)");
            entity.Property(e => e.OverallScore2).HasColumnType("numeric(10, 1)");
            entity.Property(e => e.RangeText1).HasMaxLength(119);
            entity.Property(e => e.RangeText2).HasMaxLength(119);
            entity.Property(e => e.Score1title).HasMaxLength(50);
            entity.Property(e => e.Score2title).HasMaxLength(50);
            entity.Property(e => e.ScoreSystemId).HasColumnName("ScoreSystemID");
            entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
            entity.Property(e => e.TemplateTitle).HasMaxLength(100);
            entity.Property(e => e.Type).HasMaxLength(100);
        });

        modelBuilder.Entity<VwFfpasstOverallScoreSubQDynamic>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFFPasstOverallScore_SubQ_Dynamic");

            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.MaxScore1).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MaxScore2).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MinScore1).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MinScore2).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.ModificationPercent).HasColumnType("decimal(3, 2)");
            entity.Property(e => e.OverallScore1).HasColumnType("numeric(10, 1)");
            entity.Property(e => e.OverallScore1WithoutModification)
                .HasColumnType("numeric(11, 1)")
                .HasColumnName("OverallScore1_WithoutModification");
            entity.Property(e => e.OverallScore2).HasColumnType("numeric(10, 1)");
            entity.Property(e => e.OverallScore2WithoutModification)
                .HasColumnType("numeric(11, 1)")
                .HasColumnName("OverallScore2_WithoutModification");
            entity.Property(e => e.OverrideSuffix1)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.OverrideSuffix2)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.Score1title).HasMaxLength(50);
            entity.Property(e => e.Score2title).HasMaxLength(50);
            entity.Property(e => e.ScoreSystemId).HasColumnName("ScoreSystemID");
        });

        modelBuilder.Entity<VwFfpasstOverallScoreSubQQnAvg>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFFPasstOverallScore_SubQ_QnAvg");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.OverallScore1).HasColumnType("numeric(11, 1)");
            entity.Property(e => e.OverallScore2).HasColumnType("numeric(11, 1)");
            entity.Property(e => e.Score1title).HasMaxLength(50);
            entity.Property(e => e.Score2title).HasMaxLength(50);
            entity.Property(e => e.ScoreSystemId).HasColumnName("ScoreSystemID");
        });

        modelBuilder.Entity<VwFfpasstOverallScoreSubQQnSum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFFPasstOverallScore_SubQ_QnSum");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.Score1title).HasMaxLength(50);
            entity.Property(e => e.Score2title).HasMaxLength(50);
            entity.Property(e => e.ScoreSystemId).HasColumnName("ScoreSystemID");
        });

        modelBuilder.Entity<VwFfpasstOverallScoreSubQSecAvg>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFFPasstOverallScore_SubQ_SecAvg");

            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.MaxScore1).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MaxScore2).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MinScore1).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MinScore2).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.OverallScore1).HasColumnType("numeric(11, 1)");
            entity.Property(e => e.OverallScore2).HasColumnType("numeric(11, 1)");
            entity.Property(e => e.OverrideSuffix1)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.OverrideSuffix2)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.Score1title).HasMaxLength(50);
            entity.Property(e => e.Score2title).HasMaxLength(50);
            entity.Property(e => e.ScoreSystemId).HasColumnName("ScoreSystemID");
        });

        modelBuilder.Entity<VwFfpasstOverallScoreSubQSecAvgTodelete>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFFPasstOverallScore_SubQ_SecAvg_TODELETE");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.MaxScore1).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MaxScore2).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MinScore1).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MinScore2).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.OverallScore1).HasColumnType("numeric(11, 1)");
            entity.Property(e => e.OverallScore2).HasColumnType("numeric(11, 1)");
            entity.Property(e => e.OverrideSuffix1)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.OverrideSuffix2)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.Score1title).HasMaxLength(50);
            entity.Property(e => e.Score2title).HasMaxLength(50);
            entity.Property(e => e.ScoreSystemId).HasColumnName("ScoreSystemID");
        });

        modelBuilder.Entity<VwFfpasstOverallScoreSubQSecSum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFFPasstOverallScore_SubQ_SecSum");

            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.MaxScore1).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MaxScore2).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MinScore1).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MinScore2).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.OverallScore1).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.OverallScore2).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.OverrideSuffix1)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.OverrideSuffix2)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.Score1title).HasMaxLength(50);
            entity.Property(e => e.Score2title).HasMaxLength(50);
            entity.Property(e => e.ScoreSystemId).HasColumnName("ScoreSystemID");
        });

        modelBuilder.Entity<VwFfpasstOverallScoreSubQSecWtAvg>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFFPasstOverallScore_SubQ_SecWtAvg");

            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.MaxScore1).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MaxScore2).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MinScore1).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MinScore2).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.ModificationPercent).HasColumnType("decimal(3, 2)");
            entity.Property(e => e.OverallScore1).HasColumnType("numeric(10, 1)");
            entity.Property(e => e.OverallScore1WithoutModification)
                .HasColumnType("numeric(11, 1)")
                .HasColumnName("OverallScore1_WithoutModification");
            entity.Property(e => e.OverallScore2).HasColumnType("numeric(10, 1)");
            entity.Property(e => e.OverallScore2WithoutModification)
                .HasColumnType("numeric(11, 1)")
                .HasColumnName("OverallScore2_WithoutModification");
            entity.Property(e => e.OverrideSuffix1)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.OverrideSuffix2)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.Score1title).HasMaxLength(50);
            entity.Property(e => e.Score2title).HasMaxLength(50);
            entity.Property(e => e.ScoreSystemId).HasColumnName("ScoreSystemID");
        });

        modelBuilder.Entity<VwFfpasstOverallScoreSubQSecWtAvgStep0>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFFPasstOverallScore_SubQ_SecWtAvg_Step0");

            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.MaxScore1).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MaxScore2).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MinScore1).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MinScore2).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.ModificationPercent).HasColumnType("decimal(3, 2)");
            entity.Property(e => e.OverallScore1WithoutModification)
                .HasColumnType("numeric(11, 1)")
                .HasColumnName("OverallScore1_WithoutModification");
            entity.Property(e => e.OverallScore2WithoutModification)
                .HasColumnType("numeric(11, 1)")
                .HasColumnName("OverallScore2_WithoutModification");
            entity.Property(e => e.Score1title).HasMaxLength(50);
            entity.Property(e => e.Score2title).HasMaxLength(50);
            entity.Property(e => e.ScoreSystemId).HasColumnName("ScoreSystemID");
        });

        modelBuilder.Entity<VwFfpasstOverallScoreSubQSecWtAvgTodelete>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFFPasstOverallScore_SubQ_SecWtAvg_TODELETE");

            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.MaxScore1).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MaxScore2).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MinScore1).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MinScore2).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.ModificationPercent).HasColumnType("decimal(3, 2)");
            entity.Property(e => e.OverallScore1).HasColumnType("numeric(10, 1)");
            entity.Property(e => e.OverallScore1WithoutModification)
                .HasColumnType("numeric(11, 1)")
                .HasColumnName("OverallScore1_WithoutModification");
            entity.Property(e => e.OverallScore2).HasColumnType("numeric(10, 1)");
            entity.Property(e => e.OverallScore2WithoutModification)
                .HasColumnType("numeric(11, 1)")
                .HasColumnName("OverallScore2_WithoutModification");
            entity.Property(e => e.OverrideSuffix1)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.OverrideSuffix2)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.Score1title).HasMaxLength(50);
            entity.Property(e => e.Score2title).HasMaxLength(50);
            entity.Property(e => e.ScoreSystemId).HasColumnName("ScoreSystemID");
        });

        modelBuilder.Entity<VwFfpasstSectionScoresRangeText>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFFPasstSectionScoresRangeText");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.SectionScore1).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.SectionScore1Rating).HasMaxLength(100);
            entity.Property(e => e.SectionScore2).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.SectionScore2Rating).HasMaxLength(100);
        });

        modelBuilder.Entity<VwFfpresultsOverallScore>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFFPResults_OverallScores");

            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilitySite).HasMaxLength(150);
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.Score1title).HasMaxLength(50);
            entity.Property(e => e.Score2title).HasMaxLength(50);
            entity.Property(e => e.ScoreClassification1).HasMaxLength(100);
            entity.Property(e => e.ScoreClassification2).HasMaxLength(100);
            entity.Property(e => e.Use).HasMaxLength(100);
            entity.Property(e => e.XLongitude).HasColumnName("X_longitude");
            entity.Property(e => e.YLatitude).HasColumnName("Y_latitude");
        });

        modelBuilder.Entity<VwFfpscoreSysScoreMin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFFPScoreSysScoreMin");

            entity.Property(e => e.ScoreSysTitleId).HasColumnName("ScoreSysTitleID");
        });

        modelBuilder.Entity<VwFlaggedRecord>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFlaggedRecords");

            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
        });

        modelBuilder.Entity<VwFlaggedRecordsAttribute1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFlaggedRecordsAttribute1");

            entity.Property(e => e.Attribute1Id).HasColumnName("Attribute1ID");
            entity.Property(e => e.AttributeName1Id).HasColumnName("AttributeName1ID");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            entity.Property(e => e.Type).HasMaxLength(100);
        });

        modelBuilder.Entity<VwFlaggedRecordsAttribute2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFlaggedRecordsAttribute2");

            entity.Property(e => e.Attribute2Id).HasColumnName("Attribute2ID");
            entity.Property(e => e.AttributeName2Id).HasColumnName("AttributeName2ID");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            entity.Property(e => e.Type).HasMaxLength(100);
        });

        modelBuilder.Entity<VwFlaggedRecordsHierarchy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFlaggedRecordsHierarchy");

            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.HierarchyLevelId).HasColumnName("HierarchyLevelID");
            entity.Property(e => e.HierarchyNameId).HasColumnName("HierarchyNameID");
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            entity.Property(e => e.Type).HasMaxLength(100);
        });

        modelBuilder.Entity<VwFlaggedRecordsUnitQuantity>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFlaggedRecordsUnitQuantity");

            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.Quantity).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Type).HasMaxLength(100);
            entity.Property(e => e.UnitType).HasMaxLength(50);
        });

        modelBuilder.Entity<VwForecastAreaAllCombination>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwForecastAreaAllCombinations");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.StdName).HasMaxLength(100);
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwForecastAreaBoundaryDistinct>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwForecastAreaBoundaryDistinct");

            entity.Property(e => e.ForecastAreaBoundaryId).HasColumnName("ForecastAreaBoundaryID");
            entity.Property(e => e.ForecastAreaBoundaryName).HasMaxLength(120);
            entity.Property(e => e.ForecastAreaLgaid)
                .HasMaxLength(4)
                .HasColumnName("ForecastAreaLGAID");
        });

        modelBuilder.Entity<VwForecastAreasDistinct>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwForecastAreasDistinct");

            entity.Property(e => e.Area).HasMaxLength(255);
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
        });

        modelBuilder.Entity<VwFrTableViewMasterQry>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFR_TableViewMasterQry");

            entity.Property(e => e.AccessTypeId).HasColumnName("AccessTypeID");
            entity.Property(e => e.Additionalident).HasMaxLength(30);
            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.AssetRef).HasMaxLength(20);
            entity.Property(e => e.Attribute1Id).HasColumnName("Attribute1ID");
            entity.Property(e => e.Attribute2Id).HasColumnName("Attribute2ID");
            entity.Property(e => e.Component).HasMaxLength(150);
            entity.Property(e => e.CoordsCorrectLga).HasColumnName("CoordsCorrectLGA");
            entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");
            entity.Property(e => e.CustomGroups)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Custom_groups");
            entity.Property(e => e.CustomUseGroupName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Facility).HasMaxLength(150);
            entity.Property(e => e.FacilityComponent).HasMaxLength(150);
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilitySite).HasMaxLength(150);
            entity.Property(e => e.HierarchyLevelId).HasColumnName("HierarchyLevelID");
            entity.Property(e => e.InfType).HasMaxLength(100);
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.Operator).HasMaxLength(150);
            entity.Property(e => e.Owner).HasMaxLength(150);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.PublicAccess).HasMaxLength(25);
            entity.Property(e => e.PublicAccessDescription)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.Quantity).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            entity.Property(e => e.ServiceOwner).HasMaxLength(120);
            entity.Property(e => e.ServiceUnitQuantityId).HasColumnName("ServiceUnitQuantityID");
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.StdName).HasMaxLength(100);
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.Use)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UseOld)
                .HasMaxLength(100)
                .HasColumnName("Use_Old");
            entity.Property(e => e.UserInterestId).HasColumnName("UserInterestID");
            entity.Property(e => e.XLongitude).HasColumnName("X_longitude");
            entity.Property(e => e.YLatitude).HasColumnName("Y_latitude");
        });

        modelBuilder.Entity<VwFrTableViewMasterQryStep0>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFR_TableViewMasterQry_Step0");

            entity.Property(e => e.AccessTypeId).HasColumnName("AccessTypeID");
            entity.Property(e => e.Additionalident).HasMaxLength(30);
            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.AssetRef).HasMaxLength(20);
            entity.Property(e => e.Attribute1Id).HasColumnName("Attribute1ID");
            entity.Property(e => e.Attribute2Id).HasColumnName("Attribute2ID");
            entity.Property(e => e.Component).HasMaxLength(150);
            entity.Property(e => e.CoordsCorrectLga).HasColumnName("CoordsCorrectLGA");
            entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");
            entity.Property(e => e.CustomGroups)
                .HasMaxLength(1000)
                .HasColumnName("Custom_groups");
            entity.Property(e => e.CustomUseGroupName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Facility).HasMaxLength(150);
            entity.Property(e => e.FacilityComponent).HasMaxLength(150);
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilitySite).HasMaxLength(150);
            entity.Property(e => e.HierarchyLevelId).HasColumnName("HierarchyLevelID");
            entity.Property(e => e.InfType).HasMaxLength(100);
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.Operator).HasMaxLength(150);
            entity.Property(e => e.Owner).HasMaxLength(150);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.PublicAccess).HasMaxLength(25);
            entity.Property(e => e.PublicAccessDescription)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Quantity).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            entity.Property(e => e.ServiceOwner).HasMaxLength(120);
            entity.Property(e => e.ServiceUnitQuantityId).HasColumnName("ServiceUnitQuantityID");
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.Use)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UseOld)
                .HasMaxLength(100)
                .HasColumnName("Use_Old");
            entity.Property(e => e.UserInterestId).HasColumnName("UserInterestID");
            entity.Property(e => e.XLongitude).HasColumnName("X_longitude");
            entity.Property(e => e.YLatitude).HasColumnName("Y_latitude");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears0>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_0");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears104>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_104");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears105>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_105");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears107>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_107");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears109>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_109");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears110>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_110");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears18>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_18");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears24>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_24");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears27>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_27");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears28>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_28");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears31>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_31");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears33>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_33");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears37>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_37");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears38>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_38");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears40>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_40");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears41>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_41");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears46>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_46");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears47>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_47");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears49>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_49");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears53>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_53");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears54>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_54");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears55>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_55");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears56>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_56");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears57>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_57");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears6>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_6");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears61>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_61");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears62>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_62");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears63>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_63");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears64>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_64");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears68>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_68");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears69>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_69");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears70>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_70");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears82>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_82");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears84>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_84");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears88>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_88");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears89>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_89");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears90>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_90");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears91>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_91");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears92>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_92");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears94>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_94");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYears95>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_95");

            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosAggregatedAllYearsLgacopy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_AggregatedAllYears_LGAcopy");

            entity.Property(e => e.ActualRatio).HasColumnName("Actual_ratio");
            entity.Property(e => e.AggrAreaUserLgaid)
                .HasMaxLength(4)
                .HasColumnName("AggrAreaUserLGAid");
            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(150);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.ExistingQuantity).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.ExistingUnits)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("Existing_units");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Targetpop)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("targetpop");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears0>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_0");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears101>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_101");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears102>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_102");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears104>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_104");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears105>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_105");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears106>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_106");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears107>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_107");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears109>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_109");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears110>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_110");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears18>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_18");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears24>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_24");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears27>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_27");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears28>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_28");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears31>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_31");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears33>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_33");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears37>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_37");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears38>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_38");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears40>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_40");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears41>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_41");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears42>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_42");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears43>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_43");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears44>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_44");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears46>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_46");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears47>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_47");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears48>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_48");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears49>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_49");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears53>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_53");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears54>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_54");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears55>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_55");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears56>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_56");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears57>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_57");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears58>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_58");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears59>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_59");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears6>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_6");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears61>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_61");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears62>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_62");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears63>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_63");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears64>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_64");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears68>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_68");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears69>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_69");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears70>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_70");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears74>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_74");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears75>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_75");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears76>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_76");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears80>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_80");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears82>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_82");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears83>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_83");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears84>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_84");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears88>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_88");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears89>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_89");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears90>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_90");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears91>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_91");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears92>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_92");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears94>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_94");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears95>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_95");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYears999>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_999");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwGetRatiosForecastAllYearsLgacopy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwGetRatios_ForecastAllYears_LGAcopy");

            entity.Property(e => e.ActualRatio).HasColumnName("Actual_ratio");
            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.BoundaryLgaid)
                .HasMaxLength(4)
                .HasColumnName("BoundaryLGAid");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.ExistingQuantity).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.ExistingUnits)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("Existing_units");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.PopRatioStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("PopRatioStdsLGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.QtyAssessmentStdsLgaid)
                .HasMaxLength(4)
                .HasColumnName("QtyAssessmentStdsLGAid");
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwInfGroupClassTypeByLga>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwInfGroupClassTypeByLGA");

            entity.Property(e => e.InfType).HasMaxLength(100);
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
        });

        modelBuilder.Entity<VwInfGroupClassTypeByLgawithQtyStandard>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwInfGroupClassTypeByLGAWithQtyStandard");

            entity.Property(e => e.DefaultCohortId).HasColumnName("DefaultCohortID");
            entity.Property(e => e.FacilityLgaid)
                .HasMaxLength(4)
                .HasColumnName("FacilityLGAid");
            entity.Property(e => e.InfType).HasMaxLength(100);
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
        });

        modelBuilder.Entity<VwInfGroupClassTypeWithLgacriticality>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwInfGroupClassTypeWithLGACriticality");

            entity.Property(e => e.CriticalityType).HasMaxLength(50);
            entity.Property(e => e.CriticalityTypeId).HasColumnName("CriticalityTypeID");
            entity.Property(e => e.InfType).HasMaxLength(100);
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(255)
                .HasColumnName("LGAid");
        });

        modelBuilder.Entity<VwInfTypeByLga>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwInfTypeByLGA");

            entity.Property(e => e.DefaultCohortId).HasColumnName("DefaultCohortID");
            entity.Property(e => e.DefaultUnitTypeId).HasColumnName("DefaultUnitTypeID");
            entity.Property(e => e.Definition).HasColumnType("ntext");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.Type).HasMaxLength(100);
        });

        modelBuilder.Entity<VwInfTypeHierarchyAttributeCombination>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwInfTypeHierarchyAttributeCombinations");

            entity.Property(e => e.Attribute1).HasMaxLength(100);
            entity.Property(e => e.Attribute1Id).HasColumnName("Attribute1ID");
            entity.Property(e => e.Attribute2).HasMaxLength(100);
            entity.Property(e => e.Attribute2Id).HasColumnName("Attribute2ID");
            entity.Property(e => e.DefaultCohortId).HasColumnName("DefaultCohortID");
            entity.Property(e => e.HierarchyLevel).HasMaxLength(100);
            entity.Property(e => e.HierarchyLevelId).HasColumnName("HierarchyLevelID");
            entity.Property(e => e.InfTypeHierarchyAttributes)
                .HasMaxLength(409)
                .HasColumnName("InfType_Hierarchy_Attributes");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwInfTypeHierarchyLevelsAttribute>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwInfTypeHierarchyLevelsAttributes");

            entity.Property(e => e.Attribute1).HasMaxLength(100);
            entity.Property(e => e.Attribute1Id).HasColumnName("Attribute1ID");
            entity.Property(e => e.Attribute2).HasMaxLength(100);
            entity.Property(e => e.Attribute2Id).HasColumnName("Attribute2ID");
            entity.Property(e => e.AttributeName1Id).HasColumnName("AttributeName1ID");
            entity.Property(e => e.AttributeName2Id).HasColumnName("AttributeName2ID");
            entity.Property(e => e.HierarchyLevel).HasMaxLength(100);
            entity.Property(e => e.HierarchyLevelId).HasColumnName("HierarchyLevelID");
            entity.Property(e => e.HierarchyNameId).HasColumnName("HierarchyNameID");
            entity.Property(e => e.InfTypeHierarchyAttributes)
                .HasMaxLength(409)
                .HasColumnName("InfType_Hierarchy_Attributes");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
        });

        modelBuilder.Entity<VwInfTypeUnit>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwInfTypeUnits");

            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.InfTypeUnitId).HasColumnName("InfTypeUnitID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwInfTypeUnitsByLga>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwInfTypeUnitsByLGA");

            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwInfTypeUnitsConcatenated>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwInfTypeUnits_Concatenated");

            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.UnitTypes).IsUnicode(false);
        });

        modelBuilder.Entity<VwLgacopyCasimoFfpresultsOverallScore>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLGAcopy_CASIMO_FFPresults_OverallScores");

            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.AssessmentDate)
                .HasColumnType("datetime")
                .HasColumnName("Assessment_Date");
            entity.Property(e => e.AssessmentPersons)
                .HasMaxLength(255)
                .HasColumnName("Assessment_Persons");
            entity.Property(e => e.CasimoFacilityId).HasColumnName("CASIMO_FacilityID");
            entity.Property(e => e.CasimoFfplogId).HasColumnName("CASIMO_FFPlogID");
            entity.Property(e => e.CasimoLgaId)
                .HasMaxLength(4)
                .HasColumnName("CASIMO_LGA_ID");
            entity.Property(e => e.CasimoLgaName)
                .HasMaxLength(60)
                .HasColumnName("CASIMO_LGA_name");
            entity.Property(e => e.CouncilAssetRef)
                .HasMaxLength(20)
                .HasColumnName("Council_asset_ref");
            entity.Property(e => e.CustomGroups)
                .IsUnicode(false)
                .HasColumnName("Custom_groups");
            entity.Property(e => e.FacilityNameComponent)
                .HasMaxLength(150)
                .HasColumnName("Facility_name_(component)");
            entity.Property(e => e.FacilityNameFull)
                .HasMaxLength(303)
                .HasColumnName("Facility_name_full");
            entity.Property(e => e.FacilityNameSite)
                .HasMaxLength(150)
                .HasColumnName("Facility_name_(site)");
            entity.Property(e => e.FfpAssessedUse)
                .HasMaxLength(100)
                .HasColumnName("FFP_Assessed_Use");
            entity.Property(e => e.FfpOverallScore)
                .HasColumnType("numeric(10, 1)")
                .HasColumnName("FFP_Overall_Score");
            entity.Property(e => e.FfpOverallScore2)
                .HasColumnType("numeric(10, 1)")
                .HasColumnName("FFP_Overall_Score2");
            entity.Property(e => e.FfpOverallScore2Description)
                .HasMaxLength(119)
                .HasColumnName("FFP_Overall_Score2_Description");
            entity.Property(e => e.FfpOverallScoreDescription)
                .HasMaxLength(119)
                .HasColumnName("FFP_Overall_Score_Description");
            entity.Property(e => e.FfpPoorestCatScore)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("FFP_Poorest_Cat_Score");
            entity.Property(e => e.FfpPoorestCatScore2)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("FFP_Poorest_Cat_Score2");
            entity.Property(e => e.FfpTemplate)
                .HasMaxLength(100)
                .HasColumnName("FFP_Template");
            entity.Property(e => e.LatitudeY).HasColumnName("Latitude_Y");
            entity.Property(e => e.LongitudeX).HasColumnName("Longitude_X");
            entity.Property(e => e.NameAndAssessedUse)
                .HasMaxLength(409)
                .HasColumnName("Name_and_assessed_use");
            entity.Property(e => e.Operator).HasMaxLength(150);
            entity.Property(e => e.Owner).HasMaxLength(150);
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.UniqueRecordId)
                .HasMaxLength(61)
                .HasColumnName("UniqueRecordID");
        });

        modelBuilder.Entity<VwLgacopyCasimoFfpresultsOverallScoresTempbackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLGAcopy_CASIMO_FFPresults_OverallScores_TEMPBACKUP");

            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.CasimoFacilityId).HasColumnName("CASIMO_FacilityID");
            entity.Property(e => e.CasimoFfplogId).HasColumnName("CASIMO_FFPlogID");
            entity.Property(e => e.CasimoLgaId)
                .HasMaxLength(4)
                .HasColumnName("CASIMO_LGA_ID");
            entity.Property(e => e.CasimoLgaName)
                .HasMaxLength(60)
                .HasColumnName("CASIMO_LGA_name");
            entity.Property(e => e.CouncilAssetRef)
                .HasMaxLength(20)
                .HasColumnName("Council_asset_ref");
            entity.Property(e => e.CustomGroups)
                .IsUnicode(false)
                .HasColumnName("Custom_groups");
            entity.Property(e => e.FacilityNameComponent)
                .HasMaxLength(150)
                .HasColumnName("Facility_name_(component)");
            entity.Property(e => e.FacilityNameFull)
                .HasMaxLength(303)
                .HasColumnName("Facility_name_full");
            entity.Property(e => e.FacilityNameSite)
                .HasMaxLength(150)
                .HasColumnName("Facility_name_(site)");
            entity.Property(e => e.FfpAssessedUse)
                .HasMaxLength(100)
                .HasColumnName("FFP_Assessed_Use");
            entity.Property(e => e.FfpOverallScore)
                .HasColumnType("numeric(10, 1)")
                .HasColumnName("FFP_Overall_Score");
            entity.Property(e => e.FfpOverallScore2)
                .HasColumnType("numeric(10, 1)")
                .HasColumnName("FFP_Overall_Score2");
            entity.Property(e => e.FfpOverallScore2Description)
                .HasMaxLength(119)
                .HasColumnName("FFP_Overall_Score2_Description");
            entity.Property(e => e.FfpOverallScoreDescription)
                .HasMaxLength(119)
                .HasColumnName("FFP_Overall_Score_Description");
            entity.Property(e => e.FfpPoorestCatScore)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("FFP_Poorest_Cat_Score");
            entity.Property(e => e.FfpPoorestCatScore2)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("FFP_Poorest_Cat_Score2");
            entity.Property(e => e.FfpTemplate)
                .HasMaxLength(100)
                .HasColumnName("FFP_Template");
            entity.Property(e => e.LatitudeY).HasColumnName("Latitude_Y");
            entity.Property(e => e.LongitudeX).HasColumnName("Longitude_X");
            entity.Property(e => e.NameAndAssessedUse)
                .HasMaxLength(409)
                .HasColumnName("Name_and_assessed_use");
            entity.Property(e => e.Operator).HasMaxLength(150);
            entity.Property(e => e.Owner).HasMaxLength(150);
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.UniqueRecordId)
                .HasMaxLength(61)
                .HasColumnName("UniqueRecordID");
        });

        modelBuilder.Entity<VwLgacopyCasimoFfpresultsQuestionResponse>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLGAcopy_CASIMO_FFPresults_QuestionResponses");

            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.CasimoFacilityId).HasColumnName("CASIMO_FacilityID");
            entity.Property(e => e.CasimoFfplogId).HasColumnName("CASIMO_FFPlogID");
            entity.Property(e => e.CasimoLgaId)
                .HasMaxLength(4)
                .HasColumnName("CASIMO_LGA_ID");
            entity.Property(e => e.CasimoLgaName)
                .HasMaxLength(60)
                .HasColumnName("CASIMO_LGA_name");
            entity.Property(e => e.CouncilAssetRef)
                .HasMaxLength(20)
                .HasColumnName("Council_asset_ref");
            entity.Property(e => e.CustomGroups)
                .IsUnicode(false)
                .HasColumnName("Custom_groups");
            entity.Property(e => e.FacilityNameComponent)
                .HasMaxLength(150)
                .HasColumnName("Facility_name_(component)");
            entity.Property(e => e.FacilityNameFull)
                .HasMaxLength(303)
                .HasColumnName("Facility_name_full");
            entity.Property(e => e.FacilityNameSite)
                .HasMaxLength(150)
                .HasColumnName("Facility_name_(site)");
            entity.Property(e => e.FfpAssessedUse)
                .HasMaxLength(100)
                .HasColumnName("FFP_Assessed_Use");
            entity.Property(e => e.FfpCategory)
                .HasMaxLength(182)
                .HasColumnName("FFP_Category");
            entity.Property(e => e.FfpQuestion)
                .HasMaxLength(187)
                .HasColumnName("FFP_Question");
            entity.Property(e => e.FfpQuestionScore).HasColumnName("FFP_Question_Score");
            entity.Property(e => e.FfpQuestionScore2).HasColumnName("FFP_Question_Score2");
            entity.Property(e => e.FfpQuestionTitle)
                .HasMaxLength(137)
                .HasColumnName("FFP_Question_Title");
            entity.Property(e => e.FfpResponse2Selection)
                .HasMaxLength(50)
                .HasColumnName("FFP_Response2_Selection");
            entity.Property(e => e.FfpResponse2Text).HasColumnName("FFP_Response2_Text");
            entity.Property(e => e.FfpResponseSelection)
                .HasMaxLength(50)
                .HasColumnName("FFP_Response_Selection");
            entity.Property(e => e.FfpResponseText).HasColumnName("FFP_Response_Text");
            entity.Property(e => e.FfpTemplate)
                .HasMaxLength(100)
                .HasColumnName("FFP_Template");
            entity.Property(e => e.LatitudeY).HasColumnName("Latitude_Y");
            entity.Property(e => e.LongitudeX).HasColumnName("Longitude_X");
            entity.Property(e => e.Operator).HasMaxLength(150);
            entity.Property(e => e.Owner).HasMaxLength(150);
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.UniqueRecordId)
                .HasMaxLength(92)
                .HasColumnName("UniqueRecordID");
        });

        modelBuilder.Entity<VwLgacopyCasimoFfpresultsSectionResponse>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLGAcopy_CASIMO_FFPresults_SectionResponses");

            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.CasimoFacilityId).HasColumnName("CASIMO_FacilityID");
            entity.Property(e => e.CasimoFfplogId).HasColumnName("CASIMO_FFPlogID");
            entity.Property(e => e.CasimoLgaId)
                .HasMaxLength(4)
                .HasColumnName("CASIMO_LGA_ID");
            entity.Property(e => e.CasimoLgaName)
                .HasMaxLength(60)
                .HasColumnName("CASIMO_LGA_name");
            entity.Property(e => e.CategoryRating)
                .HasMaxLength(100)
                .HasColumnName("Category_Rating");
            entity.Property(e => e.CategoryRating2)
                .HasMaxLength(100)
                .HasColumnName("Category_Rating2");
            entity.Property(e => e.CategoryScore)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("Category_Score");
            entity.Property(e => e.CategoryScore2)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("Category_Score2");
            entity.Property(e => e.CouncilAssetRef)
                .HasMaxLength(20)
                .HasColumnName("Council_asset_ref");
            entity.Property(e => e.CustomGroups)
                .IsUnicode(false)
                .HasColumnName("Custom_groups");
            entity.Property(e => e.FacilityNameComponent)
                .HasMaxLength(150)
                .HasColumnName("Facility_name_(component)");
            entity.Property(e => e.FacilityNameFull)
                .HasMaxLength(303)
                .HasColumnName("Facility_name_full");
            entity.Property(e => e.FacilityNameSite)
                .HasMaxLength(150)
                .HasColumnName("Facility_name_(site)");
            entity.Property(e => e.FfpAssessedUse)
                .HasMaxLength(100)
                .HasColumnName("FFP_Assessed_Use");
            entity.Property(e => e.FfpCategory)
                .HasMaxLength(182)
                .HasColumnName("FFP_Category");
            entity.Property(e => e.FfpCategorySummary).HasColumnName("FFP_Category_Summary");
            entity.Property(e => e.FfpTemplate)
                .HasMaxLength(100)
                .HasColumnName("FFP_Template");
            entity.Property(e => e.LatitudeY).HasColumnName("Latitude_Y");
            entity.Property(e => e.LongitudeX).HasColumnName("Longitude_X");
            entity.Property(e => e.Operator).HasMaxLength(150);
            entity.Property(e => e.Owner).HasMaxLength(150);
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.UniqueRecordId)
                .HasMaxLength(61)
                .HasColumnName("UniqueRecordID");
        });

        modelBuilder.Entity<VwLgacopyCasimoFfpresultsSectionResponsesComboMethod>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLGAcopy_CASIMO_FFPresults_SectionResponses_ComboMethod");

            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.CasimoFacilityId).HasColumnName("CASIMO_FacilityID");
            entity.Property(e => e.CasimoFfplogId).HasColumnName("CASIMO_FFPlogID");
            entity.Property(e => e.CasimoLgaId)
                .HasMaxLength(4)
                .HasColumnName("CASIMO_LGA_ID");
            entity.Property(e => e.CasimoLgaName)
                .HasMaxLength(60)
                .HasColumnName("CASIMO_LGA_name");
            entity.Property(e => e.CategoryRating)
                .HasMaxLength(60)
                .HasColumnName("Category_Rating");
            entity.Property(e => e.CategoryRating2)
                .HasMaxLength(60)
                .HasColumnName("Category_Rating2");
            entity.Property(e => e.CategoryScore)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("Category_Score");
            entity.Property(e => e.CategoryScore2)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("Category_Score2");
            entity.Property(e => e.CouncilAssetRef)
                .HasMaxLength(20)
                .HasColumnName("Council_asset_ref");
            entity.Property(e => e.CustomGroups)
                .IsUnicode(false)
                .HasColumnName("Custom_groups");
            entity.Property(e => e.FacilityNameComponent)
                .HasMaxLength(150)
                .HasColumnName("Facility_name_(component)");
            entity.Property(e => e.FacilityNameFull)
                .HasMaxLength(303)
                .HasColumnName("Facility_name_full");
            entity.Property(e => e.FacilityNameSite)
                .HasMaxLength(150)
                .HasColumnName("Facility_name_(site)");
            entity.Property(e => e.FfpAssessedUse)
                .HasMaxLength(100)
                .HasColumnName("FFP_Assessed_Use");
            entity.Property(e => e.FfpCategory)
                .HasMaxLength(182)
                .HasColumnName("FFP_Category");
            entity.Property(e => e.FfpCategorySummary).HasColumnName("FFP_Category_Summary");
            entity.Property(e => e.FfpTemplate)
                .HasMaxLength(100)
                .HasColumnName("FFP_Template");
            entity.Property(e => e.LatitudeY).HasColumnName("Latitude_Y");
            entity.Property(e => e.LongitudeX).HasColumnName("Longitude_X");
            entity.Property(e => e.Operator).HasMaxLength(150);
            entity.Property(e => e.Owner).HasMaxLength(150);
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.UniqueRecordId)
                .HasMaxLength(61)
                .HasColumnName("UniqueRecordID");
        });

        modelBuilder.Entity<VwLgacopyCasimoQuantityAsstAggregatedArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLGAcopy_CASIMO_QuantityAsst_AggregatedAreas");

            entity.Property(e => e.AgeCohort)
                .HasMaxLength(20)
                .HasColumnName("Age_Cohort");
            entity.Property(e => e.CasimoLgaId)
                .HasMaxLength(4)
                .HasColumnName("CASIMO_LGA_ID");
            entity.Property(e => e.CasimoLgaName)
                .HasMaxLength(60)
                .HasColumnName("CASIMO_LGA_name");
            entity.Property(e => e.CasimoUserName)
                .HasMaxLength(511)
                .HasColumnName("CASIMO_user_name");
            entity.Property(e => e.CohortSize).HasColumnName("Cohort_Size");
            entity.Property(e => e.ComparisonArea)
                .HasMaxLength(150)
                .HasColumnName("Comparison_area");
            entity.Property(e => e.ComponentForecastAreas).HasColumnName("Component_Forecast_areas");
            entity.Property(e => e.CurrentRatio)
                .HasMaxLength(328)
                .HasColumnName("Current_Ratio");
            entity.Property(e => e.Difference).HasColumnName("Difference_#");
            entity.Property(e => e.ExistingQuantity).HasColumnName("Existing_Quantity");
            entity.Property(e => e.ForecastAreaId).HasColumnName("Forecast_Area_ID");
            entity.Property(e => e.QuantityStandard)
                .HasMaxLength(159)
                .HasColumnName("Quantity_Standard");
            entity.Property(e => e.TargetQuantity).HasColumnName("Target_Quantity");
            entity.Property(e => e.TargetRatio)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("Target_Ratio");
            entity.Property(e => e.UniqueRecordId)
                .HasMaxLength(92)
                .HasColumnName("UniqueRecordID");
        });

        modelBuilder.Entity<VwLgacopyCasimoQuantityAsstForecastArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLGAcopy_CASIMO_QuantityAsst_ForecastAreas");

            entity.Property(e => e.AgeCohort)
                .HasMaxLength(20)
                .HasColumnName("Age_Cohort");
            entity.Property(e => e.CasimoLgaId)
                .HasMaxLength(4)
                .HasColumnName("CASIMO_LGA_ID");
            entity.Property(e => e.CasimoLgaName)
                .HasMaxLength(60)
                .HasColumnName("CASIMO_LGA_name");
            entity.Property(e => e.CohortSize).HasColumnName("Cohort_Size");
            entity.Property(e => e.CurrentRatio)
                .HasMaxLength(323)
                .HasColumnName("Current_Ratio");
            entity.Property(e => e.Difference).HasColumnName("Difference_#");
            entity.Property(e => e.ExistingQuantity).HasColumnName("Existing_Quantity");
            entity.Property(e => e.ForecastArea)
                .HasMaxLength(120)
                .HasColumnName("Forecast_area");
            entity.Property(e => e.ForecastAreaId).HasColumnName("Forecast_Area_ID");
            entity.Property(e => e.QuantityStandard)
                .HasMaxLength(159)
                .HasColumnName("Quantity_Standard");
            entity.Property(e => e.SmallArea).HasColumnName("Small_Area");
            entity.Property(e => e.StateCode)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("State_Code");
            entity.Property(e => e.TargetQuantity).HasColumnName("Target_Quantity");
            entity.Property(e => e.TargetRatio)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("Target_Ratio");
            entity.Property(e => e.UniqueRecordId)
                .HasMaxLength(92)
                .HasColumnName("UniqueRecordID");
        });

        modelBuilder.Entity<VwLgacopyCasimoQuantityAsstStandard>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLGAcopy_CASIMO_QuantityAsst_Standards");

            entity.Property(e => e.CasimoLgaName)
                .HasMaxLength(60)
                .HasColumnName("CASIMO_LGA_name");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopulationStandard)
                .HasMaxLength(332)
                .HasColumnName("Population_Standard");
            entity.Property(e => e.StandardName)
                .HasMaxLength(100)
                .HasColumnName("Standard_name");
            entity.Property(e => e.UniqueRecordId).HasColumnName("UniqueRecordID");
            entity.Property(e => e.UnitType)
                .HasMaxLength(50)
                .HasColumnName("Unit_type");
        });

        modelBuilder.Entity<VwLgacopyCasimofacilitiesOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLGAcopy_CASIMOFacilities_OLD");

            entity.Property(e => e.ActiveFromYear).HasColumnName("Active_From_Year");
            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.AlternativeIdentifier)
                .HasMaxLength(30)
                .HasColumnName("Alternative_identifier");
            entity.Property(e => e.CasimoFacilityId).HasColumnName("CASIMO_FacilityID");
            entity.Property(e => e.CasimoLgaId)
                .HasMaxLength(4)
                .HasColumnName("CASIMO_LGA_ID");
            entity.Property(e => e.CasimoLgaName)
                .HasMaxLength(60)
                .HasColumnName("CASIMO_LGA_name");
            entity.Property(e => e.CouncilAssetRef)
                .HasMaxLength(20)
                .HasColumnName("Council_Asset_Ref");
            entity.Property(e => e.DateLastUpdated).HasColumnType("datetime");
            entity.Property(e => e.FacilityNameComponent)
                .HasMaxLength(150)
                .HasColumnName("Facility_Name_(component)");
            entity.Property(e => e.FacilityNameFull)
                .HasMaxLength(303)
                .HasColumnName("Facility_name_full");
            entity.Property(e => e.FacilityNameSite)
                .HasMaxLength(150)
                .HasColumnName("Facility_Name_(site)");
            entity.Property(e => e.FacilityNotes).HasColumnName("Facility_Notes");
            entity.Property(e => e.FacilityStatus)
                .HasMaxLength(25)
                .HasColumnName("Facility_Status");
            entity.Property(e => e.LatitudeY).HasColumnName("Latitude_Y");
            entity.Property(e => e.LongitudeX).HasColumnName("Longitude_X");
            entity.Property(e => e.Operator).HasMaxLength(150);
            entity.Property(e => e.Owner).HasMaxLength(150);
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.UniqueRecordId).HasColumnName("UniqueRecordID");
        });

        modelBuilder.Entity<VwLgacopyCasimofacilitiesUse>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLGAcopy_CASIMOFacilitiesUses");

            entity.Property(e => e.AccessType)
                .HasMaxLength(25)
                .HasColumnName("Access_type");
            entity.Property(e => e.ActiveFromYear).HasColumnName("Active_From_Year");
            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.AlternativeIdentifier)
                .HasMaxLength(30)
                .HasColumnName("Alternative_identifier");
            entity.Property(e => e.CasimoFacilityId).HasColumnName("CASIMO_FacilityID");
            entity.Property(e => e.CasimoLgaId)
                .HasMaxLength(4)
                .HasColumnName("CASIMO_LGA_ID");
            entity.Property(e => e.CasimoLgaName)
                .HasMaxLength(60)
                .HasColumnName("CASIMO_LGA_name");
            entity.Property(e => e.CasimoUseId).HasColumnName("CASIMO_Use_ID");
            entity.Property(e => e.CouncilAssetRef)
                .HasMaxLength(20)
                .HasColumnName("Council_Asset_Ref");
            entity.Property(e => e.CouncilContactPerson)
                .HasMaxLength(120)
                .HasColumnName("Council_Contact_Person");
            entity.Property(e => e.CustomGroups)
                .IsUnicode(false)
                .HasColumnName("Custom_groups");
            entity.Property(e => e.DateLastUpdated).HasColumnType("datetime");
            entity.Property(e => e.FacilityNameComponent)
                .HasMaxLength(150)
                .HasColumnName("Facility_Name_(component)");
            entity.Property(e => e.FacilityNameFull)
                .HasMaxLength(303)
                .HasColumnName("Facility_name_full");
            entity.Property(e => e.FacilityNameSite)
                .HasMaxLength(150)
                .HasColumnName("Facility_Name_(site)");
            entity.Property(e => e.FacilityNotes).HasColumnName("Facility_Notes");
            entity.Property(e => e.FacilityStatus)
                .HasMaxLength(25)
                .HasColumnName("Facility_Status");
            entity.Property(e => e.LatitudeY).HasColumnName("Latitude_Y");
            entity.Property(e => e.LongitudeX).HasColumnName("Longitude_X");
            entity.Property(e => e.Operator).HasMaxLength(150);
            entity.Property(e => e.Owner).HasMaxLength(150);
            entity.Property(e => e.RelatedUseNotes)
                .HasMaxLength(255)
                .HasColumnName("Related_Use_Notes");
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.UniqueRecordId)
                .HasMaxLength(61)
                .HasColumnName("UniqueRecordID");
            entity.Property(e => e.Use).HasMaxLength(100);
            entity.Property(e => e.UseHierarchyAttribute)
                .HasMaxLength(409)
                .HasColumnName("Use_Hierarchy_Attribute");
        });

        modelBuilder.Entity<VwLgacopyCasimofacilitiesUsesQuantity>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLGAcopy_CASIMOFacilitiesUsesQuantities");

            entity.Property(e => e.AccessType)
                .HasMaxLength(25)
                .HasColumnName("Access_type");
            entity.Property(e => e.ActiveFromYear).HasColumnName("Active_From_Year");
            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.AlternativeIdentifier)
                .HasMaxLength(30)
                .HasColumnName("Alternative_identifier");
            entity.Property(e => e.CasimoFacilityId).HasColumnName("CASIMO_FacilityID");
            entity.Property(e => e.CasimoLgaId)
                .HasMaxLength(4)
                .HasColumnName("CASIMO_LGA_ID");
            entity.Property(e => e.CasimoLgaName)
                .HasMaxLength(60)
                .HasColumnName("CASIMO_LGA_name");
            entity.Property(e => e.CasimoUnitTypeId).HasColumnName("CASIMO_Unit_type_ID");
            entity.Property(e => e.CasimoUseId).HasColumnName("CASIMO_Use_ID");
            entity.Property(e => e.CouncilAssetRef)
                .HasMaxLength(20)
                .HasColumnName("Council_Asset_Ref");
            entity.Property(e => e.CouncilContactPerson)
                .HasMaxLength(120)
                .HasColumnName("Council_Contact_Person");
            entity.Property(e => e.CustomGroups)
                .IsUnicode(false)
                .HasColumnName("Custom_groups");
            entity.Property(e => e.DateLastUpdated).HasColumnType("datetime");
            entity.Property(e => e.FacilityNameComponent)
                .HasMaxLength(150)
                .HasColumnName("Facility_Name_(component)");
            entity.Property(e => e.FacilityNameFull)
                .HasMaxLength(303)
                .HasColumnName("Facility_name_full");
            entity.Property(e => e.FacilityNameSite)
                .HasMaxLength(150)
                .HasColumnName("Facility_Name_(site)");
            entity.Property(e => e.FacilityNotes).HasColumnName("Facility_Notes");
            entity.Property(e => e.FacilityStatus)
                .HasMaxLength(25)
                .HasColumnName("Facility_Status");
            entity.Property(e => e.LatitudeY).HasColumnName("Latitude_Y");
            entity.Property(e => e.LongitudeX).HasColumnName("Longitude_X");
            entity.Property(e => e.Operator).HasMaxLength(150);
            entity.Property(e => e.Owner).HasMaxLength(150);
            entity.Property(e => e.Quantity).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.RelatedUseNotes)
                .HasMaxLength(255)
                .HasColumnName("Related_Use_Notes");
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.UniqueRecordId)
                .HasMaxLength(61)
                .HasColumnName("UniqueRecordID");
            entity.Property(e => e.UnitType)
                .HasMaxLength(50)
                .HasColumnName("Unit_Type");
            entity.Property(e => e.Use).HasMaxLength(100);
            entity.Property(e => e.UseHierarchyAttribute)
                .HasMaxLength(409)
                .HasColumnName("Use_Hierarchy_Attribute");
        });

        modelBuilder.Entity<VwLgacopyCasimofacility>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLGAcopy_CASIMOFacilities");

            entity.Property(e => e.ActiveFromYear).HasColumnName("Active_From_Year");
            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.AlternativeIdentifier)
                .HasMaxLength(30)
                .HasColumnName("Alternative_identifier");
            entity.Property(e => e.CasimoFacilityId).HasColumnName("CASIMO_FacilityID");
            entity.Property(e => e.CasimoLgaId)
                .HasMaxLength(4)
                .HasColumnName("CASIMO_LGA_ID");
            entity.Property(e => e.CasimoLgaName)
                .HasMaxLength(60)
                .HasColumnName("CASIMO_LGA_name");
            entity.Property(e => e.CouncilAssetRef)
                .HasMaxLength(20)
                .HasColumnName("Council_Asset_Ref");
            entity.Property(e => e.DateLastUpdated).HasColumnType("datetime");
            entity.Property(e => e.FacilityNameComponent)
                .HasMaxLength(150)
                .HasColumnName("Facility_Name_(component)");
            entity.Property(e => e.FacilityNameFull)
                .HasMaxLength(303)
                .HasColumnName("Facility_name_full");
            entity.Property(e => e.FacilityNameSite)
                .HasMaxLength(150)
                .HasColumnName("Facility_Name_(site)");
            entity.Property(e => e.FacilityNotes).HasColumnName("Facility_Notes");
            entity.Property(e => e.FacilityStatus)
                .HasMaxLength(25)
                .HasColumnName("Facility_Status");
            entity.Property(e => e.LatitudeY).HasColumnName("Latitude_Y");
            entity.Property(e => e.LongitudeX).HasColumnName("Longitude_X");
            entity.Property(e => e.Operator).HasMaxLength(150);
            entity.Property(e => e.Owner).HasMaxLength(150);
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.UniqueRecordId).HasColumnName("UniqueRecordID");
        });

        modelBuilder.Entity<VwPlanYearsDistinct>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPlanYearsDistinct");
        });

        modelBuilder.Entity<VwPopulationByAggregatedArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("vwPopulationByAggregatedArea");

            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
        });

        modelBuilder.Entity<VwPopulationByAggregatedAreaForAppend>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPopulationByAggregatedAreaForAppend");

            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
        });

        modelBuilder.Entity<VwPopulationByAggregatedForecastArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("vwPopulationByAggregatedForecastArea");

            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.ForecastArea).HasMaxLength(255);
        });

        modelBuilder.Entity<VwPopulationByAggregatedForecastAreaForAppend>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPopulationByAggregatedForecastAreaForAppend");

            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.ForecastArea).HasMaxLength(255);
        });

        modelBuilder.Entity<VwPopulationForecastByAgeAndYear>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPopulationForecastByAgeAndYear");

            entity.Property(e => e.AgeGroup).HasColumnName("Age group");
            entity.Property(e => e.Area).HasMaxLength(255);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Gender).HasMaxLength(255);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
        });

        modelBuilder.Entity<VwPopulationForecastByCohortAndYearCreateTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPopulationForecastByCohortAndYear_CreateTbl");

            entity.Property(e => e.Area).HasMaxLength(255);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Gender).HasMaxLength(255);
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
        });

        modelBuilder.Entity<VwPopulationRecordsByAggregatedArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("vwPopulationRecordsByAggregatedArea");

            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.Area).HasMaxLength(255);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
        });

        modelBuilder.Entity<VwPopulationRecordsByAggregatedAreaForAppend>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPopulationRecordsByAggregatedAreaForAppend");

            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.Area).HasMaxLength(255);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
        });

        modelBuilder.Entity<VwPopulationRecordsByForecastArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPopulationRecordsByForecastArea");

            entity.Property(e => e.Area).HasMaxLength(255);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
        });

        modelBuilder.Entity<VwPopulationSumByAggregatedArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("vwPopulationSumByAggregatedArea");

            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwPopulationSumByAggregatedAreaForAppend>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPopulationSumByAggregatedAreaForAppend");

            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwPopulationSumByForecastArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("vwPopulationSumByForecastArea");

            entity.Property(e => e.Area).HasMaxLength(255);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
        });

        modelBuilder.Entity<VwPopulationSumByForecastAreaForAppend>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPopulationSumByForecastAreaForAppend");

            entity.Property(e => e.Area).HasMaxLength(255);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
        });

        modelBuilder.Entity<VwPublicUnitsByAggregatedArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPublicUnitsByAggregatedArea");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.SumQuantity).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwPublicUnitsByForecastArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPublicUnitsByForecastArea");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.Attribute1Id).HasColumnName("Attribute1ID");
            entity.Property(e => e.Attribute2Id).HasColumnName("Attribute2ID");
            entity.Property(e => e.HierarchyLevelId).HasColumnName("HierarchyLevelID");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwPublicUnitsByForecastArea1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPublicUnitsByForecastArea1");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.Attribute1Id).HasColumnName("Attribute1ID");
            entity.Property(e => e.Attribute2Id).HasColumnName("Attribute2ID");
            entity.Property(e => e.HierarchyLevelId).HasColumnName("HierarchyLevelID");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwPublicUnitsRecordsByAggregatedArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPublicUnitsRecordsByAggregatedArea");

            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.Attribute1Id).HasColumnName("Attribute1ID");
            entity.Property(e => e.Attribute2Id).HasColumnName("Attribute2ID");
            entity.Property(e => e.HierarchyLevelId).HasColumnName("HierarchyLevelID");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.SumQuantity).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
            entity.Property(e => e.UserLgaid)
                .HasMaxLength(4)
                .HasColumnName("UserLGAid");
        });

        modelBuilder.Entity<VwPublicUnitsRecordsByForecastArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPublicUnitsRecordsByForecastArea");

            entity.Property(e => e.AccessTypeId).HasColumnName("AccessTypeID");
            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.Attribute1Id).HasColumnName("Attribute1ID");
            entity.Property(e => e.Attribute2Id).HasColumnName("Attribute2ID");
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.ForecastAreaLgaid)
                .HasMaxLength(4)
                .HasColumnName("ForecastAreaLGAID");
            entity.Property(e => e.HierarchyLevelId).HasColumnName("HierarchyLevelID");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwPublicUnitsSumByAggregatedArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPublicUnitsSumByAggregatedArea");

            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwPublicUnitsSumByForecastArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPublicUnitsSumByForecastArea");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwPublicUnitsSumByForecastArea1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPublicUnitsSumByForecastArea1");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.Attribute1Id).HasColumnName("Attribute1ID");
            entity.Property(e => e.Attribute2Id).HasColumnName("Attribute2ID");
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.HierarchyLevelId).HasColumnName("HierarchyLevelID");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwPublicUnitsSumByForecastAreaBkup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPublicUnitsSumByForecastArea_BKUP");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.Attribute1Id).HasColumnName("Attribute1ID");
            entity.Property(e => e.Attribute2Id).HasColumnName("Attribute2ID");
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.HierarchyLevelId).HasColumnName("HierarchyLevelID");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwPublicUnitsSumByForecastAreaBkup05012023>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPublicUnitsSumByForecastArea_BKUP_05012023");

            entity.Property(e => e.Area).HasMaxLength(120);
            entity.Property(e => e.BoundaryId).HasColumnName("BoundaryID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PublicUnits).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwQtyAssessmentStdWithId>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwQtyAssessmentStdWithIDs");

            entity.Property(e => e.AddedBy).HasMaxLength(100);
            entity.Property(e => e.AddedTime).HasColumnType("datetime");
            entity.Property(e => e.Attribute1Id).HasColumnName("Attribute1ID");
            entity.Property(e => e.Attribute2Id).HasColumnName("Attribute2ID");
            entity.Property(e => e.AttributeName1Id).HasColumnName("AttributeName1ID");
            entity.Property(e => e.AttributeName2Id).HasColumnName("AttributeName2ID");
            entity.Property(e => e.ChangedBy).HasMaxLength(100);
            entity.Property(e => e.ChangedTime).HasColumnType("datetime");
            entity.Property(e => e.HierarchyLevelId).HasColumnName("HierarchyLevelID");
            entity.Property(e => e.HierarchyNameId).HasColumnName("HierarchyNameID");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.LockedBy).HasMaxLength(100);
            entity.Property(e => e.LockedTime).HasColumnType("datetime");
            entity.Property(e => e.PreferredCohortId).HasColumnName("PreferredCohortID");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.StdName).HasMaxLength(100);
            entity.Property(e => e.TargetPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TargetUnits).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TriggerPop).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwQtyAssessmentStdsId>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwQtyAssessmentStds_IDs");

            entity.Property(e => e.Attribut2).HasMaxLength(100);
            entity.Property(e => e.Attribute1).HasMaxLength(100);
            entity.Property(e => e.Attribute1Id).HasColumnName("Attribute1ID");
            entity.Property(e => e.Attribute2Id).HasColumnName("Attribute2ID");
            entity.Property(e => e.HierarchyLevel).HasMaxLength(100);
            entity.Property(e => e.HierarchyLevelId).HasColumnName("HierarchyLevelID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InfTypeHierarchyAttributes)
                .HasMaxLength(409)
                .HasColumnName("InfType_Hierarchy_Attributes");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.Type).HasMaxLength(100);
        });

        modelBuilder.Entity<VwQtyAssessmentStdsIdsConcatenated>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwQtyAssessmentStds_IDs_Concatenated");

            entity.Property(e => e.QtyAssessmentStdId).HasColumnName("QtyAssessmentStdID");
            entity.Property(e => e.UsesConcatenated)
                .IsUnicode(false)
                .HasColumnName("Uses_Concatenated");
        });

        modelBuilder.Entity<VwQtyStandard>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwQtyStandard");

            entity.Property(e => e.DefaultCohortId).HasColumnName("DefaultCohortID");
            entity.Property(e => e.FacilityLgaid)
                .HasMaxLength(4)
                .HasColumnName("FacilityLGAid");
            entity.Property(e => e.InfType).HasMaxLength(100);
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.PopRatioStdId).HasColumnName("PopRatioStdID");
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");
        });

        modelBuilder.Entity<VwResPopSingleYrsByComparisonArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwResPop_SingleYrs_ByComparisonArea");

            entity.Property(e => e.AgeGroup).HasColumnName("Age group");
            entity.Property(e => e.CasimoUserId).HasColumnName("CASIMO user ID");
            entity.Property(e => e.CasimoUserName)
                .HasMaxLength(50)
                .HasColumnName("CASIMO user name");
            entity.Property(e => e.CombinedAreaId).HasColumnName("Combined area ID");
            entity.Property(e => e.CombinedAreaName)
                .HasMaxLength(120)
                .HasColumnName("Combined area name");
            entity.Property(e => e.Gender).HasMaxLength(255);
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
        });

        modelBuilder.Entity<VwResidentPopulationByAggregatedArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwResidentPopulationByAggregatedArea");

            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
        });

        modelBuilder.Entity<VwResidentPopulationByAggregatedAreaCreateTbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwResidentPopulationByAggregatedArea_CreateTbl");

            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
        });

        modelBuilder.Entity<VwResidentPopulationByAggregatedForecastArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwResidentPopulationByAggregatedForecastArea");

            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.ForecastArea).HasMaxLength(255);
        });

        modelBuilder.Entity<VwResidentPopulationByForecastArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwResidentPopulationByForecastArea");

            entity.Property(e => e.Area).HasMaxLength(255);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
        });

        modelBuilder.Entity<VwResidentTotalPopulationByAggregatedArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwResidentTotalPopulationByAggregatedArea");

            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
        });

        modelBuilder.Entity<VwResidentTotalPopulationByAggregatedForecastArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwResidentTotalPopulationByAggregatedForecastArea");

            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.ForecastArea).HasMaxLength(255);
        });

        modelBuilder.Entity<VwResidentTotalPopulationByForecastArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwResidentTotalPopulationByForecastArea");

            entity.Property(e => e.Area).HasMaxLength(255);
            entity.Property(e => e.CohortId).HasColumnName("CohortID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
        });

        modelBuilder.Entity<VwServicesByLgaid>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwServicesByLGAid");

            entity.Property(e => e.AccessTypeId).HasColumnName("AccessTypeID");
            entity.Property(e => e.AddedBy).HasMaxLength(100);
            entity.Property(e => e.AddedTime).HasColumnType("datetime");
            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.Attribute1Id).HasColumnName("Attribute1ID");
            entity.Property(e => e.Attribute2Id).HasColumnName("Attribute2ID");
            entity.Property(e => e.ChangedBy).HasMaxLength(100);
            entity.Property(e => e.ChangedTime).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.FacilityComponent).HasMaxLength(150);
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilitySite).HasMaxLength(150);
            entity.Property(e => e.HierarchyLevelId).HasColumnName("HierarchyLevelID");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.LockedBy).HasMaxLength(100);
            entity.Property(e => e.LockedTime).HasColumnType("datetime");
            entity.Property(e => e.Operator).HasMaxLength(150);
            entity.Property(e => e.Owner).HasMaxLength(150);
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            entity.Property(e => e.ServiceOwner).HasMaxLength(120);
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.TempId).HasColumnName("TempID");
            entity.Property(e => e.Ts)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("ts");
            entity.Property(e => e.UserInterestId).HasColumnName("UserInterestID");
            entity.Property(e => e.XLongitude).HasColumnName("X_longitude");
            entity.Property(e => e.YLatitude).HasColumnName("Y_latitude");
        });

        modelBuilder.Entity<VwSingleAssetsByFaciity>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSingleAssetsByFaciity");

            entity.Property(e => e.Additionalident).HasMaxLength(30);
            entity.Property(e => e.AssetRef).HasMaxLength(20);
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
        });

        modelBuilder.Entity<VwSubFrmService>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSubFrmServices");

            entity.Property(e => e.AccessType).HasMaxLength(25);
            entity.Property(e => e.Attribute1).HasMaxLength(100);
            entity.Property(e => e.Attribute2).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.HierarchyLevel).HasMaxLength(100);
            entity.Property(e => e.InfTypeHierarchyAttributes)
                .HasMaxLength(409)
                .HasColumnName("InfType_Hierarchy_Attributes");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.LocalName).HasMaxLength(100);
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            entity.Property(e => e.ServiceOwner).HasMaxLength(120);
            entity.Property(e => e.Type).HasMaxLength(100);
        });

        modelBuilder.Entity<VwTestAggrByUserLive>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("_vwTEST_AggrByUser_LIVE");

            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.AggrBoundaryName).HasMaxLength(120);
            entity.Property(e => e.Cohort).HasMaxLength(20);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserLgaid)
                .HasMaxLength(4)
                .HasColumnName("UserLGAid");
        });

        modelBuilder.Entity<VwTestrc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("_vwTESTRC");

            entity.Property(e => e.ActiveFromYear).HasColumnName("Active_From_Year");
            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.AlternativeIdentifier)
                .HasMaxLength(30)
                .HasColumnName("Alternative_identifier");
            entity.Property(e => e.CasimoFacilityId).HasColumnName("CASIMO_FacilityID");
            entity.Property(e => e.CasimoLgaId)
                .HasMaxLength(4)
                .HasColumnName("CASIMO_LGA_ID");
            entity.Property(e => e.CasimoLgaName)
                .HasMaxLength(60)
                .HasColumnName("CASIMO_LGA_name");
            entity.Property(e => e.CouncilAssetRef)
                .HasMaxLength(20)
                .HasColumnName("Council_Asset_Ref");
            entity.Property(e => e.DateLastUpdated).HasColumnType("datetime");
            entity.Property(e => e.FacilityNameComponent)
                .HasMaxLength(150)
                .HasColumnName("Facility_Name_(component)");
            entity.Property(e => e.FacilityNameFull)
                .HasMaxLength(303)
                .HasColumnName("Facility_name_full");
            entity.Property(e => e.FacilityNameSite)
                .HasMaxLength(150)
                .HasColumnName("Facility_Name_(site)");
            entity.Property(e => e.FacilityNotes).HasColumnName("Facility_Notes");
            entity.Property(e => e.FacilityStatus)
                .HasMaxLength(25)
                .HasColumnName("Facility_Status");
            entity.Property(e => e.LatitudeY).HasColumnName("Latitude_Y");
            entity.Property(e => e.LongitudeX).HasColumnName("Longitude_X");
            entity.Property(e => e.Operator).HasMaxLength(150);
            entity.Property(e => e.Owner).HasMaxLength(150);
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.UniqueRecordId).HasColumnName("UniqueRecordID");
        });

        modelBuilder.Entity<VwUtilExportAvailableTargetHoursBySpace>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwUtilExport_AvailableTargetHoursBySpace");

            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.FacilityComponent).HasMaxLength(150);
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilitySite).HasMaxLength(150);
            entity.Property(e => e.FriTotalHours)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("Fri_TotalHours");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.MonTotalHours)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("Mon_TotalHours");
            entity.Property(e => e.SatTotalHours)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("Sat_TotalHours");
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.SpaceName).HasMaxLength(255);
            entity.Property(e => e.SunTotalHours)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("Sun_TotalHours");
            entity.Property(e => e.ThuTotalHours)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("Thu_TotalHours");
            entity.Property(e => e.TueTotalHours)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("Tue_TotalHours");
            entity.Property(e => e.WedTotalHours)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("Wed_TotalHours");
        });

        modelBuilder.Entity<VwUtilExportBookingDataBySpace>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwUtilExport_BookingDataBySpace");

            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.BookingCategory).HasMaxLength(50);
            entity.Property(e => e.BookingDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Booking_date");
            entity.Property(e => e.BookingDescription).HasMaxLength(255);
            entity.Property(e => e.EndTime)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("End_time");
            entity.Property(e => e.FacilityComponent).HasMaxLength(150);
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilitySite).HasMaxLength(150);
            entity.Property(e => e.HirerCategory).HasMaxLength(100);
            entity.Property(e => e.HirerRef).HasMaxLength(100);
            entity.Property(e => e.LgabookingRef)
                .HasMaxLength(50)
                .HasColumnName("LGAbookingRef");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.SpaceName).HasMaxLength(255);
            entity.Property(e => e.StartTime)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Start_time");
        });

        modelBuilder.Entity<VwUtilExportResultsBookingProfileBySpaceByTime>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwUtil_ExportResults_BookingProfileBySpaceByTime");

            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.AssessedUse)
                .HasMaxLength(100)
                .HasColumnName("Assessed_Use");
            entity.Property(e => e.AssessmentPeriod)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("Assessment_period");
            entity.Property(e => e.AssessmentPeriodEnd)
                .HasColumnType("datetime")
                .HasColumnName("Assessment_period_end");
            entity.Property(e => e.AssessmentPeriodStart)
                .HasColumnType("datetime")
                .HasColumnName("Assessment_period_start");
            entity.Property(e => e.CasimoId).HasColumnName("CASIMO_ID");
            entity.Property(e => e.Day).HasMaxLength(25);
            entity.Property(e => e.FacilityNameFull)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Facility_name_full");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("LGAid");
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.SpaceNameFull)
                .HasMaxLength(513)
                .HasColumnName("Space_name_full");
            entity.Property(e => e.SubSpace)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Sub_space");
            entity.Property(e => e.Time).HasMaxLength(10);
        });

        modelBuilder.Entity<VwUtilExportResultsPercentHourlyBooking>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwUtil_ExportResults_PercentHourlyBooking");

            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.AssessedUse)
                .HasMaxLength(100)
                .HasColumnName("Assessed_Use");
            entity.Property(e => e.AssessmentPeriod)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("Assessment_period");
            entity.Property(e => e.CapacityTemplateId).HasColumnName("CapacityTemplateID");
            entity.Property(e => e.CasimoFacilityId).HasColumnName("CASIMO_FacilityID");
            entity.Property(e => e.CoreHoursUtil)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Core_hours_util");
            entity.Property(e => e.CoreHoursUtilPercent)
                .HasMaxLength(21)
                .HasColumnName("Core_hours_util_percent");
            entity.Property(e => e.DaytimeHoursUtil)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Daytime_hours_util");
            entity.Property(e => e.DaytimeHoursUtilPercent)
                .HasMaxLength(21)
                .HasColumnName("Daytime_hours_util_percent");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("End_date");
            entity.Property(e => e.EveningHoursUtil)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Evening_hours_util");
            entity.Property(e => e.EveningHoursUtilPercent)
                .HasMaxLength(21)
                .HasColumnName("Evening_hours_util_percent");
            entity.Property(e => e.FacilityNameFull)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Facility_name_full");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.NormalHoursUtil)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Normal_hours_util");
            entity.Property(e => e.NormalHoursUtilPercent)
                .HasMaxLength(21)
                .HasColumnName("Normal_hours_util_percent");
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.SpaceNameFull)
                .HasMaxLength(513)
                .HasColumnName("Space_name_full");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("Start_date");
            entity.Property(e => e.SubSpace)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Sub_space");
            entity.Property(e => e.SubSpaceId).HasColumnName("SubSpaceID");
            entity.Property(e => e.UtilLogId).HasColumnName("UtilLogID");
            entity.Property(e => e.UtilTemplateId).HasColumnName("UtilTemplateID");
            entity.Property(e => e.Weekday).HasMaxLength(20);
        });

        modelBuilder.Entity<VwUtilExportResultsUniqueBookingId>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwUtil_ExportResults_UniqueBookingIDs");

            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.SubSpaceId).HasColumnName("SubSpaceID");
        });

        modelBuilder.Entity<VwUtilFrmUtilTableView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwUtil_frmUtil_TableView");

            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.AssessedUse)
                .HasMaxLength(100)
                .HasColumnName("Assessed_Use");
            entity.Property(e => e.AssessmentPeriod)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("Assessment_period");
            entity.Property(e => e.CapacityTemplateId).HasColumnName("CapacityTemplateID");
            entity.Property(e => e.CasimoFacilityId).HasColumnName("CASIMO_FacilityID");
            entity.Property(e => e.CoreHoursUtil)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Core_hours_util");
            entity.Property(e => e.CoreHoursUtilPercent)
                .HasMaxLength(21)
                .HasColumnName("Core_hours_util_percent");
            entity.Property(e => e.CustomUseGroups).IsUnicode(false);
            entity.Property(e => e.DaytimeHoursUtil)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Daytime_hours_util");
            entity.Property(e => e.DaytimeHoursUtilPercent)
                .HasMaxLength(21)
                .HasColumnName("Daytime_hours_util_percent");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("End_date");
            entity.Property(e => e.EveningHoursUtil)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Evening_hours_util");
            entity.Property(e => e.EveningHoursUtilPercent)
                .HasMaxLength(21)
                .HasColumnName("Evening_hours_util_percent");
            entity.Property(e => e.FacilityNameFull)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Facility_name_full");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.NormalHoursUtil)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Normal_hours_util");
            entity.Property(e => e.NormalHoursUtilPercent)
                .HasMaxLength(21)
                .HasColumnName("Normal_hours_util_percent");
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.SpaceNameFull)
                .HasMaxLength(559)
                .HasColumnName("Space_name_full");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("Start_date");
            entity.Property(e => e.SubSpace)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Sub_space");
            entity.Property(e => e.SubSpaceId).HasColumnName("SubSpaceID");
            entity.Property(e => e.UtilLogId).HasColumnName("UtilLogID");
            entity.Property(e => e.UtilTemplateId).HasColumnName("UtilTemplateID");
            entity.Property(e => e.Weekday).HasMaxLength(20);
        });

        modelBuilder.Entity<VwWorkerPopulationByAggregeatedArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWorkerPopulationByAggregeatedArea");

            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
        });

        modelBuilder.Entity<VwWorkerPopulationByAggregeatedForecastArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWorkerPopulationByAggregeatedForecastArea");

            entity.Property(e => e.AggrBoundaryId).HasColumnName("AggrBoundaryID");
            entity.Property(e => e.ForecastArea).HasMaxLength(100);
        });

        modelBuilder.Entity<VwWorkerPopulationByForecastArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwWorkerPopulationByForecastArea");

            entity.Property(e => e.Area).HasMaxLength(100);
            entity.Property(e => e.ForecastAreaBoundaryId).HasColumnName("ForecastAreaBoundaryID");
        });

        modelBuilder.Entity<VwfrmFacilityReg>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwfrmFacilityReg");

            entity.Property(e => e.AccessTypeId).HasColumnName("AccessTypeID");
            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.CoordsCorrectLga).HasColumnName("CoordsCorrectLGA");
            entity.Property(e => e.CreatorUserId).HasColumnName("CreatorUserID");
            entity.Property(e => e.CustomUseGroupId).HasColumnName("CustomUseGroupID");
            entity.Property(e => e.CustomUseGroupName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.FacilityComponent).HasMaxLength(150);
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilitySite).HasMaxLength(150);
            entity.Property(e => e.InfType).HasMaxLength(100);
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.Operator).HasMaxLength(150);
            entity.Property(e => e.Owner).HasMaxLength(150);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.Quantity).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            entity.Property(e => e.ServiceOwner).HasMaxLength(120);
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.UserInterestId).HasColumnName("UserInterestID");
            entity.Property(e => e.XLongitude).HasColumnName("X_longitude");
            entity.Property(e => e.YLatitude).HasColumnName("Y_latitude");
        });

        modelBuilder.Entity<VwxlsFacilitiesAndRelatedUse>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwxlsFacilitiesAndRelatedUses");

            entity.Property(e => e.AccessType).HasMaxLength(25);
            entity.Property(e => e.Additionalident).HasMaxLength(30);
            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.AssetRef).HasMaxLength(20);
            entity.Property(e => e.Attribute1).HasMaxLength(100);
            entity.Property(e => e.Attribute2).HasMaxLength(100);
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.FacilityComponent).HasMaxLength(150);
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilitySite).HasMaxLength(150);
            entity.Property(e => e.FacilityStatus).HasMaxLength(25);
            entity.Property(e => e.HierarchyLevel).HasMaxLength(100);
            entity.Property(e => e.InfTypeHierarchyAttributes)
                .HasMaxLength(409)
                .HasColumnName("InfType_Hierarchy_Attributes");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.Lganame)
                .HasMaxLength(60)
                .HasColumnName("LGAname");
            entity.Property(e => e.Operator).HasMaxLength(150);
            entity.Property(e => e.Owner).HasMaxLength(150);
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.Type).HasMaxLength(100);
            entity.Property(e => e.XLongitude).HasColumnName("X_longitude");
            entity.Property(e => e.YLatitude).HasColumnName("Y_latitude");
        });

        modelBuilder.Entity<VwxlsFacilitiesRelatedUsesAndQuantity>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwxlsFacilitiesRelatedUsesAndQuantities");

            entity.Property(e => e.AccessType).HasMaxLength(25);
            entity.Property(e => e.Additionalident).HasMaxLength(30);
            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.AssetRef).HasMaxLength(20);
            entity.Property(e => e.Attribute1).HasMaxLength(100);
            entity.Property(e => e.Attribute2).HasMaxLength(100);
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.FacilityComponent).HasMaxLength(150);
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilitySite).HasMaxLength(150);
            entity.Property(e => e.FacilityStatus).HasMaxLength(25);
            entity.Property(e => e.HierarchyLevel).HasMaxLength(100);
            entity.Property(e => e.InfTypeHierarchyAttributes)
                .HasMaxLength(409)
                .HasColumnName("InfType_Hierarchy_Attributes");
            entity.Property(e => e.InfTypeId).HasColumnName("InfTypeID");
            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.Lganame)
                .HasMaxLength(60)
                .HasColumnName("LGAname");
            entity.Property(e => e.Operator).HasMaxLength(150);
            entity.Property(e => e.Owner).HasMaxLength(150);
            entity.Property(e => e.Quantity).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            entity.Property(e => e.Settlement).HasMaxLength(100);
            entity.Property(e => e.Type).HasMaxLength(100);
            entity.Property(e => e.UnitType).HasMaxLength(50);
            entity.Property(e => e.XLongitude).HasColumnName("X_longitude");
            entity.Property(e => e.YLatitude).HasColumnName("Y_latitude");
        });

        modelBuilder.Entity<VwxlsPopulationStandard>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwxlsPopulationStandards");

            entity.Property(e => e.Lgaid)
                .HasMaxLength(4)
                .HasColumnName("LGAid");
            entity.Property(e => e.Lganame)
                .HasMaxLength(60)
                .HasColumnName("LGAname");
            entity.Property(e => e.PopulationStandard).HasMaxLength(332);
            entity.Property(e => e.Use).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
