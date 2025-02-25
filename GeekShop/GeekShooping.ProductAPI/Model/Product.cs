﻿using GeekShooping.ProductAPI.Model.Base;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShooping.ProductAPI.Model
{
    [Table("product")]
    public class Product : BaseEntity
    {
        [Column("name")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        
        [Column("price")]
        [Required]
        [Range(1,1000)]
        public decimal Price { get; set; }

        [Column ("description")]
        [StringLength(100)]
        public string Description { get; set; }

        //Normalizar depois
        [Column("category_name")]
        [StringLength(50)]
        public string categoryName { get; set; }

        [Column("image_url")]
        [StringLength (300)]
        public string imageURL { get; set; }
    }
}
