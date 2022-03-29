namespace Products;

public class Products
{
    public static List<Product> ProductList { get; } =
        new List<Product>
        {
            new Product
            {
                ProductId = 1, ProductName = "Chai", Category = "Beverages", UnitPrice = 18.00M, InStock = 39
            },
            new Product
            {
                ProductId = 2, ProductName = "Chang", Category = "Beverages", UnitPrice = 19.00M, InStock = 17
            },
            new Product
            {
                ProductId = 3, ProductName = "Aniseed Syrup", Category = "Condiments", UnitPrice = 10.00M,
                InStock = 13
            },
            new Product
            {
                ProductId = 4, ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments",
                UnitPrice = 22.00M, InStock = 53
            },
            new Product
            {
                ProductId = 5, ProductName = "Chef Anton's Gumbo Mix", Category = "Condiments", UnitPrice = 21.35M,
                InStock = 0
            },
            new Product
            {
                ProductId = 6, ProductName = "Grandma's Boysenberry Spread", Category = "Condiments",
                UnitPrice = 25.00M, InStock = 120
            },
            new Product
            {
                ProductId = 7, ProductName = "Uncle Bob's Organic Dried Pears", Category = "Produce",
                UnitPrice = 30.00M, InStock = 15
            },
            new Product
            {
                ProductId = 8, ProductName = "Northwoods Cranberry Sauce", Category = "Condiments",
                UnitPrice = 40.00M, InStock = 6
            },
            new Product
            {
                ProductId = 9, ProductName = "Mishi Kobe Niku", Category = "Meat/Poultry", UnitPrice = 97.00M,
                InStock = 29
            },
            new Product
            {
                ProductId = 10, ProductName = "Ikura", Category = "Seafood", UnitPrice = 31.00M, InStock = 31
            },
            new Product
            {
                ProductId = 11, ProductName = "Queso Cabrales", Category = "Dairy Products", UnitPrice = 21.00M,
                InStock = 22
            },
            new Product
            {
                ProductId = 12, ProductName = "Queso Manchego La Pastora", Category = "Dairy Products",
                UnitPrice = 38.00M, InStock = 86
            },
            new Product
            {
                ProductId = 13, ProductName = "Konbu", Category = "Seafood", UnitPrice = 6.00M, InStock = 24
            },
            new Product
            {
                ProductId = 14, ProductName = "Tofu", Category = "Produce", UnitPrice = 23.25M, InStock = 35
            },
            new Product
            {
                ProductId = 15, ProductName = "Genen Shouyu", Category = "Condiments", UnitPrice = 15.50M,
                InStock = 39
            },
            new Product
            {
                ProductId = 16, ProductName = "Pavlova", Category = "Confections", UnitPrice = 17.45M,
                InStock = 29
            },
            new Product
            {
                ProductId = 17, ProductName = "Alice Mutton", Category = "Meat/Poultry", UnitPrice = 39.00M,
                InStock = 0
            },
            new Product
            {
                ProductId = 18, ProductName = "Carnarvon Tigers", Category = "Seafood", UnitPrice = 62.50M,
                InStock = 42
            },
            new Product
            {
                ProductId = 19, ProductName = "Teatime Chocolate Biscuits", Category = "Confections",
                UnitPrice = 9.20M, InStock = 25
            },
            new Product
            {
                ProductId = 20, ProductName = "Sir Rodney's Marmalade", Category = "Confections", UnitPrice = 81.00M,
                InStock = 40
            },
            new Product
            {
                ProductId = 21, ProductName = "Sir Rodney's Scones", Category = "Confections", UnitPrice = 10.00M,
                InStock = 3
            },
            new Product
            {
                ProductId = 22, ProductName = "Gustaf's Knäckebröd", Category = "Grains/Cereals", UnitPrice = 21.00M,
                InStock = 104
            },
            new Product
            {
                ProductId = 23, ProductName = "Tunnbröd", Category = "Grains/Cereals", UnitPrice = 9.00M,
                InStock = 61
            },
            new Product
            {
                ProductId = 24, ProductName = "Guaraná Fantástica", Category = "Beverages", UnitPrice = 4.50M,
                InStock = 20
            },
            new Product
            {
                ProductId = 25, ProductName = "NuNuCa Nuß-Nougat-Creme", Category = "Confections", UnitPrice = 14.00M,
                InStock = 76
            },
            new Product
            {
                ProductId = 26, ProductName = "Gumbär Gummibärchen", Category = "Confections", UnitPrice = 31.23M,
                InStock = 15
            },
            new Product
            {
                ProductId = 27, ProductName = "Schoggi Schokolade", Category = "Confections", UnitPrice = 43.90M,
                InStock = 49
            },
            new Product
            {
                ProductId = 28, ProductName = "Rössle Sauerkraut", Category = "Produce", UnitPrice = 45.60M,
                InStock = 26
            },
            new Product
            {
                ProductId = 29, ProductName = "Thüringer Rostbratwurst", Category = "Meat/Poultry",
                UnitPrice = 123.79M, InStock = 0
            },
            new Product
            {
                ProductId = 30, ProductName = "Nord-Ost Matjeshering", Category = "Seafood", UnitPrice = 25.89M,
                InStock = 10
            },
            new Product
            {
                ProductId = 31, ProductName = "Gorgonzola Telino", Category = "Dairy Products", UnitPrice = 12.50M,
                InStock = 0
            },
            new Product
            {
                ProductId = 32, ProductName = "Mascarpone Fabioli", Category = "Dairy Products", UnitPrice = 32.00M,
                InStock = 9
            },
            new Product
            {
                ProductId = 33, ProductName = "Geitost", Category = "Dairy Products", UnitPrice = 2.50M,
                InStock = 112
            },
            new Product
            {
                ProductId = 34, ProductName = "Sasquatch Ale", Category = "Beverages", UnitPrice = 14.00M,
                InStock = 111
            },
            new Product
            {
                ProductId = 35, ProductName = "Steeleye Stout", Category = "Beverages", UnitPrice = 18.00M,
                InStock = 20
            },
            new Product
            {
                ProductId = 36, ProductName = "Inlagd Sill", Category = "Seafood", UnitPrice = 19.00M,
                InStock = 112
            },
            new Product
            {
                ProductId = 37, ProductName = "Gravad lax", Category = "Seafood", UnitPrice = 26.00M,
                InStock = 11
            },
            new Product
            {
                ProductId = 38, ProductName = "Côte de Blaye", Category = "Beverages", UnitPrice = 263.50M,
                InStock = 17
            },
            new Product
            {
                ProductId = 39, ProductName = "Chartreuse verte", Category = "Beverages", UnitPrice = 18.00M,
                InStock = 69
            },
            new Product
            {
                ProductId = 40, ProductName = "Boston Crab Meat", Category = "Seafood", UnitPrice = 18.40M,
                InStock = 123
            },
            new Product
            {
                ProductId = 41, ProductName = "Jack's New England Clam Chowder", Category = "Seafood",
                UnitPrice = 9.65M, InStock = 85
            },
            new Product
            {
                ProductId = 42, ProductName = "Singaporean Hokkien Fried Mee", Category = "Grains/Cereals",
                UnitPrice = 14.00M, InStock = 26
            },
            new Product
            {
                ProductId = 43, ProductName = "Ipoh Coffee", Category = "Beverages", UnitPrice = 46.00M,
                InStock = 17
            },
            new Product
            {
                ProductId = 44, ProductName = "Gula Malacca", Category = "Condiments", UnitPrice = 19.45M,
                InStock = 27
            },
            new Product
            {
                ProductId = 45, ProductName = "Rogede sild", Category = "Seafood", UnitPrice = 9.50M, InStock = 5
            },
            new Product
            {
                ProductId = 46, ProductName = "Spegesild", Category = "Seafood", UnitPrice = 12.00M, InStock = 95
            },
            new Product
            {
                ProductId = 47, ProductName = "Zaanse koeken", Category = "Confections", UnitPrice = 9.50M,
                InStock = 36
            },
            new Product
            {
                ProductId = 48, ProductName = "Chocolade", Category = "Confections", UnitPrice = 12.75M,
                InStock = 15
            },
            new Product
            {
                ProductId = 49, ProductName = "Maxilaku", Category = "Confections", UnitPrice = 20.00M,
                InStock = 10
            },
            new Product
            {
                ProductId = 50, ProductName = "Valkoinen suklaa", Category = "Confections", UnitPrice = 16.25M,
                InStock = 65
            },
            new Product
            {
                ProductId = 51, ProductName = "Manjimup Dried Apples", Category = "Produce", UnitPrice = 53.00M,
                InStock = 20
            },
            new Product
            {
                ProductId = 52, ProductName = "Filo Mix", Category = "Grains/Cereals", UnitPrice = 7.00M,
                InStock = 38
            },
            new Product
            {
                ProductId = 53, ProductName = "Perth Pasties", Category = "Meat/Poultry", UnitPrice = 32.80M,
                InStock = 0
            },
            new Product
            {
                ProductId = 54, ProductName = "Tourtière", Category = "Meat/Poultry", UnitPrice = 7.45M,
                InStock = 21
            },
            new Product
            {
                ProductId = 55, ProductName = "Pâté chinois", Category = "Meat/Poultry", UnitPrice = 24.00M,
                InStock = 115
            },
            new Product
            {
                ProductId = 56, ProductName = "Gnocchi di nonna Alice", Category = "Grains/Cereals",
                UnitPrice = 38.00M, InStock = 21
            },
            new Product
            {
                ProductId = 57, ProductName = "Ravioli Angelo", Category = "Grains/Cereals", UnitPrice = 19.50M,
                InStock = 36
            },
            new Product
            {
                ProductId = 58, ProductName = "Escargots de Bourgogne", Category = "Seafood", UnitPrice = 13.25M,
                InStock = 62
            },
            new Product
            {
                ProductId = 59, ProductName = "Raclette Courdavault", Category = "Dairy Products", UnitPrice = 55.00M,
                InStock = 79
            },
            new Product
            {
                ProductId = 60, ProductName = "Camembert Pierrot", Category = "Dairy Products", UnitPrice = 34.00M,
                InStock = 19
            },
            new Product
            {
                ProductId = 61, ProductName = "Sirop d'érable", Category = "Condiments", UnitPrice = 28.50M,
                InStock = 113
            },
            new Product
            {
                ProductId = 62, ProductName = "Tarte au sucre", Category = "Confections", UnitPrice = 49.30M,
                InStock = 17
            },
            new Product
            {
                ProductId = 63, ProductName = "Vegie-spread", Category = "Condiments", UnitPrice = 43.90M,
                InStock = 24
            },
            new Product
            {
                ProductId = 64, ProductName = "Wimmers gute Semmelknödel", Category = "Grains/Cereals",
                UnitPrice = 33.25M, InStock = 22
            },
            new Product
            {
                ProductId = 65, ProductName = "Louisiana Fiery Hot Pepper Sauce", Category = "Condiments",
                UnitPrice = 21.05M, InStock = 76
            },
            new Product
            {
                ProductId = 66, ProductName = "Louisiana Hot Spiced Okra", Category = "Condiments",
                UnitPrice = 17.00M, InStock = 4
            },
            new Product
            {
                ProductId = 67, ProductName = "Laughing Lumberjack Lager", Category = "Beverages", UnitPrice = 14.00M,
                InStock = 52
            },
            new Product
            {
                ProductId = 68, ProductName = "Scottish Longbreads", Category = "Confections", UnitPrice = 12.50M,
                InStock = 6
            },
            new Product
            {
                ProductId = 69, ProductName = "Gudbrandsdalsost", Category = "Dairy Products", UnitPrice = 36.00M,
                InStock = 26
            },
            new Product
            {
                ProductId = 70, ProductName = "Outback Lager", Category = "Beverages", UnitPrice = 15.00M,
                InStock = 15
            },
            new Product
            {
                ProductId = 71, ProductName = "Flotemysost", Category = "Dairy Products", UnitPrice = 21.50M,
                InStock = 26
            },
            new Product
            {
                ProductId = 72, ProductName = "Mozzarella di Giovanni", Category = "Dairy Products",
                UnitPrice = 34.80M, InStock = 14
            },
            new Product
            {
                ProductId = 73, ProductName = "Röd Kaviar", Category = "Seafood", UnitPrice = 15.00M,
                InStock = 101
            },
            new Product
            {
                ProductId = 74, ProductName = "Longlife Tofu", Category = "Produce", UnitPrice = 10.00M,
                InStock = 4
            },
            new Product
            {
                ProductId = 75, ProductName = "Rhönbräu Klosterbier", Category = "Beverages", UnitPrice = 7.75M,
                InStock = 125
            },
            new Product
            {
                ProductId = 76, ProductName = "Lakkalikööri", Category = "Beverages", UnitPrice = 18.00M,
                InStock = 57
            },
            new Product
            {
                ProductId = 77, ProductName = "Original Frankfurter grüne Soße", Category = "Condiments",
                UnitPrice = 13.00M, InStock = 32
            }
        };
}
