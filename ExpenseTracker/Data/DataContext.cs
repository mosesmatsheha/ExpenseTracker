using Microsoft.EntityFrameworkCore;
using ExpenseTracker.Models;
namespace ExpenseTracker.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Expense> Expenses { get; set; }
    }
}
