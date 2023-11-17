using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class MortgageManager : ICreditManager
    {
        public void Calc()
        {
            Console.WriteLine("Payment Plan of Mortgage calculated");
        }
    }
}
