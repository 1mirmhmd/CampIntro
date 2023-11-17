using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_OOP
{
    internal class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " updated");
        }
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }
        public void Add1(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }
    }
}
