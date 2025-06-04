using System.Collections.Generic;
using Crud.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }
    }
}
