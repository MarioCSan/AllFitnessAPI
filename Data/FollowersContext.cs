using Microsoft.EntityFrameworkCore;
using AllFitnessAPI.Models;

namespace AllFitnessAPI.Data
{
    public class SeguidoresContext : DbContext
    {
        public SeguidoresContext(DbContextOptions<SeguidoresContext> options) : base(options)
        {
        }

        public DbSet<Seguidores> Seguidores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Seguidores>()
                .HasKey(s => new { s.FollowerId, s.FolloweeId });

            modelBuilder.Entity<Seguidores>()
                .HasOne(s => s.Follower)
                .WithMany()
                .HasForeignKey(s => s.FollowerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Seguidores>()
                .HasOne(s => s.Followee)
                .WithMany()
                .HasForeignKey(s => s.FolloweeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
