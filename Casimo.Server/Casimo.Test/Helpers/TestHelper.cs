using Casimo.Data.CasimoDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;

namespace Casimo.Test.Helpers;

/// <summary>
/// Helper class for creating common test objects and mocks
/// </summary>
public static class TestHelper
{

    /// <summary>
    /// Public db context interface
    /// </summary>
    public static CasimoDbContext DbContext
    {
        get
        {
            CasimoDbContext casimoDbContext = new(new DbContextOptionsBuilder<CasimoDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options);
            return casimoDbContext;
        }
    }

    /// <summary>
    /// Creates a mock logger for testing
    /// </summary>
    /// <typeparam name="T">Type of the logger</typeparam>
    /// <returns>Mock logger</returns>
    public static ILogger<T> CreateMockLogger<T>()
    {
        Mock<ILogger<T>> mockLogger = new();
        return mockLogger.Object;
    }

    public static TblFacility CreateFacilities(CasimoDbContext dbContext, string facilityName, List<TblSubSpace>? tblSubSpaces = null, List<TblFfpasstLog>? logs = null)
    {
        TblFacility facilities =
                new()
                {
                    FacilitySite = facilityName,
                    Address = "123 Test Street",
                    Operator = "Test Operator",
                    Owner = "Test Owner",
                    Postcode = 1231,
                    Settlement = "Test City",
                    YLatitude = -33.8688,
                    XLongitude = 151.2093,
                    Lgaid = "AID"
                };
        dbContext.TblFacilities.Add(facilities);
        dbContext.SaveChanges();
        return facilities;
    }

    public static TblFfptemplateTitle CreateTemplate(CasimoDbContext context)
    {
        TblFfptemplateTitle tblFfptemplateTitle = new()
        {
            Lgaid = "AID",
            Description = "Test Template",
            Title = "Test Template Title"
        };
        context.TblFfptemplateTitles.Add(tblFfptemplateTitle);
        context.SaveChanges();

        return tblFfptemplateTitle;
    }

    public static void CreateLogStatus(CasimoDbContext context)
    {
        if (!context.TblAssessmentStatuses.Any())
        {
            List<TblAssessmentStatus> statuses =
            [
                new()
            {
                Id = 1,
                Name = "Draft"
            },
            new()
            {
                Id = 2,
                Name = "Final"
            },
            new()
            {
                Id = 3,
                Name = "Archived"
            }
            ];
            context.TblAssessmentStatuses.AddRange(statuses);
            context.SaveChanges();
        }
    }

    public static void CreateInfType(CasimoDbContext context)
    {
        if (!context.TblInfTypes.Any())
        {
            List<TblInfType> infTypes =
            [
                new()
            {
                InfTypeId = 1,
                Type = "Community Center"
            },
            new()
            {
                InfTypeId = 2,
                Type = "Library"
            }
            ];
            context.TblInfTypes.AddRange(infTypes);
            context.SaveChanges();
        }
    }

    /// <summary>
    /// Creates a new assessment log with a unique ID
    /// </summary>
    /// <param name="context">Database context</param>
    /// <param name="facilityId">ID of the facility</param>
    /// <param name="templateId">ID of the template</param>
    /// <param name="infTypeId">ID of the infrastructure type</param>
    /// <param name="assessmentPersons">Names of assessment persons</param>
    /// <param name="assessmentDate">Date of assessment (optional, defaults to current date)</param>
    /// <returns>The created assessment log with unique ID</returns>
    public static TblFfpasstLog CreateAssessmentLog(CasimoDbContext context, int facilityId, int infTypeId, string assessmentPersons = "Test Assessor", DateTime? assessmentDate = null)
    {
        TblFfptemplateTitle template = CreateTemplate(context);
        CreateLogStatus(context);
        CreateInfType(DbContext);
        TblFfpasstLog assessmentLog = new()
        {
            FacilityId = facilityId,
            TemplateId = template.Id,
            InfTypeId = context.TblInfTypes.First().InfTypeId,
            Template = template,
            AssessmentPersons = assessmentPersons,
            AssessmentDate = assessmentDate ?? DateTime.Now,
            StatusId = context.TblAssessmentStatuses.First().Id
        };

        context.TblFfpasstLogs.Add(assessmentLog);
        context.SaveChanges();

        return assessmentLog;
    }

