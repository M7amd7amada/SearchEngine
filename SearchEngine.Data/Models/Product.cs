using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchEngine.Data.Models;

public class Product
{
    [Key]
    public int ProductId { get; set; }

    [Required]
    [MaxLength(100)]
    [DisplayName("Product Name")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [Column(TypeName = "decimal(8, 2)")]
    public decimal Price { get; set; }
}