using System.ComponentModel.DataAnnotations;

namespace Entities;

    public class User
    {	
		[Key]
        public int Id { get; set; }

		[Required]
		[MaxLength(20)]
        public string? AccountNickname { get; set; }

		[Required]
		[MaxLength(30)]
        public string? Name { get; set; }
		
		[Required]
		[MaxLength(30)]
        public string? Surname { get; set; }

		[Required]
		[EmailAddress]
        public string? Email { get; set; }

		[Required]
        public string? Password { get; set; }

		// Relation to tasks
        public List<UTask>? UTasks { get; set; }
    }   

