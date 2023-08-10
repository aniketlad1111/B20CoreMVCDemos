﻿using System.ComponentModel.DataAnnotations;

namespace WebApiFirst.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(100, 1000)]
        public int UnitPrice { get; set; }

        public int CategoryId { get; set; }

        public CategoryModel? Category { get; set; }
    }
}
