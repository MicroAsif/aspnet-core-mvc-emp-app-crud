using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetT.Models
{
    [Table("Employees")]
    public class Employee
    {

        [Key]        
       public int Id { get; set; }
       [Required]
       [StringLength(255)]
       public string Name { get; set; }
       public int Age { get; set; }
       
    }
}