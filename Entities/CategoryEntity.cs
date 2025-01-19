using System.ComponentModel.DataAnnotations;
namespace Entities;

public class Category
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(100)] 
    public string? Name { get; set; }
    
    //Relation to Tasks
    public List<UTask>? UTasks { get; set; }
}