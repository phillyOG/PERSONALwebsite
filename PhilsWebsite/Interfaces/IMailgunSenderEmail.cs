using System;
namespace PhilsWebsite.Interfaces
{
	public interface IMailgunSenderEmail
	{
		Task SendEmailAsync(string name, string email, string body);
	}
}

