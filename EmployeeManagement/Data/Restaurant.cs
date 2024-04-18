namespace EmployeeManagement.Data
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantDescription { get; set; }

        public string RestaurantLocation {  get; set; }
        public ICollection<Food> foods { get; }

        public int RestaurantAddressId { get; set; }
        public RestaurantAddress RestaurantAddress { get; set;}
    }
}
