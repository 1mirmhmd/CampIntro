using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Methods
{
    internal class BasketManager
    {
        // Naming Convention
        public void Add(Product product)
        {
            Console.WriteLine("Congratulation! Products have added to basket : " + product.Name);
        }
        public void Add1(string Name, string Descr, double Price, int UnitInStock)
        {
            Console.WriteLine("Congratulation! Products have added to basket : " + Name);
        }
    }
}
