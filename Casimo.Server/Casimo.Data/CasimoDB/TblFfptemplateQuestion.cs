using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblFfptemplateQuestion
{
    /// <summary>
    /// QuestionID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// ID from tblFFPtemplateSections
    /// </summary>
    public int SectionId { get; set; }

    /// <summary>
    /// Numeric or character suffix to section number (e.g. &apos;a&apos;, &apos;b&apos;, or &apos;i&apos;, &apos;ii&apos;, or &apos;-1&apos;, &apos;-2&apos;)
    /// </summary>
    public string? Subsection { get; set; }

    /// <summary>
    /// Numeric order that questions appear in
    /// </summary>
    public int QuestionOrder { get; set; }

    /// <summary>
    /// Short title or name for each question (max 100 characters)
    /// </summary>
    public string? QuestionTitle { get; set; }

    /// <summary>
    /// Question text (max 150 characters)
    /// </summary>
    public string? QuestionText { get; set; }

    /// <summary>
    /// Comments / prompts to help respondees answer the question
    /// </summary>
    public string? HelpComments { get; set; }

    public virtual TblFfptemplateSection Section { get; set; } = null!;

    public virtual ICollection<TblFfpasstQuestionResponse> TblFfpasstQuestionResponses { get; set; } = new List<TblFfpasstQuestionResponse>();
}
