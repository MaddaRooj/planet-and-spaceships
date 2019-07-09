using System;
using System.Collections.Generic;


namespace csharp_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.ForEach(planet => Console.WriteLine(planet));
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            Console.WriteLine("-----------------------Break--------------------------");
            planetList.ForEach(planet => Console.WriteLine(planet));
            Console.WriteLine("-----------------------Break--------------------------");
            List<string> planetListOuter = new List<string>(){"Uranus", "Neptune"};
            planetList.AddRange(planetListOuter);
            planetList.ForEach(planet => Console.WriteLine(planet));
            Console.WriteLine("-----------------------Break--------------------------");
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            planetList.ForEach(planet => Console.WriteLine(planet));
            Console.WriteLine("-----------------------Break--------------------------");
            List<string> rockyPlanets = planetList.GetRange(0, 4);
            rockyPlanets.ForEach(planet => Console.WriteLine(planet));
            Console.WriteLine("-----------------------Break--------------------------");
            planetList.Remove("Pluto");
            planetList.ForEach(planet => Console.WriteLine(planet));
        }
    }
}
