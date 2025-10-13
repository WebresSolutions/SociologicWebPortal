using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblFfpassessmentScheme
{
    /// <summary>
    /// SchemeID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Short code from tblLGA
    /// </summary>
    public string Lgaid { get; set; } = null!;

    /// <summary>
    /// Questions or Sections
    /// </summary>
    public string ScoreBy { get; set; } = null!;

    /// <summary>
    /// Short name / title for Response 2 (e.g. &apos;FFP now&apos;)
    /// </summary>
    public string Response1title { get; set; } = null!;

    /// <summary>
    /// Short name / title for Response 2 (e.g. &apos;Suggested solutions&apos;)
    /// </summary>
    public string Response2title { get; set; } = null!;

    /// <summary>
    /// Short name / title for Score 1 (e.g. &apos;FFP now&apos;)
    /// </summary>
    public string Score1title { get; set; } = null!;

    /// <summary>
    /// Short name / title for Score 2 (e.g. &apos;FFP future&apos;)
    /// </summary>
    public string Score2title { get; set; } = null!;

    /// <summary>
    /// Option to use drop-down selection responses as well as text response #1
    /// </summary>
    public bool? UseResponseSelections1 { get; set; }

    /// <summary>
    /// Option to use drop-down selection responses as well as text response #2
    /// </summary>
    public bool? UseResponseSelections2 { get; set; }

    /// <summary>
    /// Option to require a 2nd response
    /// </summary>
    public bool? UseResponse2 { get; set; }

    /// <summary>
    /// Option to select whether a 2nd score is required
    /// </summary>
    public bool? UseScore2 { get; set; }

    /// <summary>
    /// Option to provide prompts / additional comments next to each question to aid respondees
    /// 
    /// </summary>
    public bool? UseHelpComments { get; set; }

    /// <summary>
    /// Show a short textual description / explanation next to each selected score e.g &apos;No impact&apos; or &apos;Moderate impact&apos;
    /// </summary>
    public bool? ShowScoreDescriptions { get; set; }

    /// <summary>
    /// Option to use text summaries for each section / category for which the value in tblFFPtemplateSections.SummaryRequired = Yes
    /// </summary>
    public bool? UseSectionSummaries { get; set; }

    /// <summary>
    /// Option to require at least 1 score for each section / category
    /// </summary>
    public bool? UseSectionScores { get; set; }

    /// <summary>
    /// Method to determine section scores: Manual (manual entry), Sum, Avg (sum or simple average of question scores, ONLY where questions scored)
    /// </summary>
    public string? SectionScoreMethod { get; set; }

    /// <summary>
    /// Option to calculate at least 1 overall assessment (facility) score
    /// </summary>
    public bool? UseOverallScore { get; set; }

    /// <summary>
    /// Method to determine overall score(s): Manual, SecSum, SecAvg, SecWtAvg, QSum, QAvg, QWtAvg
    /// </summary>
    public string? OverallScoreMethod { get; set; }

    /// <summary>
    /// ID from tblScoreSysTitles
    /// </summary>
    public int ScoreSystemId { get; set; }

    public bool? UseOverallScoreRanges { get; set; }

    public virtual ICollection<TblFfptemplateTitle> TblFfptemplateTitles { get; set; } = new List<TblFfptemplateTitle>();
}
