using Microsoft.AspNetCore.Mvc;
using PhilsWebsite.Interfaces;
using PhilsWebsite.Models;
using PhilsWebsite.ViewModels;
using System.Diagnostics;

namespace PhilsWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMailgunSenderEmail _mailgunSenderEmail;

      
        public HomeController(ILogger<HomeController> logger, IMailgunSenderEmail mailSenderEmail)
        {
            _logger = logger;
            _mailgunSenderEmail = mailSenderEmail;
        }

        [HttpGet]
        public IActionResult Contact()
        {
            ContactViewModel contactViewModel = new ContactViewModel();
            return View(contactViewModel);
        }


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Projects()
        {
            return View();
        }
    

        //make sure its state is valid
        [HttpPost]
        public async Task<IActionResult> Contact(ContactViewModel contactViewModel)
        {
            if (ModelState.IsValid)
            {
                await _mailgunSenderEmail.SendEmailAsync(contactViewModel.Name, contactViewModel.Email, contactViewModel.Message);
                //redirect to contact
                return RedirectToAction("Index");
            }
            else
            {
                return View(contactViewModel);
            }
        }



        public IActionResult About()
        {
            return View();
        }

     
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}