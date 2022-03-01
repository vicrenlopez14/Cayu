namespace Domain.Entities;

public abstract class Message
{
    public string Id { get; set; }
    public string Owner { get; set; }
    public DateTime SentAt { get; set; }
    public String AnswersTo { get; set; }
}