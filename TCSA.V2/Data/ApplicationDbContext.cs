using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TCSA.V2.Models;

namespace TCSA.V2.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<DashboardProject> DashboardProjects { get; set; }
        public virtual DbSet<AppUserActivity> UserActivity { get; set; }
        public virtual DbSet<UserReview> UserReviews { get; set; }
        public virtual DbSet<ApplicationUser> AspNetUsers { get; set; }
        public virtual DbSet<CommunityIssue> Issues { get; set; }
        public virtual DbSet<Challenge> Challenges { get; set; }
        public virtual DbSet<UserChallenge> UserChallenges { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserReview>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.CodeReviewProjects)
                .HasForeignKey(ur => ur.AppUserId)
                .IsRequired();

            modelBuilder.Entity<Challenge>()
                .HasIndex(c => c.ExternalId)
                .IsUnique();

            modelBuilder.Entity<Challenge>()
                .Property(c => c.Name)
                .IsRequired();

            modelBuilder.Entity<Challenge>()
                .HasAlternateKey(c => c.Name)
                .HasName("AlternateKey_Name");

            modelBuilder.Entity<UserChallenge>()
                .HasKey(uc => new { uc.ChallengeId, uc.UserId });

            modelBuilder.Entity<UserChallenge>()
                .HasOne(uc => uc.Challenge)
                .WithMany(c => c.UserChallenges)
                .HasForeignKey(uc => uc.ChallengeId);

            modelBuilder.Entity<UserChallenge>()
                .HasOne(uc => uc.User)
                .WithMany(u => u.UserChallenges)
                .HasForeignKey(uc => uc.UserId);
        }
    }
}
