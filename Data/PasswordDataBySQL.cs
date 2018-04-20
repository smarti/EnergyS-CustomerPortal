using Data.Entities;

namespace Data
{
    public class PasswordDataBySQL
    {
        private readonly DBContext _context;

        public PasswordDataBySQL(DBContext context)
        {
            _context = context;
        }

        public void UpdatePasswordHash(Customer customer, string passwordHash)
        {
            Customer currentCustomer = _context.Customers.Find(customer.CustomerId);
            Password currentPassword = _context.Passwords.Find(currentCustomer.Password.PasswordId);

            currentPassword.PasswordHash = passwordHash;
            _context.SaveChangesAsync();
        }
    }
}