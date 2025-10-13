using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblFfpasstQuestionResponse
{
    /// <summary>
    /// TextResponseID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// ID from tblFFPtemplateQuestions
    /// </summary>
    public int QuestionId { get; set; }

    /// <summary>
    /// ID from tblFFPasstLog
    /// </summary>
    public int LogId { get; set; }

    /// <summary>
    /// Text response to each question (optional)
    /// </summary>
    public string? ResponseText1 { get; set; }

    /// <summary>
    /// Text response to each question (optional)
    /// </summary>
    public string? ResponseText2 { get; set; }

    /// <summary>
    /// ID from tblFFPasstSelections
    /// </summary>
    public int? Selection1Id { get; set; }

    /// <summary>
    /// ID from tblFFPasstSelections
    /// </summary>
    public int? Selection2Id { get; set; }

    /// <summary>
    /// Numeric score #1 for question
    /// </summary>
    public int? Qscore1 { get; set; }

    /// <summary>
    /// Numeric score #2 for question
    /// </summary>
    public int? Qscore2 { get; set; }

    public virtual TblFfpasstLog Log { get; set; } = null!;

    public virtual TblFfptemplateQuestion Question { get; set; } = null!;

    public virtual TblFfpasstSelection? Selection1 { get; set; }

    public virtual TblFfpasstSelection? Selection2 { get; set; }
}
