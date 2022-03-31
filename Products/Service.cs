namespace Products;

public class Service
{
  private readonly List<Product> _products;

  public Service(List<Product> products)
  {
    _products = products;
  }

  public Dictionary<string, decimal> GetAveragePriceByCategory()
  {
    var avgPriceByCategory = from product in _products
      group product by product.Category
      into g
      select new {Category = g.Key, AveragePrice = g.Average(p => p.UnitPrice)};

    return avgPriceByCategory.ToDictionary(k => k.Category, v => v.AveragePrice);
  }

  public int[] GetOutOfStockItems()
  {
    var outOfStockItems = from product in _products
      where product.InStock == 0
      select product.ProductId;

    return outOfStockItems.ToArray();
  }
}
