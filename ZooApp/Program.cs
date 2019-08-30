using System;

namespace ZooApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string zooName = "Test Zoo";
            Console.WriteLine("Test will output true if passed : false if failed");
            Console.WriteLine("Test : 1");
            var zoo = new Zoo(zooName);
            Console.WriteLine($"Location is correct test : {zoo.Location == zooName}");
            Console.WriteLine($"IsOpen is correct test : {zoo.IsOpen}");
            Console.WriteLine($"OpenZoo when open test : {zoo.OpenZoo()}");

            Console.WriteLine("Test : 2");
            var zoo2 = new Zoo(zooName);
            zoo2.IsOpen = false;
            Console.WriteLine($"Open Zoo when not open test : {!zoo2.OpenZoo()}");

            Console.WriteLine("Test : 3");
            var zoo3 = new Zoo(zooName);
            zoo3.Animals = new System.Collections.Generic.List<Animal>();
            Console.WriteLine($"Open Zoo when no animals test : {!zoo3.OpenZoo()}");
            Console.ReadKey();
        }
    }
}
