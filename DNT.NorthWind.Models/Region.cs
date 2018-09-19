using System;
using System.ComponentModel.DataAnnotations;

public class Region
{
    [Required]
    public int RegionID { get; set; }

    [Required]
    [MaxLength(50)]
    public string RegionDescription { get; set; }

}
