using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StoreInventory.Models{
    //Simply <Type> is a taken name
    public class ClothesType{ 
        [Key]
        public Guid ClothesTypeID { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name{get; set;}

        public ICollection<Gender> Genders {get; set;}
    }
}