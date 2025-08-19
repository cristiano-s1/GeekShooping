using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GeekShooping.ProductAPI.Model.Base;

namespace GeekShooping.ProductAPI.Model
{
    [Table("Product")]
    public class Product : BaseEntity
    {
        [Column("Name")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; } = default!;

        [Column("Price")]
        [Required]
        [Range(1, 10000)]
        public decimal Price { get; set; }

        [Column("Description")]
        [StringLength(500)]
        public string Description { get; set; } = default!;

        [Column("CategoryName")]
        [StringLength(50)]
        public string CategoryName { get; set; } = default!;

        [Column("ImageUrl")]
        [StringLength(300)]
        public string ImageUrl { get; set; } = default!;
    }
}
