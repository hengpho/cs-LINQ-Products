namespace Products;

public class Product
{
    public int ProductId { get; init; }
    public string? ProductName { get; init; }
    public string? Category { get; init; }
    public decimal UnitPrice { get; init; }
    public int InStock { get; init; }

    public override string ToString() =>
        $"ProductID={ProductId} ProductName={ProductName} Category={Category} UnitPrice={UnitPrice:C2} " +
        $"UnitsInStock={InStock}";

    // TODO: Could override Equals and GetHashCode to make this class immutable
}
