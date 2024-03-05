namespace TCSA.V2.Models.DTOs;

public class CodeReviewDetail
{
    public int ProjectId { get; set; }
    public bool IsCompleted { get; set; }
    public string UserName { get; set; }
    public string ProjectName { get; set; }
}
