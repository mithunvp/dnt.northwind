using System;
using System.ComponentModel.DataAnnotations;

namespace DNT.NorthWind.Models
{
    public class Shippers
    {
        [Required]
        public int ShipperID { get; set; }

        [Required]
        [MaxLength(40)]
        public string CompanyName { get; set; }

        [MaxLength(24)]
        public string Phone { get; set; }

    }

}
