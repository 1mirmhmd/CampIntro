namespace _07_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.CategoryId = 1;
            product.ProductName = "Table";
            product.UnitPrice = 10;
            product.UnitsInStock = 10;

            Product product1 = new Product() { Id = 2, CategoryId = 2, 
                ProductName = "Mouse", UnitPrice = 5, UnitsInStock = 23 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product);
            Console.WriteLine(product.ProductName);

            int result = productManager.Add(5,6);
            Console.WriteLine(result*5);
            productManager.Add1(5,2);

        }
    }
}
