namespace IssueTracker.Models
{
  public class Issue
  {
      public int Id { get; set; }
      public string Title { get; set; }
      public string Desc { get; set; }
      public string Status { get; set; }
  }  
}