using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coquo.Models
{
    public class Dish
    {
        [Key]
        [Display(Name ="Dish ID")]
        public int DishId { get; set; }

        [Required]
        [Display(Name = "Dish Name")]
        public string DishName { get; set; }

        [Display(Name = "Dish Description")]
        public string DishDescription { get; set; }
    }
}
