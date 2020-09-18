using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Context
{
    public class GameContext : DbContext
    {
        public GameContext()
        {
        }

        public GameContext(DbContextOptions<GameContext> options) : base(options) { }
        public DbSet<GameModel> Games { get; set; }
        public DbSet<Spot> Spots { get; set; }
        public DbSet<Reward> Rewards { get; set; }
        public DbSet<IntersectionGameSpot> IntersectionGameSpots { get; set; }

        public DbSet<IntersectionGameReward> IntersectionGameRewards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IntersectionGameSpot>()
                .HasKey(bc => new { bc.GameId, bc.SpotId });
            modelBuilder.Entity<IntersectionGameSpot>()
                .HasOne(bc => bc.GameModel)
                .WithMany(b => b.IntersectionGameSpots)
                .HasForeignKey(bc => bc.GameId);
            modelBuilder.Entity<IntersectionGameSpot>()
                .HasOne(bc => bc.Spot)
                .WithMany(c => c.IntersectionGameSpots)
                .HasForeignKey(bc => bc.SpotId);

            modelBuilder.Entity<IntersectionGameReward>()
                .HasKey(bc => new { bc.GameId, bc.RewardId });
            modelBuilder.Entity<IntersectionGameReward>()
                .HasOne(bc => bc.GameModel)
                .WithMany(b => b.IntersectionGameRewards)
                .HasForeignKey(bc => bc.GameId);
            modelBuilder.Entity<IntersectionGameReward>()
                .HasOne(bc => bc.Reward)
                .WithMany(c => c.IntersectionGameRewards)
                .HasForeignKey(bc => bc.RewardId);
        }
    }
}
