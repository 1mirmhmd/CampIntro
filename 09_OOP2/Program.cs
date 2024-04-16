namespace _09_OOP2
{
    // Bug free - hatadan hali
    internal class Program
    {
        static void Main(string[] args)
        {
            Individual customer = new Individual();
            customer.Id = 1;
            customer.CustomerNo = "124124";
            customer.FirstName = "Ali";
            customer.LastName = "Mor";
            customer.TcNo = "121231";
            
            Corporate customer1 = new Corporate();
            customer1.Id = 2;
            customer1.CompanyName = "Company";
            customer1.CustomerNo = "123124124";
            customer1.TaxNo = "124235235";

            // Eğer bir base sınıf varsa, o sınıf referans tutucudur
            Customer customer2 = new Individual();
            Customer customer3 = new Corporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer2);
            customerManager.Add(customer3);
        }
    }
}
