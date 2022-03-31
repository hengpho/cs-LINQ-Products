using System.Collections;

namespace Products;

public class ProductComparer : IComparer
{
  public int Compare(Object x, Object y)
  {
    Product p1 = (Product)x;
    Product p2 = (Product)y;

    if (p1.ProductId == p2.ProductId) return 0;
    else if (p1.ProductId > p2.ProductId) return 1;
    else return -1;
  }
}
