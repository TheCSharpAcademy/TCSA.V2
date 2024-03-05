namespace TCSA.V2.Models.DTO;

public class RoadmapTask
{
    public int Id { get; set; }
    public string IconUrl { get; set; }
    public string Name { get; set; }
    public bool IsCompleted { get; set; }
    public List<RoadmapTask>? Subtasks { get; set; }
}

