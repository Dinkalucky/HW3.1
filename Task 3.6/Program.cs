using System;

namespace Task_3._6
{
    public class Address
    {
        public string country, city, street;
        public int index, house, apartment;
        public int Index
        {
            set { index = value; }
            get { return index; }
        }
        public string Country
        {
            set { country = value; }
            get { return country; }
        }
        public string City
        {
            set { city = value; }
            get { return city; }
        }
        public string Street
        {
            set { street = value; }
            get { return street; }
        }
        public int House
        {
            set { house = value; }
            get { return house; }
        }
        public int Apartment
        {
            set { apartment = value; }
            get { return apartment; }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = 96545;
            address.Country = "Ukraine";
            address.City = "Kyiv";
            address.Street = "Geroiv Dnipra";
            address.House = 43;
            address.Apartment = 88;

            Console.WriteLine($"My address: " +
                              $"\nIndex: {address.index}" +
                              $"\nCountry: {address.country}" +
                              $"\nCity: {address.city}" +
                              $"\nStreet: {address.street}" +
                              $"\nHouse: {address.house}" +
                              $"\nApartment: {address.apartment}");
            Console.Read();
        }
    }
}
