namespace EmployeeManagement.Data
{
    public class Food
    {
        public int FoodId { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? FoodType { get; set; }    

        public int price { get; set; }
        public int quantity { get; set; }
        
        public Restaurant Restaurant { get; set; }
        public ICollection<Order> Orders { get;}


        
        

    }
}
