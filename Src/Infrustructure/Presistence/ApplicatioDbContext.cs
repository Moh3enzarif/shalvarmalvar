
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrustructure.Presistence;
internal class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
    { 
    }

    public DbSet<Product> Products => Set<Product>();   
}

