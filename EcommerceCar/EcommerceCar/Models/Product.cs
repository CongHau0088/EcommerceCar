using CarBook.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarBook.Models
{
    
    public partial class Product : BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Title { get;set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Amount { get; set; }
        [ForeignKey(nameof(Category))] 
        
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        public virtual ICollection<ProductImage> Images {  get; set; } = new List<ProductImage>();  
        public bool IsActive { get; set; }
    }
}
