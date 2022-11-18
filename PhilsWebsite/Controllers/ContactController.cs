using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FluentEmail.Smtp;
using System.Net.Mail;
using FluentEmail.Core;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhilsWebsite.Controllers
{
    public class ContactController : Controller
    {
        class Contact
        {
            static async Task Main(string[] args)
            {
                var sender = new SmtpSender(() => new SmtpClient("localhost")
                {
                    //by default you wannt SSL on
                    //testing purpose i will turn it off
                    //not production
                    //for demo purposes
                    EnableSsl = false,
                    DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory,
                    //when you send an email it is sent to a directory as a file
                    PickupDirectoryLocation = @"C:\Demos"
                    
                });
                
                Email.DefaultSender = sender;

                //creating an email
                var email = await Email
                    .From("phil@gmail.com")
                    .To("test@test.com", "Sue")
                    .Subject("Thanks")
                    .Body("Thanks for leaving a message")
                    .SendAsync();

                
            }
        }
    }

}

