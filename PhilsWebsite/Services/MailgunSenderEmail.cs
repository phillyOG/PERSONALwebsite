using System;
using FluentEmail.Core;
using FluentEmail.Mailgun;
using Microsoft.Extensions.Options;
using PhilsWebsite.Services;

namespace PhilsWebsite.Interfaces
{
    public class MailgunSenderEmail : IMailgunSenderEmail
    {
        private readonly ILogger _logger;
        public AuthorizeMessageSender Options { get; set; }

        public MailgunSenderEmail(IOptions<AuthorizeMessageSender> options, ILogger<MailgunSenderEmail> logger)
        {
            Options = options.Value;
            _logger = logger;
        }

        public async Task SendEmailAsync(string name, string fromEmail, string message)
        {
            if (string.IsNullOrEmpty(Options.DomainName))
            {
                throw new Exception("Null MailgunDomain");
            }
            else if (string.IsNullOrEmpty(Options.ApiKey))
            {
                throw new Exception("Null MailgunKey");
            }
            await Execute(Options.DomainName, Options.ApiKey, name + " Contact Form", message, "goska953@gmail.com");
        }

        private async Task Execute(string domainName, string apiKey, string subject, string message, string toEmail)
        {
            var client = new MailgunSender(domainName, apiKey);
            var msg = Email
                .From($"mailgun@{domainName}")
                .To(toEmail)
                .Subject(subject)
                .Body(message, isHtml: false);

            var response = await client.SendAsync(msg);
            _logger.LogInformation(response.Successful
                                   ? $"Email to {toEmail} queued successfully!"
                                   : $"Failure Email to {toEmail}");
        }
    }
}

