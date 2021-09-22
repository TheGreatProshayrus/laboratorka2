using System;

namespace Laboratorka2
{
    class Address

    {

        public string index; // индекс

        public string country;     // Страна

        public string city;     // город

        public string street;     // улица

        public int house;     //номер улицы

        public int apartment;     // квартира

        public void GetInfo()

        {

            Console.WriteLine($"index: {index} \ncountry: {country} \ncity: {city} \nstreet: {street} \nhouse: {house} \napartment: {apartment}");

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            Address home = new Address();

            home.index = "09100";

            home.country = "Ukraine";

            home.city = "Bila Tserkva";

            home.street = "Vasilya Stusa";

            home.house = 44;

            home.apartment = 92;

            home.GetInfo();  

            Console.ReadKey();

        }

    }
}
