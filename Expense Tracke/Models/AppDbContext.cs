using Microsoft.EntityFrameworkCore;
namespace Expense_Tracke.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options):base(options) { }
        
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categorys { get; set; }

    }
}
