using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreInventory.Models;

namespace StoreInventory.Contexts{
    public class ClothesContext : DbContext{
        public ClothesContext(DbContextOptions<ClothesContext> opt) 
            : base(opt){
        }
    }
}