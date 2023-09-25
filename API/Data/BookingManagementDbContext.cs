using Microsoft.EntityFrameworkCore;
using API.Models;


namespace API.Data
{
    public class BookingManagementDbContext : DbContext
    {
        public BookingManagementDbContext(DbContextOptions<BookingManagementDbContext> options) : base(options)
        {

        }

        public DbSet<Account> { get;set; }
    }
}
