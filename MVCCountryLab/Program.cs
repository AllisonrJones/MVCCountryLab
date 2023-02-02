using MVCCountryLab;

bool runprogram = true;
while (true)
{
CountryController controller = new CountryController();
controller.WelcomeAction();
    Console.WriteLine("Would you like to learn about another country?");
    string response = Console.ReadLine();
    if (response == "yes")
    {
        runprogram= true;
    }
    else
    {
       runprogram= false;
    }
}
