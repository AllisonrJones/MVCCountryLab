using System;
using System.Drawing;
using System.Xml.Linq;

namespace MVCCountryLab
{
	public class CountryListView
	{
        public List<Country> Countries { get; set; }

        public CountryListView(List<Country> countryValue)
        {
            Countries = countryValue;
        }
		public void Display()
		{
            int counter = 0;
            foreach(Country D in Countries)
            {
                Console.WriteLine($"{counter}: {D.Name}");
                counter++;
            }
		}
	}
}