    /// <summary>
    /// Creates multiple assessment logs with unique IDs
    /// </summary>
    /// <param name="context">Database context</param>
    /// <param name="count">Number of assessment logs to create</param>
    /// <param name="facilityId">ID of the facility (optional, defaults to 1)</param>
    /// <param name="templateId">ID of the template (optional, defaults to 1)</param>
    /// <param name="infTypeId">ID of the infrastructure type (optional, defaults to 1)</param>
    /// <returns>List of created assessment logs</returns>
    public static List<TblFfpasstLog> CreateMultipleAssessmentLogs(CasimoDbContext context, int count, int facilityId = 1, int infTypeId = 1)
    {
        List<TblFfpasstLog> assessmentLogs = [];

        for (int i = 0; i < count; i++)
        {
            TblFfpasstLog log = CreateAssessmentLog(
                context,
                facilityId,
                infTypeId,
                $"Test Assessor {i + 1}",
                DateTime.Now.AddDays(-i * 5) // Spread dates over time
            );
            assessmentLogs.Add(log);
        }

        return assessmentLogs;
    }

    /// <summary>
    /// Creates a new question response with a unique ID
    /// </summary>
    /// <param name="context">Database context</param>
    /// <param name="logId">ID of the assessment log</param>
    /// <param name="questionId">ID of the template question</param>
    /// <param name="responseText1">First text response (optional)</param>
    /// <param name="responseText2">Second text response (optional)</param>
    /// <param name="selection1Id">First selection ID (optional, defaults to 1)</param>
    /// <param name="selection2Id">Second selection ID (optional, defaults to 1)</param>
    /// <param name="qscore1">First numeric score (optional)</param>
    /// <param name="qscore2">Second numeric score (optional)</param>
    /// <returns>The created question response with unique ID</returns>
    public static TblFfpasstQuestionResponse CreateQuestionResponse(CasimoDbContext context, int logId, int questionId,
        string? responseText1 = null, string? responseText2 = null, int? selection1Id = 1, int? selection2Id = 1,
        int? qscore1 = null, int? qscore2 = null)
    {
        // Get the next available ID
        int nextId = context.TblFfpasstQuestionResponses.Any()
            ? context.TblFfpasstQuestionResponses.Max(x => x.Id) + 1
            : 1;

        TblFfpasstQuestionResponse questionResponse = new()
        {
            Id = nextId,
            LogId = logId,
            QuestionId = questionId,
            ResponseText1 = responseText1,
            ResponseText2 = responseText2,
            Selection1Id = selection1Id,
            Selection2Id = selection2Id,
            Qscore1 = qscore1,
            Qscore2 = qscore2
        };

        context.TblFfpasstQuestionResponses.Add(questionResponse);
        context.SaveChanges();

        return questionResponse;
    }

    /// <summary>
    /// Creates multiple question responses with unique IDs
    /// </summary>
    /// <param name="context">Database context</param>
    /// <param name="logId">ID of the assessment log</param>
    /// <param name="questionIds">List of question IDs to create responses for</param>
    /// <returns>List of created question responses</returns>
    public static List<TblFfpasstQuestionResponse> CreateMultipleQuestionResponses(CasimoDbContext context, int logId, List<int> questionIds)
    {
        List<TblFfpasstQuestionResponse> responses = [];

        for (int i = 0; i < questionIds.Count; i++)
        {
            TblFfpasstQuestionResponse response = CreateQuestionResponse(
                context,
                logId,
                questionIds[i],
                $"Response 1 for Question {questionIds[i]}",
                $"Response 2 for Question {questionIds[i]}",
                1, 1,
                i + 1, i + 2
            );
            responses.Add(response);
        }

        return responses;
    }

