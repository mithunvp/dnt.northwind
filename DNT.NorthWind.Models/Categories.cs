using System;
using System.ComponentModel.DataAnnotations;

namespace DNT.NorthWind.Models
{
    public class Categories
    {
        [Required]
        public int CategoryID { get; set; }

        [Required]
        [MaxLength(15)]
        public string CategoryName { get; set; }

        public string Description { get; set; }

        public string Picture { get; set; }

    }

}
