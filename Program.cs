using System;
using System.Collections.Generic;


namespace csharp_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 1: ");
            // Add Jupiter and Saturn to the planetList
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            planetList.ForEach(planet => Console.WriteLine(planet));
            Console.WriteLine("Problem 2 - 3: ");
            // Combine planetList and planetListOuter
            List<string> planetListOuter = new List<string>(){"Uranus", "Neptune"};
            planetList.AddRange(planetListOuter);
            planetList.ForEach(planet => Console.WriteLine(planet));
            Console.WriteLine("Problem 4 - 5: ");
            // Add Venus, Earth, and Pluto to the planetList
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            planetList.ForEach(planet => Console.WriteLine(planet));
            Console.WriteLine("Problem 6: ");
            // create a new list that contains the rocky planets from planetList
            List<string> rockyPlanets = planetList.GetRange(0, 4);
            rockyPlanets.ForEach(planet => Console.WriteLine(planet));
            Console.WriteLine("Problem 7: ");
            // Remove pluto from the list
            planetList.Remove("Pluto");
            planetList.ForEach(planet => Console.WriteLine(planet));
        }
    }
}
