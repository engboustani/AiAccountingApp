namespace AiAccountingApp.Domain.Entities;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ContactName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public bool IsActive { get; set; } = true;
    public int CompanyId { get; set; }
        
    public Company Company { get; set; }
    public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
}