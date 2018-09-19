using System;
using System.ComponentModel.DataAnnotations;

public class CustomerDemographics
{
    [Required]
    [MaxLength(10)]
    public string CustomerTypeID { get; set; }

    
    public string CustomerDesc { get; set; }

}
