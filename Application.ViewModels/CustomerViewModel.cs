namespace Application.ViewModels
{
    public class CustomerViewModel
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }

        public AddressViewModel Address { get; set; }
        public PasswordViewModel Password { get; set; }
    }
}