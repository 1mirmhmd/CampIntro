namespace _09_GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cars = new List<string>();
            cars.Add("BMW");
            cars.Add("Mercedes");
            cars.Add("");
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

        }
    }
}