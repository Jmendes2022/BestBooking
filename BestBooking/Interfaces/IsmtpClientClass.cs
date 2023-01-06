namespace BestBooking.Classes
{
    public interface IsmtpClientClass
    {
        bool EnableSsl { get; set; }
        string Host { get; set; }
        string Password { get; set; }
        int Port { get; set; }
        bool UseDefaultCredentials { get; set; }
        string Username { get; set; }
    }
}