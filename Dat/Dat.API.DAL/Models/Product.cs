﻿using System.ComponentModel.DataAnnotations;

namespace Dat.API.DAL.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int LeftItems { get; set; }
    }
}
