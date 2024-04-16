using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class MortgageManager : ICreditManager
    {
        // Implemented Operation : Tanımlanmış/İçi doldurulmuş operasyon
        // Class'lar başka class'ları inherits eder. Interfaceleri ise implemente ederler.
        public void Calc()
        {
            Console.WriteLine("Payment Plan of Mortgage calculated");
        }
    }
}
