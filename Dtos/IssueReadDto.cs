namespace IssueTracker.Dtos
{
  public class IssueReadDto
  {
      public int Id { get; set; }
      public string Title { get; set; }
      public string Desc { get; set; }
      public string Status { get; set; }
  }  
}