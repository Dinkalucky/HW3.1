using System;

namespace Task_3._6
{
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
