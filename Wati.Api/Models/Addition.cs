using System.ComponentModel.DataAnnotations;

namespace Wati.Api.Models
{
    public class Addition
    {
        public int Id { get; set; }
        [Required]
        public int Num1 { get; set; } 
        [Required]
        public int Num2 { get; set; } 
        [Required]
        public int Sum { get; set; } 
    }
}
