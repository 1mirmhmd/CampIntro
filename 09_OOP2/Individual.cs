using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_OOP2
{
    internal class Individual:Customer
    {
        public int Id { get; set; }
        public string CustomerNo { get; set; }
        // Matematiksel işlem yapılmayan özellikler sayısal değil metinsel veri türü kullanılır!
        public string TcNo { get; set; }


        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
