namespace AiAccountingApp.Domain.Entities;

public class ChatMessage
{
    public int Id { get; set; }
    public int SessionId { get; set; }
    public string Content { get; set; }
    public bool IsFromUser { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    public string ActionTaken { get; set; } // Stores any system actions executed based on this message
        
    public ChatSession Session { get; set; }
}