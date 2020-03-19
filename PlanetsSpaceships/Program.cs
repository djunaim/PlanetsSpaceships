using System;
using System.Collections.Generic;

namespace PlanetsSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            var lastTwo = new List<string> { "Uranus", "Neptune" };
            planetList.AddRange(lastTwo);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");

            foreach (var planet in planetList)
            {
                Console.WriteLine(planet);
            }

            // rocky planets
            List<string> rockyPlanets = planetList.GetRange(0, 4);
            foreach (var rockyPlanet in rockyPlanets)
            {
                Console.WriteLine($"this is rocky: {rockyPlanet}");
            }

            // no more pluto
            planetList.Remove("Pluto");
            foreach (var planet in planetList)
            {
                Console.WriteLine($"no more pluto {planet}");
            }

            // spacecraft
            var spacecrafts = new Dictionary<string, string>();
            spacecrafts.Add("Mercury", "Curiosity, Poo, Doo doo");
            spacecrafts.Add("Venus", "Curiosity, Super, Mindful");
            spacecrafts.Add("Earth", "Adventure, X220");
            spacecrafts.Add("Mars", "Rover, Kennedy, Lincoln, Bao");
            spacecrafts.Add("Jupiter", "Nike");
            spacecrafts.Add("Saturn", "Mildred, Sandy, Poo");
            spacecrafts.Add("Uranus", "Rover, Curiosity");
            spacecrafts.Add("Neptune", "Vain, Xray");

            foreach (var planet in planetList)
            {
                if (spacecrafts.ContainsKey(planet))
                {
                    Console.WriteLine($"{planet}: {spacecrafts[planet]}");
                }
            }

        }
    }
}
