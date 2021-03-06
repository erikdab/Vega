using Microsoft.EntityFrameworkCore;
using Vega.Models;

namespace Vega.Data
{
    public class VegaContext : DbContext
    {
        public VegaContext(DbContextOptions<VegaContext> options) : base(options) {

        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }
    }
}