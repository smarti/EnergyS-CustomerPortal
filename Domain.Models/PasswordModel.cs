namespace Domain.Models
{
    public class PasswordModel
    {
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
    }
}