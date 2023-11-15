namespace _04_Methods
{
    // Dont Repeat Yourself - DRY - Clean Code - Best Practice
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product0 = new Product();
            product0.Name = "Apple";
            product0.Price = 15;
            product0.Description = "Apple of Amasya";

            Product product1 = new Product();
            product1.Name = "Watermelon";
            product1.Price = 20;
            product1.Description = "Watermelon of Diyarbakır";

            Product[] products = new Product[] { product0, product1 };

            // Type Safe -> Tip Güvenli
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("-----------");
            }
            Console.WriteLine("---------- Methods ----------");

            // Instance -> Örnek
            BasketManager basketManager = new BasketManager();
            basketManager.Add(product0);
            basketManager.Add(product1);

            BasketManager basketManager1 = new BasketManager();
            basketManager1.Add1("Lemon", "Yellow Lemon", 23, 15);
            basketManager1.Add1("Strawberry", "Juicy Strawberry", 45, 24);
        }
    }
}
