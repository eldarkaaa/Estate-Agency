using Microsoft.EntityFrameworkCore;

namespace Estate_Agency.Models.Data
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<SearchOrder> SearchOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
            
        }
    }
}
