using BestBooking.Models;

namespace BestBooking
{
    public class EmailMessage : IEmailMessage
    {
        public string Message { get; set; }
        public string Subject { get; set; }
        public string To { get; set; }
        public string From { get; set; }

        public EmailMessage()
        {
            To = "BestBookingSales@outlook.com";
            From = "BestBookingSales@outlook.com";
        }

        public EmailMessage(ContactUsModalModel contact)
        {
            

            Subject = $"{contact.FirstName} {contact.LastName} is requesting a {contact.TypeOfTrip} quote!";

            Message = $"Hey there! You have a client that is requesting information on a trip. \n\nHere is their information: \n\nName: {contact.FirstName + contact.LastName}\nAge: {contact.Age}\nEmail: {contact.Email}\nPhone Number: {contact.PhoneNumber}\nNumber Type: {contact.Type}\nNumber of People for trip: {contact.NumberOfPeople}\nType of Trip: {contact.TypeOfTrip}\nStart Date: {contact.StartDate}\nEnd Date: {contact.EndDate}";
        }

    }
}
