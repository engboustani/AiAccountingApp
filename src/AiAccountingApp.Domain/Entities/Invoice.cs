namespace AiAccountingApp.Domain.Entities;

public class Invoice
{
    public int Id { get; set; }
    public string InvoiceNumber { get; set; }
    public DateTime InvoiceDate { get; set; }
    public DateTime DueDate { get; set; }
    public string Status { get; set; } // Draft, Sent, Paid, Overdue, Cancelled
    public decimal Total { get; set; }
    public string Notes { get; set; }
    public int CustomerId { get; set; }
    public string UserId { get; set; }
        
    public Customer Customer { get; set; }
    public ApplicationUser User { get; set; }
    public ICollection<InvoiceItem> Items { get; set; } = new List<InvoiceItem>();
}