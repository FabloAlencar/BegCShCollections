﻿using System;
using System.Collections.Generic;

namespace PluralSight.BegCShCollections.ReadCountriesForLoop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string filePath = @"C:\...\Pop by Largest Final.csv";

            CsvReader reader = new CsvReader(filePath);

            List<Country> countries = reader.ReadAllCountries();
            reader.RemoveCommaCountries(countries);

            Console.Write("Enter no. of countries to display> ");
            bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);
            if (!inputIsInt || userInput <= 0)
            {
                Console.Write("You must type in a +ve integer. Exiting");
                return;
            }

            //int maxToDisplay = Math.Min(userInput,countries.Count);
            //foreach (Country country in countries)
            //for (int i = 0; i < countries.Count; i++)
            int maxToDisplay = userInput;
            for (int i = countries.Count - 1; i >= 0; i--)
            {
                //if (i > 0 && (i % maxToDisplay == 0))
                int displayIndex = countries.Count - 1 - i;
                if (displayIndex
                    > 0 && (displayIndex % maxToDisplay == 0))
                {
                    Console.Write("Hit return to continue, anything else to quit> ");
                    if (Console.ReadLine() != "")
                        break;
                }

                Country country = countries[i];
                Console.WriteLine($"{displayIndex + 1}: {PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
                // Console.WriteLine($"{i+1}: {PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
        }
    }
}