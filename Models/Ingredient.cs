using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coquo.Models
{
    public class Ingredient
    {
        [Key]
        [Display(Name = "Ingredient ID")]
        public int IngredientID { get; set; }
        [Required]
        [Display(Name = "Ingredient Name")]
        public string IngredientName { get; set; }

        [Display(Name = "Ingredient Description")]
        public string IngredientDescription { get; set; }
    }
}