using CrudOperationsInRazorPages.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudOperationsInRazorPages.DAL
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Books> Books { get; set; }
    }
}