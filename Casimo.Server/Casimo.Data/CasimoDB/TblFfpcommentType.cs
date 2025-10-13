using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblFfpcommentType
{
    public int Id { get; set; }

    public short? CommentNumber { get; set; }

    public string? CommentType { get; set; }

    public string? CommentText { get; set; }

    public short? ReportOrder { get; set; }
}
