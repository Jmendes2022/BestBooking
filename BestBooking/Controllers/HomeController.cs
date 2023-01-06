using BestBooking.Classes;
using BestBooking.Models;
using FluentEmail.Core;
using FluentEmail.Smtp;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Mail;

namespace BestBooking.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmailMessage _emailMessage;
        private readonly IsmtpClientClass _ismtpClient;

        public HomeController(ILogger<HomeController> logger, IEmailMessage emailMessage, IsmtpClientClass ismtpClient)
        {
            _logger = logger;
            _emailMessage = emailMessage;
            _ismtpClient = ismtpClient;
        }

        public IActionResult Index()
        {
            return View();
        }

        
        public async Task<IActionResult> ContactUs(ContactUsModalModel contact)
        {
            EmailMessage emailMessage = new EmailMessage(contact);

            //This imitates an email being sent from here to an email address that would be used for the business. For now, this code will send an email directly to the local machine in a folder within the C drive, called "Demos"
            if (ModelState.IsValid)
            {
                var sender = new SmtpSender(() => new SmtpClient("smtp.gmail.com")
                {
                    EnableSsl = false,
                    DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory,
                    PickupDirectoryLocation = @"C:\Demos"
                });

                Email.DefaultSender = sender;

                var email = await Email
                    .From(_emailMessage.From)
                    .To(_emailMessage.To)
                    .Subject(emailMessage.Subject)
                    .Body(emailMessage.Message)
                    .SendAsync();


                return View(nameof(SubmissionConfirmation), contact);
            }
            else
            {
                return View(nameof(Index));
            }
            
        }

        //This Action and view just pass the user's name via the Contact Model so that they can
        //be thanked with a personalized message using their personal name.
        public IActionResult SubmissionConfirmation(ContactUsModalModel contact)
        {
            return View(contact.FirstName);
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