namespace EmployeeManagement.Data
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long MobileNumber { get; set; }
        public string Password { get; set; }
        public ICollection<Address> Addresses { get; }
        public ICollection<Order> Orders { get; }

    }
}
