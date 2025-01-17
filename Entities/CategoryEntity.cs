using System.ComponentModel.DataAnnotations;
namespace Entities;

public class CategoryEntity
{
    public int Id { get; set; }
    
    [Required]
    [MaxLength(100)] 
    public string? Name { get; set; }
    
    //Relation to Tasks
    public List<TaskEntity>? Tasks { get; set; }
}