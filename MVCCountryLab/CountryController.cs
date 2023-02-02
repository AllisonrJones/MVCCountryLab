using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using MVCCountryLab;

namespace MVCCountryLab
{
	public class CountryController
	{
		List<Country>CountryDb { get; set; }

		public CountryController()
		{

            CountryDb = new List<Country>
            {
               new Country("United States of America", "North America",new List<string> {"Red,White,Blue"}),
               new Country("Turkey", "Both Europe and Asia",new List<string> {"Red,White"}),
               new Country("Egypt", "Both Africa and Asia",new List<string> {"Black,White,Red,Gold"}),
               new Country("Brazil", "South America",new List<string> {"Green,Yellow,Blue"}),
               new Country("New Zealand", "Australia",new List<string> {"Red,White,Blue"})
            };
  }
            public void CountryAction(Country c)
            {
            CountryView landmass = new CountryView(c);


            landmass.Display();
            }
        public void WelcomeAction()
        {
            CountryListView Db = new CountryListView(CountryDb);
            Console.WriteLine("Hello, welcome to the country app.Please select a country from the following list:");
         
            Db.Display();
         int choice = int.Parse(Console.ReadLine());  

         Country C = CountryDb[choice];
            CountryAction(C);
          

        }
       
	}
}

//Get index from user,
//Grab country from list using index
//pass country into CountryAction method

//        public void WelcomeAction()
//        {
//            foreach (Item i in itemDB)
//            {
//                ItemAction(i);
//            }
//        }



//using MVCLecture;

//ItemController controller = new ItemController();
//controller.WelcomeAction();

////

//using System;
//namespace MVCLecture
//{
//    public class ItemController
//    {
//        //pretend this is a database
//        List<Item> itemDB = new List<Item>()
//        {
//            new Item("Monitor", 100.00m),
//            new Item("Keyboard", 65.99m),
//            new Item("Mouse", 40.99m),
//            new Item("Headset", 199.99m),
//        };

//        public void ItemAction(Item i)
//        {
//            ItemView view = new ItemView(i);
//            view.Display();
//        }
//        public void WelcomeAction()
//        {
//            foreach (Item i in itemDB)
//            {
//                ItemAction(i);
//            }
//        }
//    }
//}
