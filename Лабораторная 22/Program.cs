using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_22
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PhoneOwner> phoneOwners = new List<PhoneOwner>
            {
                new PhoneOwner("Иванов", "Иван", "Иванович", "123456", "Россия", "Московская", "Центральный", "Москва", "Тверская", "10", "5", "7201234567"),
                new PhoneOwner("Петров", "Петр", "Петрович", "654321", "Россия", "Ленинградская", "Василеостровский", "Санкт-Петербург", "Невский", "20", "10", "8123456789"),
                new PhoneOwner("Сидоров", "Сидор", "Сидорович", "789012", "Россия", "Новосибирская", "Октябрьский", "Новосибирск", "Красный проспект", "30", "15", "7209876543")
            };

            // Фильтрация и вывод владельцев, чей номер телефона начинается на 720
            var filteredOwners = phoneOwners.Where(owner => owner.PhoneNumber.StartsWith("720"));
            Console.WriteLine("Владельцы телефонов, номера которых начинаются на 720:");
            foreach (var owner in filteredOwners)
            {
                owner.PrintInfo();
            }

            Console.ReadKey();
        }
    }
    
}
