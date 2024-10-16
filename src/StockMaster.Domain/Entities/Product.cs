namespace StockMaster.Domain.Entities;

public class Product
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Barcode { get; set; } = string.Empty;
    public int StockQuantity { get; set; }
    public decimal PurchasePrice { get; set; }
    public decimal SalePrice { get; set; }
    public DateTime? ExpiryDate { get; set; }
    

    public long CategoryId { get; set; }
    public required Category Category { get; set; }
    public long SupplierId { get; set; }
    public required Supplier Supplier { get; set; }
}

