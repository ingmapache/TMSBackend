using System.ComponentModel.DataAnnotations;

namespace Entities;

public class TaskEntity
{
    public int Id { get; set; }

	[Required]
	[MaxLength(100)]
    public string? TaskName { get; set; }

	[MaxLength(400)]
    public string? TaskDescription { get; set; }

	//Relation to User
    public int UserId { get; set; }
	public UserEntity? User { get; set; }

	//Relation to Category
    public int CategoryId { get; set; }
	public CategoryEntity? Category { get; set; }
}