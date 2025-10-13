using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblFfpasstSelection
{
    /// <summary>
    /// SelectionID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// ID from tblFFPtemplateTitles
    /// </summary>
    public int? TemplateId { get; set; }

    public int SchemeId { get; set; }

    /// <summary>
    /// Text for each drop-down option (50 chars max)
    /// </summary>
    public string SelectionText { get; set; } = null!;

    /// <summary>
    /// Order that each option appears in the list
    /// </summary>
    public int SelectionOrder { get; set; }

    /// <summary>
    /// Text prompt to indicate whether a text response (record in tblFFPasstTextResponses) is required or optional (50 chars max)
    /// </summary>
    public string SelectionPrompt { get; set; } = null!;

    /// <summary>
    /// Access VBA value for conditional formatting backcolour of text box
    /// </summary>
    public int FormatColour { get; set; }

    public virtual ICollection<TblFfpasstQuestionResponse> TblFfpasstQuestionResponseSelection1s { get; set; } = new List<TblFfpasstQuestionResponse>();

    public virtual ICollection<TblFfpasstQuestionResponse> TblFfpasstQuestionResponseSelection2s { get; set; } = new List<TblFfpasstQuestionResponse>();
}
