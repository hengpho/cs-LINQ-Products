using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using Products;

namespace ProductsTests;

public class Tests
{
  private Service _service;

  // The SetUp method is called before each test method.
  [SetUp]
  public void Setup()
  {
    var products = new List<Product>
    {
      new()
      {
        ProductId = 1,
        ProductName = "Chai",
        Category = "Beverages",
        UnitPrice = 18.00M,
        InStock = 20
      },
      new()
      {
        ProductId = 2,
        ProductName = "Chang",
        Category = "Beverages",
        UnitPrice = 19.00M,
        InStock = 10
      },
      new()
      {
        ProductId = 3,
        ProductName = "Aniseed Syrup",
        Category = "Condiments",
        UnitPrice = 10.00M,
        InStock = 30
      },
      new()
      {
        ProductId = 4,
        ProductName = "Chef Anton's Cajun Seasoning",
        Category = "Condiments",
        UnitPrice = 22.00M,
        InStock = 0
      },
      new()
      {
        ProductId = 5,
        ProductName = "Uncle Bob's Organic Dried Pears",
        Category = "Produce",
        UnitPrice = 20M,
        InStock = 10
      },
      new()
      {
        ProductId = 6,
        ProductName = "Uncle Bob's Organic Dried Peaches",
        Category = "Produce",
        UnitPrice = 30M,
        InStock = 0
      }
    };

    // Inject the list of products into the Service.
    _service = new Service(products);
  }

  [Test]
  // Get out of stock items
  public void GetOutOfStockItems_ReturnsIdsOfOutOfStockItems()
  {
    // Arrange
    // Get back a list of the product ids
    int[] expected = {4, 6};

    // Act
    // Call the method
    var actual = _service.GetOutOfStockItems();

    // Assert
    // Make sure the expected and actual are equal
    Assert.AreEqual(expected, actual);
  }

  [Test]
  // Get Average Price By Category
  public void GetAveragePriceByCategory_ReturnsAveragePriceByCategory()
  {
    // Arrange
    // Get back a Dictionary ot the category and average price
    var expected = new Dictionary<string, decimal> {{"Beverages", 18.50M}, {"Condiments", 16.00M}, {"Produce", 25.00M}};

    // Act
    // Call the method
    var actual = _service.GetAveragePriceByCategory();

    // Assert
    // Make sure the expected and actual are equal
    Assert.AreEqual(expected, actual);
  }

  [Test]
  // Get the top 3 most expensive items
  public void GetTop3MostExpensiveInStockItems_ReturnsTop3MostExpensiveInStockItems()
  {
    List<Product> expected = new List<Product>()
    {
      new()
      {
        ProductId = 5,
        ProductName = "Uncle Bob's Organic Dried Pears",
        Category = "Produce",
        UnitPrice = 20M,
        InStock = 10
      },
      new()
      {
        ProductId = 2,
        ProductName = "Chang",
        Category = "Beverages",
        UnitPrice = 19.00M,
        InStock = 10
      },
      new()
      {
        ProductId = 1,
        ProductName = "Chai",
        Category = "Beverages",
        UnitPrice = 18.00M,
        InStock = 20
      }
    };

    IEnumerable<Product> actual = _service.GetTop3MostExpensiveInStockItems();
    IComparer comparer = new ProductComparer();
    CollectionAssert.AreEqual(expected, actual, comparer);
  }
}
