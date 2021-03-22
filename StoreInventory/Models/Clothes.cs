using System;
using System.ComponentModel.DataAnnotations;

namespace StoreInventory.Models{
    public class Clothes{
        [Key]
        public Guid ClothesID {get; set; }
        [Required]
        [MaxLength(250)]
        public string Name {get; set; }
        public string Size {get; set; }
        public string Colour {get; set; }
        [Required]
        public decimal Price {get; set; }
        public string Description{get; set; }
        public ClothesType ClothesType {get; set; }
        public Gender Gender {get; set; }
    }
}