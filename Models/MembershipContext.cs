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
                new Membership
                {
                    Id = 1,
                    Name = "Frank Furter",
                    JoinDate = new DateTime(2025, 6, 28, 20, 51, 0),
                    BirthDate = new DateTime(1988, 10, 15)
                },
                new Membership
                {
                    Id = 2,
                    Name = "Cookie Crumb",
                    JoinDate = new DateTime(2025, 1, 28, 20, 51, 0),
                    BirthDate = new DateTime(1995, 3, 22)
                },
                new Membership
                {
                    Id = 3,
                    Name = "Sierra Madre",
                    JoinDate = new DateTime(2025, 1, 1, 20, 51, 0),
                    BirthDate = new DateTime(2000, 7, 19)
                },
                new Membership
                {
                    Id = 4,
                    Name = "Ima Winner",
                    JoinDate = new DateTime(2025, 2, 14, 20, 51, 0),
                    BirthDate = new DateTime(1992, 11, 30)
                },
                new Membership
                {
                    Id = 5,
                    Name = "Truly Sporty",
                    JoinDate = new DateTime(2025, 3, 7, 20, 51, 0),
                    BirthDate = new DateTime(1999, 5, 9)
                }
            );
        }
    }
}
