using Pluralsight.BegCShCollections.DictSnippets;
using System;
using System.Collections.Generic;

namespace PluralSight.BegCShCollections.DictSnippets
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string filePath = @"C:\Users\e.alencar.santos\Desktop\training [dotNET (Csharp)]\Beginning Csharp Collections\csharp-collections-beginning\Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);

            Dictionary<string, Country> countries = reader.ReadAllCountries();

            Console.WriteLine("Which country code do you want to look up? ");
            string userInput = Console.ReadLine();

            bool gotCountry = countries.TryGetValue(userInput, out Country country);
            if (!gotCountry)
                Console.WriteLine($"Sorry, there is no country with code, {userInput} ");
            else
                Console.WriteLine($"{country.Name} has population {PopulationFormatter.FormatPopulation(country.Population)}");

            //Country norway = new Country("Norway", "NOR", "Europe", 5282223);
            //Country finland = new Country("Finland", "FIN", "Europe", 5511303);

            //var countries = new Dictionary<string, Country>
            //{
            //    { norway.Code, norway },
            //    { finland.Code, finland }
            //};
            ////countries.Add(norway.Code, norway);
            ////countries.Add(finland.Code, finland);

            ////Console.WriteLine(countries["MUS"].Name);
            //bool exists = countries.TryGetValue("MUS", out Country country);
            //if (exists)
            //    Console.WriteLine(country.Name);
            //else
            //    Console.WriteLine($"There is no code with the code MUS");

            ////foreach (var country in countries.Values)
            ////    Console.WriteLine(country.Name);
        }
    }
}