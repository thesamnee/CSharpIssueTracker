using System.ComponentModel.DataAnnotations;

namespace IssueTracker.Dtos
{
  public class IssueCreateDto
  {
    [Required]
    [MaxLength(30)]
      public string Title { get; set; }
      [Required]
      public string Desc { get; set; }
      [Required]
      public string Status { get; set; }
  }  
}