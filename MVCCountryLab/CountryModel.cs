using System;
namespace MVCCountryLab
{
	public class Country
	{
		public string Name { get; set; }
		public string Continent { get; set; }
		public List<string> Colors { get; set; }

        public Country(string _name, string _continent, List<string>_color)
        {
            Name = _name;
            Continent = _continent;
            Colors = _color;
        }
	}
}


