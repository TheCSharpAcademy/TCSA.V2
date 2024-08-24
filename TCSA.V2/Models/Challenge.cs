using TCSA.V2.Data;

namespace TCSA.V2.Models;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Challenge
{
    public int Id { get; set; }

    [Required(ErrorMessage = "External ID is required.")]
    public string ExternalId { get; set; }

    [Required(ErrorMessage = "Description is required.")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Keywords are required.")]
    public string Keywords { get; set; }

    [Required(ErrorMessage = "Name is required.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Release Date is required.")]
    public DateTime ReleaseDate { get; set; }

    [Required(ErrorMessage = "Experience Points are required.")]
    public int ExperiencePoints { get; set; }

    [Required(ErrorMessage = "Platform is required.")]
    public ChallengePlatform Platform { get; set; }

    [Required(ErrorMessage = "Level is required.")]
    public Level Level { get; set; }

    public virtual ICollection<UserChallenge> UserChallenges { get; set; }
}

public class DailyStreak
{
    public string AppUserId { get; set; }
    public ApplicationUser User { get; set; }

    public int CurrentStreak { get; set; }
    public int LongestStreak { get; set; }
    public DateTime LastCompletedDate { get; set; }
}


public class UserChallenge
{
    public int ChallengeId { get; set; }
    public Challenge Challenge { get; set; }

    public string UserId { get; set; }
    public ApplicationUser User { get; set; }

    public DateTime CompletedAt { get; set; }
}

public enum ChallengePlatform
{
    CodeWars = 1,
    LeetCode,
    HackerRank
}
