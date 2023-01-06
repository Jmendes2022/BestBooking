namespace BestBooking.Classes
{
    public class smtpClientClass : IsmtpClientClass
    {

        public string Host { get; set; }
        public int Port { get; set; }
        public bool UseDefaultCredentials { get; set; }
        public bool EnableSsl { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public smtpClientClass()
        {
            Host = "smtp.office365.com";
            Port = 587;
            UseDefaultCredentials = true;
            EnableSsl = true;
            Username = "BestBookingSales@outlook.com";
            Password = "ThisIsASecurePassword123#";
        }


    }
}
