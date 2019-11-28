using Pluralsight.BegCShCollections.IntroColls.TopTenPops;
using System;

namespace PluralSight.BegCShCollections.TopTenPops
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //    string[] strings = new string[5];
            //    char[] chars = new char[5];
            //    int[] ints = new int[5];
            //    string string2;
            //    char char2;
            //    int int2;
            //    int teressa;

            string filePath = @"C:\...\Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);

            Country[] countries = reader.ReadFirstNCountries(10);

            foreach (Country country in countries)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
        }
    }
}