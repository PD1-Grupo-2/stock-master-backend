namespace StockMaster.Domain.Entities;

public class Supplier
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Contact { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Cnpj { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public ICollection<Product> Products { get; set; } = [];
}

