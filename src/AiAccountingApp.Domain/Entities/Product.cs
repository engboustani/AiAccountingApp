namespace AiAccountingApp.Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string SKU { get; set; }
    public decimal Price { get; set; }
    public bool IsActive { get; set; } = true;
    public int CompanyId { get; set; }
        
    public Company Company { get; set; }
}