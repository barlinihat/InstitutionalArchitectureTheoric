using System;

namespace LinqInformation // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Computer"},
                new Category{CategoryId=2, CategoryName="Phone"}
            };

            categories.

            List<Product> products = new List<Product> {
            new Product{ProductId=1, CategoryId=1, ProductName="Apple Notebook", QuantityPerUnit="4 GB Ram", UnitPrice=10000, UnitsInStock=5},
            new Product{ProductId=2, CategoryId=1, ProductName="Hp Notebook", QuantityPerUnit="16 GB Ram", UnitPrice=8000, UnitsInStock=3},
            new Product{ProductId=3, CategoryId=1, ProductName="Lenovo Notebook", QuantityPerUnit="8 GB Ram", UnitPrice=6000, UnitsInStock=2},
            new Product{ProductId=4, CategoryId=2, ProductName="Samsung Phone", QuantityPerUnit="4 GB Ram", UnitPrice=5000, UnitsInStock=15},
            new Product{ProductId=5, CategoryId=2, ProductName="Xiaomi Phone", QuantityPerUnit="4 GB Ram", UnitPrice=8000, UnitsInStock=0}
            };
        }

        //static List<Product> GetProducts()
        //{

        //}
    }
}





class Product
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public string QuantityPerUnit { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }

}

class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}
