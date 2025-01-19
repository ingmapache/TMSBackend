using System.ComponentModel.DataAnnotations;

namespace Entities;

public class UTask
{
	[Key]
    public int Id { get; set; }

	[Required]
	[MaxLength(100)]
    public string? Name { get; set; }

	[MaxLength(400)]
    public string? Description { get; set; }

	//Relation to User
    public int UserId { get; set; }
	public User? User { get; set; }

	//Relation to Category
    public int CategoryId { get; set; }
	public Category? Category { get; set; }
}