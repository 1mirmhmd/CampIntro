using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_OOP2
{
    internal class Corporate:Customer // Miras -> Inheritance
    {
        public string CompanyName { get; set; }

        // Matematiksel işlem yapılmayan özellikler sayısal değil metinsel veri türü kullanılır!
        public string TaxNo { get; set; }
    }
}
