namespace _08_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] {"Aziz","Nuri","İhsan","Kamil"};
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);

            List<string> names1= new List<string>() { "Aziz", "Nuri", "İhsan", "Kamil" };
            //List<string> names1 = new List<string>();
            Console.WriteLine(names1[0]);
            Console.WriteLine(names1[1]);
            Console.WriteLine(names1[2]);
            Console.WriteLine(names1[3]);
            names1.Add("Numan");
            Console.WriteLine(names1[4]);
            Console.WriteLine(names1[0]);


        }
    }
}
