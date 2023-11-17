using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class VehicleCreditManager : ICreditManager
    {
        public void Calc()
        {
            Console.WriteLine("Payment Plan of Vehicle Credit calculated");
        }
    }
}
