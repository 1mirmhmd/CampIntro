namespace _09_GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> cities = new MyList<string>();
            cities.Add("Mecca");
            cities.Add("Medina");
            cities.Add("Aksa");
            cities.Add("Sham");
            Console.WriteLine(cities.Count);

            MyListSec<string> cities1 = new MyListSec<string>();
            cities1.Add("Bukhara");
            cities1.Add("Samarkand");
            cities1.Add("Baghdad");
            cities1.Add("Nishapur");
            cities1.Add("Islamabad");
            Console.WriteLine(cities1.Count);


        }
    }
}