using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProjectManager.Models.Database;

public class DbContext: IdentityDbContext<User>
{
    public DbContext(DbContextOptions<DbContext> options) : base(options) { }
    public DbSet<Project> Projects { get; set; }
}