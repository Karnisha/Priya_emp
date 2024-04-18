namespace EmployeeManagement.Data
{
    public class RestaurantAddress
    {
        public int RestaurantAddressId { get; set; }
        public string Name { get; set; }
        public string Doorno { get; set; }
        public string Street { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string District { get; set; }

        public string State { get; set; }
        public string PinCode { get; set; }

        public string Zone { get; set; }



        public Restaurant Restaurant { get; set; }

    }
}
