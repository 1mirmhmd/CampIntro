namespace _01_CampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Type safety - Tip Güvenliği
            // Don't repeat yourself
            // değer tutucu / alias - takma ad
            int numberOfstudent = 320000000;
            string kategori = "Kategori";
            double percentage = 1.45;
            bool isLogged = true;
            double dollary_day = 7.35;
            double dollart_day = 7.55;

            if (dollart_day > dollary_day)
            {
                Console.WriteLine("Increase button");
            }
            else if (dollary_day > dollart_day)
            {
                Console.WriteLine("Decrease button");
            }
            else
            {
                Console.WriteLine("Equivalent");
            }
            if (isLogged == true)
            {
                Console.WriteLine("Button of users");
            }
            else
            {
                Console.WriteLine("Log in button");
            }
        }
    }
}
