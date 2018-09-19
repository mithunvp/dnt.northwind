using System;
using System.ComponentModel.DataAnnotations;

namespace DNT.NorthWind.Models
{
    public class Products
    {
        [Required]
        public int ProductID { get; set; }

        [Required]
        [MaxLength(40)]
        public string ProductName { get; set; }

        public int SupplierID { get; set; }

        public int CategoryID { get; set; }

        [MaxLength(20)]
        public string QuantityPerUnit { get; set; }

        public decimal UnitPrice { get; set; }

        public string UnitsInStock { get; set; }

        public string UnitsOnOrder { get; set; }

        public string ReorderLevel { get; set; }

        [Required]
        public bool Discontinued { get; set; }

    }

}
