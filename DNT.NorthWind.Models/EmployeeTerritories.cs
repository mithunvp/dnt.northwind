using System;
using System.ComponentModel.DataAnnotations;

public class EmployeeTerritories
{
    [Required]
    public Int32 EmployeeID { get; set; }

    [Required]
    [MaxLength(20)]
    public String TerritoryID { get; set; }

}
