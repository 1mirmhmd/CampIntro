using System.Security.Claims;
using System.Xml.Linq;

namespace _06_ValueAndReferenceType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value Type  : bool byte char decimal double enum float int long sbyte short struct uint ulong ushort
            // Reference Type : String Arrays(even if their elements are value types) Class Delegate

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] 999
    }
    }
}
