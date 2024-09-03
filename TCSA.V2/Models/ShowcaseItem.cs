using System.ComponentModel.DataAnnotations;
using TCSA.V2.Data;
namespace TCSA.V2.Models;

public class ShowcaseItem
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string AppUserId { get; set; }
    public ApplicationUser ApplicationUser { get; set; }
    public int ProjectId { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public bool GoldenProject { get; set; } = false;
    [Required]
    //[EmbedCodeValidator(ErrorMessage = "Please enter a valid YouTube embed code.")]
    public string VideoUrl { get; set; }
}

