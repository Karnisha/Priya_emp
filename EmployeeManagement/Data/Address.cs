namespace EmployeeManagement.Data
{
    public class Address
    {
        public int AddressId { get; set; }
        public string? Name { get; set; }
        public string? Doorno { get; set; }
        public string? Street { get; set; }  
        public string? Area { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }

        public string? State { get; set; }
        public string? PinCode { get; set; }
        public User User { get; set; }
        public ICollection<Order> Orders { get; 0
}

    }
}
