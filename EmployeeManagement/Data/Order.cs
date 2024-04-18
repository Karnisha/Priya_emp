namespace EmployeeManagement.Data
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderDate { get; set; }

        public string DeliveryTime { get; set; }

        public int PaymentStatus { get; set; }

        public User User { get; set; }
        public Address Address { get; set; }

        public Food Food { get; set; }
        



    }
}
