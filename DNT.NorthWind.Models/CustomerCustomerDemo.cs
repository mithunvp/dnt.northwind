using System;
using System.ComponentModel.DataAnnotations;

public class CustomerCustomerDemo
{
    [Required]
    [MaxLength(5)]
    public string CustomerID { get; set; }

    [Required]
    [MaxLength(10)]
    public string CustomerTypeID { get; set; }

}
