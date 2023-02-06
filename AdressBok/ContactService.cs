using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using System.Text.Json;
using System.Runtime.CompilerServices;
using System.Data;

namespace AdressBok
{
    public class ContactService
    {
        

        public static List<Contact> ContactList { get; set; } = new List<Contact>();

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

            JsonService.ConvertContactToJson(contact);
            return null;



        }







        public static void RemoveContact()
        {
            Console.Clear();


            ViewContactService.ViewAllContacts();

            Console.WriteLine("Choose a contact to remove by number.");
            int chosenIndex = int.Parse(Console.ReadLine());
            chosenIndex = chosenIndex - 1;

            string urlJson = @".\JsonSaveFile.Json";

            if (File.Exists(urlJson))
            {

                string oldContactsText = File.ReadAllText(urlJson);
                Contact[] oldContacts = JsonSerializer.Deserialize<Contact[]>(oldContactsText);
                Contact contactToDelete = oldContacts[chosenIndex];
                Console.WriteLine($"Are you sure you want to delete {contactToDelete.FirstName} {contactToDelete.LastName}?   Y/N");
                char awnser = Console.ReadKey().KeyChar;

                if (awnser == 'Y' || awnser == 'y')
                {

                    List<Contact> newContacts = oldContacts.ToList();
                    newContacts.Remove(contactToDelete);

                    string Onelesscontact = JsonSerializer.Serialize(newContacts);
                    File.WriteAllText(urlJson, Onelesscontact);


                    Console.Clear();
                    Console.WriteLine($"{contactToDelete.FirstName} has been permanently deleted from you contacts.");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("No contact has been deleted, press any key to return to main manu.");
                    Console.ReadKey();
                }

            }
            else
            {
                Console.WriteLine("An error has happened, press any key to go back to main menu...");
                Console.ReadKey();

            }

        }

    }
}

