using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblUser
{
    public int UserId { get; set; }

    /// <summary>
    /// Username
    /// </summary>
    public string? UserName { get; set; }

    /// <summary>
    /// Password (max 15 characters)
    /// </summary>
    public string? Password { get; set; }

    public string? Firstname { get; set; }

    public string? Surname { get; set; }

    public bool? IsActive { get; set; }

    /// <summary>
    /// LGA id
    /// </summary>
    public string? Lgaid { get; set; }

    public string? NetworkUserName { get; set; }

    public string? Email { get; set; }

    public string? IdentityId { get; set; }

    public bool? IsTempUser { get; set; }

    public virtual ICollection<TblAltInfType> TblAltInfTypes { get; set; } = new List<TblAltInfType>();

    public virtual ICollection<TblFacility> TblFacilities { get; set; } = new List<TblFacility>();

    public virtual ICollection<TblUserAssignedAssessmentList> TblUserAssignedAssessmentLists { get; set; } = new List<TblUserAssignedAssessmentList>();
}
