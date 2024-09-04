using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApi_Inventarios.Models;

namespace WebApi_Inventarios.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Inventario> inventarios { get; set; }
    }
}
