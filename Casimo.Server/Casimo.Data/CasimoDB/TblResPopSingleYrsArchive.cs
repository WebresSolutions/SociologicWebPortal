using System;
using System.Collections.Generic;

namespace Casimo.Data.CasimoDB;

public partial class TblResPopSingleYrsArchive
{
    public int Id { get; set; }

    /// <summary>
    /// LGA id
    /// </summary>
    public string? Lgaid { get; set; }

    /// <summary>
    /// Name of the population forecast boundary / area
    /// </summary>
    public string? Area { get; set; }

    /// <summary>
    /// Age (in single yrs)
    /// </summary>
    public double? AgeGroup { get; set; }

    /// <summary>
    /// Male, female or person
    /// </summary>
    public string? Gender { get; set; }

    /// <summary>
    /// Year of forecast
    /// </summary>
    public double? Year { get; set; }

    /// <summary>
    /// Forecast population
    /// </summary>
    public double? Number { get; set; }

    public DateOnly? ArchiveDate { get; set; }

    public string? ArchiveNotes { get; set; }
}
