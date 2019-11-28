namespace Pluralsight.BegCShCollections.ReadAllCountries
{
    public class Country
    {
        public Country(string name, string code, string region, int population)
        {
            Name = name;
            Code = code;
            Region = region;
            Population = population;
        }

        public string Name;
        public string Code;
        public string Region;
        public int Population;
    }
}