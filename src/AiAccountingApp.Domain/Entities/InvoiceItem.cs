namespace AiAccountingApp.Domain.Entities;

public class InvoiceItem
{
    public int Id { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Subtotal { get; set; }
    public int InvoiceId { get; set; }
    public int? ProductId { get; set; }
        
    public Invoice Invoice { get; set; }
    public Product Product { get; set; }
}