using mcfbackend.Models;
using Microsoft.EntityFrameworkCore;

namespace mcfbackend.Context
{
    public class McfDbContext : DbContext
    {
        public McfDbContext(DbContextOptions<McfDbContext> options) : base(options) { }

        public DbSet<Ms_user> Ms_user { get; set; }
        public DbSet<Ms_storage_location> Ms_storage_location { get; set; }
        public DbSet<Tr_bpkb> Tr_bpkb { get; set; }
    }
}
    