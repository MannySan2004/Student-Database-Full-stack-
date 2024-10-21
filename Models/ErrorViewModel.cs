namespace ContosoUniversity.Models
{
    public class ErrorViewModel
    {
        // nullable problem not fixed yet
        // public string? RequestID { get; set;}
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
