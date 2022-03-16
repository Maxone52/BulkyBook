using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBook.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [DisplayName("Номер заказа")]
    [Range(1, 25, ErrorMessage = "Заказ должен быть от 1 до 25")]
    public int DisplayOrder { get; set; }
    public DateTime CreateDateTime { get; set; } = DateTime.Now;
}

