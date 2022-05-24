using book_store.API.Models;
using Microsoft.EntityFrameworkCore;

namespace book_store.API.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts) { }

        public DbSet<User> Users { get; set; }
    }
}
