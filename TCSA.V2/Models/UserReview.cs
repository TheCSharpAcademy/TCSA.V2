using TCSA.V2.Data;

namespace TCSA.V2.Models;

public class UserReview
{
    public int Id { get; set; }
    public ApplicationUser User { get; set; }
    public string AppUserId { get; set; }
    public int DashboardProjectId { get; set; }
}
