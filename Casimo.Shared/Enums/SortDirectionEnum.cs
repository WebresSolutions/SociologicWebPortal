using System.ComponentModel.DataAnnotations;

namespace Casimo.Shared.Enums;

public enum SortDirectionEnum
{
    [Display(Name = "asc")]
    Asc = 1,

    [Display(Name = "desc")]
    Desc = 2,
}
