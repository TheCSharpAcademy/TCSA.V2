namespace TCSA.V2.Models.DTOs;
    public class AppUserForReviewLeaderboard
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? DisplayName { get; set; }
        public int? TotalXp { get; set; }
        public int ReviewsNumber { get; set; }
        public int Ranking { get; set; }
    }