    /// <summary>
    /// Creates a new section response with a unique ID
    /// </summary>
    /// <param name="context">Database context</param>
    /// <param name="logId">ID of the assessment log</param>
    /// <param name="sectionId">ID of the template section</param>
    /// <param name="summary">Text summary of responses (optional)</param>
    /// <param name="sectionScore1">First numeric score (optional, defaults to 0)</param>
    /// <param name="sectionScore2">Second numeric score (optional, defaults to 0)</param>
    /// <returns>The created section response with unique ID</returns>
    public static TblFfpasstSectionResponse CreateSectionResponse(CasimoDbContext context, int logId, int sectionId,
        string? summary = null, decimal sectionScore1 = 0, decimal sectionScore2 = 0)
    {
        // Get the next available ID
        int nextId = context.TblFfpasstSectionResponses.Any()
            ? context.TblFfpasstSectionResponses.Max(x => x.Id) + 1
            : 1;

        TblFfpasstSectionResponse sectionResponse = new()
        {
            Id = nextId,
            LogId = logId,
            SectionId = sectionId,
            Summary = summary,
            SectionScore1 = sectionScore1,
            SectionScore2 = sectionScore2
        };

        context.TblFfpasstSectionResponses.Add(sectionResponse);
        context.SaveChanges();

        return sectionResponse;
    }

    /// <summary>
    /// Creates multiple section responses with unique IDs
    /// </summary>
    /// <param name="context">Database context</param>
    /// <param name="logId">ID of the assessment log</param>
    /// <param name="sectionIds">List of section IDs to create responses for</param>
    /// <returns>List of created section responses</returns>
    public static List<TblFfpasstSectionResponse> CreateMultipleSectionResponses(CasimoDbContext context, int logId, List<int> sectionIds)
    {
        List<TblFfpasstSectionResponse> responses = [];

        for (int i = 0; i < sectionIds.Count; i++)
        {
            TblFfpasstSectionResponse response = CreateSectionResponse(
                context,
                logId,
                sectionIds[i],
                $"Summary for Section {sectionIds[i]}",
                (i + 1) * 10.5m,
                (i + 1) * 15.2m
            );
            responses.Add(response);
        }

        return responses;
    }

    /// <summary>
    /// Creates a new selection with a unique ID
    /// </summary>
    /// <param name="context">Database context</param>
    /// <param name="templateId">ID of the template (optional)</param>
    /// <param name="schemeId">ID of the scheme</param>
    /// <param name="selectionText">Text for the selection option</param>
    /// <param name="selectionOrder">Order of the selection (optional, defaults to 1)</param>
    /// <param name="selectionPrompt">Prompt text (optional)</param>
    /// <param name="formatColour">Format colour (optional, defaults to 0)</param>
    /// <returns>The created selection with unique ID</returns>
    public static TblFfpasstSelection CreateSelection(CasimoDbContext context, int? templateId, int schemeId,
        string selectionText, int selectionOrder = 1, string? selectionPrompt = null, int formatColour = 0)
    {
        // Get the next available ID
        int nextId = context.TblFfpasstSelections.Any()
            ? context.TblFfpasstSelections.Max(x => x.Id) + 1
            : 1;

        TblFfpasstSelection selection = new()
        {
            Id = nextId,
            TemplateId = templateId,
            SchemeId = schemeId,
            SelectionText = selectionText,
            SelectionOrder = selectionOrder,
            SelectionPrompt = selectionPrompt ?? $"Prompt for {selectionText}",
            FormatColour = formatColour
        };

        context.TblFfpasstSelections.Add(selection);
        context.SaveChanges();

        return selection;
    }

    /// <summary>
    /// Creates multiple selections with unique IDs
    /// </summary>
    /// <param name="context">Database context</param>
    /// <param name="templateId">ID of the template (optional)</param>
    /// <param name="schemeId">ID of the scheme</param>
    /// <param name="selectionTexts">List of selection texts to create</param>
    /// <returns>List of created selections</returns>
    public static List<TblFfpasstSelection> CreateMultipleSelections(CasimoDbContext context, int? templateId, int schemeId, List<string> selectionTexts)
    {
        List<TblFfpasstSelection> selections = [];

        for (int i = 0; i < selectionTexts.Count; i++)
        {
            TblFfpasstSelection selection = CreateSelection(
                context,
                templateId,
                schemeId,
                selectionTexts[i],
                i + 1,
                $"Prompt for {selectionTexts[i]}",
                i % 3 // Cycle through colors 0, 1, 2
            );
            selections.Add(selection);
        }

        return selections;
    }

