using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_22
{
    class PhoneOwner
    {
        // Свойства владельца
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        // Свойства адреса
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }

        public string PhoneNumber { get; set; }

        // Конструктор для инициализации объекта PhoneOwner
        public PhoneOwner(
            string lastName, string firstName, string middleName,
            string postalCode, string country, string region, string district,
            string city, string street, string house, string apartment,
            string phoneNumber)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            PostalCode = postalCode;
            Country = country;
            Region = region;
            District = district;
            City = city;
            Street = street;
            House = house;
            Apartment = apartment;
            PhoneNumber = phoneNumber;
        }
        // Метод для вывода информации о владельце
        public void PrintInfo()
        {
            Console.WriteLine($"ФИО: {LastName} {FirstName} {MiddleName}");
            Console.WriteLine($"Адрес: Почтовый индекс: {PostalCode}, Страна: {Country}, Область: {Region}, Район: {District}, Город: {City}, Улица: {Street}, Дом: {House}, Квартира: {Apartment}");
            Console.WriteLine($"Телефон: {PhoneNumber}");
            Console.WriteLine();
        }
    }
}
