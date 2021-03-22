using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StoreInventory.Models{
    public class Gender{
        [Key]
        public Guid GenderID { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name{get; set;}

        public ICollection<ClothesType> ClothesTypes {get; set;}

    }
}