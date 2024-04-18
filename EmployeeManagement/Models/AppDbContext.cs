using EmployeeManagement.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }
        public DbSet<Address> addresses { get; set; }

        public DbSet<Food> foods { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Restaurant> restaurants { get; set;}

        public DbSet<User> users {  get; set; }

        public DbSet<RestaurantAddress> restaurantsAddress { get; set; }
    }
}
