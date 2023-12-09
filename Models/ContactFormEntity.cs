using System.ComponentModel.DataAnnotations;

namespace Crito.Models
{
	public class ContactFormEntity
	{
		
			[Key]
		public string Email { get; set; } = null!;

		public string Name { get; set; } = null!;
			
		

			public string Message { get; set; } = null!;

			public string? RedirectUrl { get; set; } = "/";


		

	}
}
