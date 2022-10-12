using Microsoft.EntityFrameworkCore;
using SameerWalks.API.Models.Domain;

namespace SameerWalks.API.Data
{
    public class SameerWalksDbContext : DbContext
    {
        public SameerWalksDbContext(DbContextOptions<SameerWalksDbContext> options): base(options)
        {


        }
        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
