using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreInventory.Models;

namespace StoreInventory.Contexts{
    public class ClothesContext : DbContext{
        public ClothesContext(DbContextOptions<ClothesContext> options) : base(options){
        }
        public DbSet<Clothes> Clothes {get; set;}
        public DbSet<ClothesType> ClothesTypes {get; set;}
        public DbSet<Gender> Genders {get; set;}
    }
}