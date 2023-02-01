using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AdressBok
{
    internal class ContactService
    {
        static public Contact CreateContact()
        {
            Console.Clear();

            Console.Write("First name: ");
            var firstName = Console.ReadLine();

            Console.Write("Last name: ");
            var lastName = Console.ReadLine();

            Console.Write("City: ");
            var city = Console.ReadLine();

            Console.Write("Address: ");
            var address = Console.ReadLine();

            Console.Write("PostCode: ");
            var postCode = Console.ReadLine();

            Console.Write("EmailAdress: ");
            var emailAdress = Console.ReadLine();

            Console.Write("PhoneNumber: ");
            var phoneNumber = Console.ReadLine();


            var contact = new Contact
            {
                FirstName = firstName,
                LastName = lastName,
                City = city,
                Address = address,
                PostCode = postCode,
                EmailAdress = emailAdress,
                PhoneNumber = phoneNumber,
            };

            JsonService.ConvertContactToJson( contact );
            return null;



        }







        public static string RemoveContact(int amount)
        {
            Console.Clear();

            Console.WriteLine("Here can you remove contacts");
            Console.ReadLine();
            return null;

        }

    }
}

