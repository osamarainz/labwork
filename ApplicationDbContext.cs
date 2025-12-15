using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using labwork.Models;

namespace labwork.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<labwork.Models.book> book { get; set; } = default!;
    }
}
