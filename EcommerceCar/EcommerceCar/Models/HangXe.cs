using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarBook.Models
{
    public class HangXe
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
      
        
       
    }
}
