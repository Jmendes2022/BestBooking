namespace BestBooking
{
    public interface IEmailMessage
    {
        string From { get; set; }
        string Message { get; set; }
        string Subject { get; set; }
        string To { get; set; }
    }
}