    /// <summary>
    /// Creates a complete assessment with all sub-objects
    /// </summary>
    /// <param name="context">Database context</param>
    /// <param name="facilityId">ID of the facility</param>
    /// <param name="templateId">ID of the template</param>
    /// <param name="infTypeId">ID of the infrastructure type</param>
    /// <param name="questionIds">List of question IDs for responses</param>
    /// <param name="sectionIds">List of section IDs for responses</param>
    /// <param name="selectionTexts">List of selection texts to create</param>
    /// <param name="assessmentPersons">Names of assessment persons</param>
    /// <param name="assessmentDate">Date of assessment (optional)</param>
    /// <returns>Complete assessment data with all sub-objects</returns>
    public static (TblFfpasstLog Log, List<TblFfpasstQuestionResponse> QuestionResponses, List<TblFfpasstSectionResponse> SectionResponses, List<TblFfpasstSelection> Selections) CreateCompleteAssessment(
        CasimoDbContext context, int facilityId, int infTypeId,
        List<int> questionIds, List<int> sectionIds, List<string> selectionTexts,
        string assessmentPersons = "Test Assessor", DateTime? assessmentDate = null)
    {
        // Create the main assessment log
        TblFfpasstLog log = CreateAssessmentLog(context, facilityId, infTypeId, assessmentPersons, assessmentDate);

        // Create selections first (they might be referenced by question responses)
        List<TblFfpasstSelection> selections = CreateMultipleSelections(context, log.TemplateId, 1, selectionTexts);

        // Create question responses
        List<TblFfpasstQuestionResponse> questionResponses = CreateMultipleQuestionResponses(context, log.Id, questionIds);

        // Create section responses
        List<TblFfpasstSectionResponse> sectionResponses = CreateMultipleSectionResponses(context, log.Id, sectionIds);

        return (log, questionResponses, sectionResponses, selections);
    }

    /// <summary>
    /// Seeds test assessment data into the database context
    /// </summary>
    /// <param name="context">Database context to seed</param>
    public static void SeedAssessmentTestData(CasimoDbContext context)
    {
        try
        {

            if (!context.TblInfTypes.Any())
            {
                // Add test infrastructure types
                List<TblInfType> infTypes =
                [
                    new()
            {
                Type = "Community Center"
            },
            new()
            {
                Type = "Library"
            }
                ];
                context.TblInfTypes.AddRange(infTypes);
            }

            if (!context.TblFfptemplateTitles.Any())
            {

                // Add test template titles
                List<TblFfptemplateTitle> templateTitles =
                [
                    new()
            {
                Description = "Test Assessment Template 1",
                Lgaid = "AID",
                Title = "TemplateTitle1"
            },
            new()
            {
                Description = "Test Assessment Template 2",
                Lgaid = "AID",
                Title = "TemplateTitle2"
            }
                ];
                context.TblFfptemplateTitles.AddRange(templateTitles);
            }

            if (!context.TblFfpasstLogs.Any())
            {
                // Add test assessment logs
                List<TblFfpasstLog> assessmentLogs =
                [
                    new()
            {
                FacilityId = 1,
                TemplateId = 1,
                InfTypeId = 1,
                AssessmentPersons = "John Doe",
                AssessmentDate = DateTime.Now.AddDays(-30)
            },
            new()
            {
                FacilityId = 2,
                TemplateId = 2,
                InfTypeId = 2,
                AssessmentPersons = "Jane Smith",
                AssessmentDate = DateTime.Now.AddDays(-15)
            }
                ];
                context.TblFfpasstLogs.AddRange(assessmentLogs);
            }

            context.SaveChanges();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }
}