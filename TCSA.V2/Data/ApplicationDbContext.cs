using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TCSA.V2.Models;

namespace TCSA.V2.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public virtual DbSet<DashboardProject> DashboardProjects { get; set; }
    public virtual DbSet<AppUserActivity> UserActivity { get; set; }
    public virtual DbSet<UserReview> UserReviews { get; set; }
    public virtual DbSet<ApplicationUser> AspNetUsers { get; set; }
    public virtual DbSet<CommunityIssue> Issues { get; set; }
    public virtual DbSet<Challenge> Challenges { get; set; }
    public virtual DbSet<UserChallenge> UserChallenges { get; set; }
    public virtual DbSet<DailyStreak> DailyStreaks { get; set; }
    public virtual DbSet<ShowcaseItem> ShowcaseItems { get; set; }


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

        modelBuilder.Entity<DailyStreak>()
            .HasKey(ds => ds.AppUserId);

        modelBuilder.Entity<DailyStreak>()
            .HasOne(ds => ds.User)
            .WithOne(u => u.DailyStreak)
            .HasForeignKey<DailyStreak>(ds => ds.AppUserId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ShowcaseItem>()
            .HasOne(si => si.ApplicationUser)
            .WithMany(au => au.ShowcaseItems) 
            .HasForeignKey(si => si.AppUserId);

        //modelBuilder.Entity<Challenge>().HasData(
        //    new Challenge
        //    {
        //        Id = 1,
        //        ExternalId = "50654ddff44f800200000007",
        //        Description = "Solve the string reversal problem.",
        //        Keywords = "strings, reversal, beginner",
        //        Name = "String Reversal",
        //        ReleaseDate = new DateTime(2024, 1, 1),
        //        ExperiencePoints = 100,
        //        Platform = ChallengePlatform.CodeWars,
        //        Level = Level.White
        //    },
        //    new Challenge
        //    {
        //        Id = 2,
        //        ExternalId = "CHL002",
        //        Description = "Solve the array sum problem.",
        //        Keywords = "arrays, sum",
        //        Name = "Array Sum",
        //        ReleaseDate = new DateTime(2024, 2, 1),
        //        ExperiencePoints = 200,
        //        Platform = ChallengePlatform.LeetCode,
        //        Level = Level.Green,
        //    },
        //    new Challenge
        //    {
        //        Id = 3,
        //        ExternalId = "CHL003",
        //        Description = "Solve the SQL join problem.",
        //        Keywords = "sql, join",
        //        Name = "SQL Join",
        //        ReleaseDate = new DateTime(2024, 3, 1),
        //        ExperiencePoints = 300,
        //        Platform = ChallengePlatform.HackerRank,
        //        Level = Level.OliveGreen
        //    },
        //    new Challenge
        //    {
        //        Id = 4,
        //        ExternalId = "CHL004",
        //        Description = "Solve the palindrome check problem.",
        //        Keywords = "strings, palindrome, beginner",
        //        Name = "Palindrome Check",
        //        ReleaseDate = new DateTime(2024, 4, 1),
        //        ExperiencePoints = 150,
        //        Platform = ChallengePlatform.CodeWars,
        //        Level = Level.Yellow
        //    },
        //    new Challenge
        //    {
        //        Id = 5,
        //        ExternalId = "CHL005",
        //        Description = "Solve the array rotation problem.",
        //        Keywords = "arrays, rotation, intermediate",
        //        Name = "Array Rotation",
        //        ReleaseDate = new DateTime(2024, 5, 1),
        //        ExperiencePoints = 250,
        //        Platform = ChallengePlatform.LeetCode,
        //        Level = Level.Orange
        //    }
        //);

        modelBuilder.Entity<ApplicationUser>().HasData(
    new ApplicationUser
    {
        Id = "1", // Specify the user ID
        UserName = "pablo.queensland@gmail.com", // Set the username/email
        NormalizedUserName = "pablo.queensland@gmail.com", // Set the normalized username/email
        Email = "pablo.queensland@gmail.com", // Set the email
        NormalizedEmail = "pablo.queensland@gmail.com", // Set the normalized email
        EmailConfirmed = true, // Email confirmation status
        PasswordHash = "AQAAAAIAAYagAAAAEPglSOjEpJHarP9YEcFBV42oyI3H27zy9fnQkFQ4C5eGaZ0advvTUUmZxb2ld0iIzg==", // Password hash (make sure to hash the password)
        SecurityStamp = "LMEDMQOELGOLEONATD5I5OEATIHYPVHO", // Security stamp,
        Country = "Brazil",
        FirstName = "John",
        LastName = "Doe",
        CodeWarsUsername = "pabloqueensland",
    }
);

        //modelBuilder.Entity<UserChallenge>().HasData(
        //    new UserChallenge { ChallengeId = 2, UserId = "1" },
        //    new UserChallenge { ChallengeId = 3, UserId = "1" }
        //);
    }
}
