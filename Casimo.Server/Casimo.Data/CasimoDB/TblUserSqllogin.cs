using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblUserSqllogin
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Lgaid { get; set; }

    public string? LgareadableDbsuffix { get; set; }

    public int? PrimaryUserId { get; set; }

    public int? KinderLdcuserId { get; set; }
}
