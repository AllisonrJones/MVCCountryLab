using System;
namespace MVCCountryLab
{
	public class CountryView
	{
        public Country Displaycountry { get; set; }

		public CountryView(Country _country)
		{
            Displaycountry = _country;
		}
        public void Display()
        {
            Console.WriteLine($"Name: {Displaycountry.Name}, Continent: {Displaycountry.Continent}, Country Colors: {String.Join("," , Displaycountry.Colors)}");
        }
	}
}


