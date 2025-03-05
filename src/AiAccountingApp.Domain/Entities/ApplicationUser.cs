using Microsoft.AspNetCore.Identity;

namespace AiAccountingApp.Domain.Entities;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int? CompanyId { get; set; }
    public Company Company { get; set; }
    public ICollection<ChatSession> ChatSessions { get; set; } = new List<ChatSession>();
}