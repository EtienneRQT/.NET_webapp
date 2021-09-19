using Microsoft.EntityFrameworkCore;
using pizza_mama_web.Models;

namespace pizza_mama_web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){
    
        }
    
        public DbSet<Pizza> Pizzas { get; set; }
    }
}