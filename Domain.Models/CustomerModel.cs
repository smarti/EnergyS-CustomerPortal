namespace Domain.Models
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }

        public AddressModel Address { get; set; }
        public PasswordModel Password { get; set; }
    }
}