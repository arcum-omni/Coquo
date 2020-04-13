using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coquo.Models
{
    public class PantryItem
    {
        [Key]
        public int ItemID { get; set; }

        [Required]
        public Ingredient Item { get; set; }
        
        public string ItemDescription { get; set; }

        public string ItemVendor { get; set; }

        public double ItemQuantity { get; set; }

        public string ItemUnitOfMeasure { get; set; }

        public DateTime DateReceived { get; set; }

        public DateTime? ExpirationDate { get; set; }
    }
}
