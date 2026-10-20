using Microsoft.EntityFrameworkCore;
namespace GitHubPractice.Models
{
    public class MembershipContext : DbContext
    {
        public MembershipContext(DbContextOptions<MembershipContext> options) : base(options)
        {
        }
        public DbSet<Membership> Memberships { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Membership>().HasData(
                new Membership { Id = 1, Name = "Frank Furter", Email = "frank@example.com", JoinDate = new DateTime(2025, 6, 28, 20, 51, 0) },
                new Membership { Id = 2, Name = "Cookie Crumb", Email = "cookie@example.com", JoinDate = new DateTime(2025, 1, 28, 20, 51, 0) },
                new Membership { Id = 3, Name = "Sierra Madre", Email = "sierra@example.com", JoinDate = new DateTime(2025, 1, 1, 20, 51, 0) },
                new Membership { Id = 4, Name = "Ima Winner" , Email = "ima@example.com", JoinDate = new DateTime(2025, 2, 14, 20, 51, 0) },
                new Membership { Id = 5, Name = "Truly Sporty" , Email = "truly@example.com", JoinDate = new DateTime(2025, 3, 7, 20, 51, 0) }
                );
        }
    }

}
