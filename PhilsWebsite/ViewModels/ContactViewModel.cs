using System.ComponentModel.DataAnnotations;

namespace PhilsWebsite.ViewModels
{
	public class ContactViewModel
	{
		

				[Required]
				public string Name { get; set; }

				[Required]
				public string Email { get; set; }

				[Required]
				[StringLength(30, MinimumLength = 20)]
				public string Message { get; set; }

				

		

	}
}

