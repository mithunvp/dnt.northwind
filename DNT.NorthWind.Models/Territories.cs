using System;
using System.ComponentModel.DataAnnotations;

public class Territories
{
    [Required]
    [MaxLength(20)]
    public string TerritoryID { get; set; }

    [Required]
    [MaxLength(50)]
    public string TerritoryDescription { get; set; }

    [Required]
    public int RegionID { get; set; }

}
