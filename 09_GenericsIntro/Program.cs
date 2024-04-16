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


            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            keyValuePairs.Add("Ali", 1995);
            foreach (var item in keyValuePairs)
            {
                Console.WriteLine(item);
            }

            MyDictionary<string,string> nameSurname = new MyDictionary<string, string> ();
            nameSurname.Add("Aziz", "Kulu");
            foreach (var name in nameSurname.Keys)
            {
                Console.WriteLine("Name is : "+name);
            }
            nameSurname.Add("Güler", "Sundu");

           




        }
    }
}