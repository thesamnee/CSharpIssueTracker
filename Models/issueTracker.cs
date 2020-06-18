using System.ComponentModel.DataAnnotations;

namespace IssueTracker.Models
{
  public class Issue
  {
      [Key]
      public int Id { get; set; }
      [Required]
      [MaxLength(70)]
      public string Title { get; set; }
      [Required]
      public string Desc { get; set; }
      [Required]
      public string Status { get; set; }

  }  
}