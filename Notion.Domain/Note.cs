namespace Notion.Domain;

public class Note
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}