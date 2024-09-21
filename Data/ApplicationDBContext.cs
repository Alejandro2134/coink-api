using coink_api.Data;
using coink_api.Models;
using Microsoft.EntityFrameworkCore;

namespace coink_api.Data;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {

    }

    public DbSet<User> Users { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Town> Towns { get; set; }
}