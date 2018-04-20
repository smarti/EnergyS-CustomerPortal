namespace Application.ViewModels
{
    public class ChangePasswordDTO
    {
        public int CustomerId { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}