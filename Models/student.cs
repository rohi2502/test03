using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class student
    {
        [Key] 
        public int Id { get; set; }

        [Required]
        [Column(TypeName="nvarchar(250)")]
        public string Name { get; set; } = "";
        public int contactnumber { get; set; } 
        public int Age { get; set; }   

    }
}
