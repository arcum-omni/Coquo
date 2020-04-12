using System;
using System.Collections.Generic;
using System.Text;
using Coquo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Coquo.Data
{
    public class KitchenContext : IdentityDbContext
    {
        public KitchenContext(DbContextOptions<KitchenContext> options)
            : base(options)
        {
        }

        public DbSet<Ingredient> Ingredients { get; set; }

        public DbSet<Dish> Dishes { get; set; }

        public DbSet<Coquo.Models.PantryItem> PantryItem { get; set; }
    }
}
