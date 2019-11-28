using System;
using System.Collections.Generic;
using System.Linq;

namespace Pluralsight.BegCShCollections.ReadAllCountries
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string filePath = @"C:\...\Pop by Largest Final.csv";

            CsvReader reader = new CsvReader(filePath);

            List<Country> countries = reader.ReadAllCountries();
            Country lilliput = new Country("Lilliput", "LIL", "Somewhere", 2_000_000);
            int lilliputIndex = countries.FindIndex(x => x.Population < 2_000_000);
            countries.Insert(lilliputIndex, lilliput);
            countries.RemoveAt(lilliputIndex);

            //foreach (Country country in countries)
            //foreach (Country country in countries.Take(10))
            //foreach (Country country in countries.OrderBy(x=>x.Name).Take(1000))
            //foreach (Country country in countries.Where(x => !x.Name.Contains(',')).Take(20))

            var filteredCountries = countries.Where(x => !x.Name.Contains(',')); //.Take(20);
            var filteredCountries2 = from country in countries
                                     where !country.Name.Contains(',')
                                     select country;
            foreach (Country country in filteredCountries2)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
            for (int i = 12; i <= 14; i++)
            {
                Console.WriteLine($"index: {i}: {countries[i].Name}");
            }

            Console.WriteLine($"{countries.Count} countries");
        }
    }
}