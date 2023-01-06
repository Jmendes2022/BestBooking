namespace BestBooking.Models
{
    public class ContactUsModalModel
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Age { get; set; }
        public string Email { get; set; } = null!;
        public long PhoneNumber { get; set; }
        public string Type { get; set; } = null!;
        public int NumberOfPeople { get; set; }
        public string TypeOfTrip { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
