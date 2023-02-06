using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AdressBok
{
    public class ViewContactService
    {
        public static void ViewAllContacts()
        {
            Console.Clear();

            string urlJson = @".\JsonSaveFile.Json";


            if (File.Exists(urlJson))
            {
                string viewContacts = File.ReadAllText(urlJson);
                if (string.IsNullOrEmpty(viewContacts))
                {
                    Console.WriteLine("There are no contacts in your contactlist.(Lonly much?)");

                }
                else
                {

                    Contact[] contactsList = JsonSerializer.Deserialize<Contact[]>(viewContacts);
                    int counter = 1;

                    foreach (Contact contact in contactsList)
                    {
                        Console.WriteLine($"{counter} Contact: \r\nFirstname: {contact.FirstName} Lastname: {contact.LastName} Email: {contact.EmailAdress}");
                        counter = counter + 1;
                    }


                }
               
            }
        }



        public static void ViewSpecificContact()
        {
            Console.Clear();

            string urlJson = @".\JsonSaveFile.Json";


            if (File.Exists(urlJson))
            {
                string viewFirstContacts = File.ReadAllText(urlJson);
                if (string.IsNullOrEmpty(viewFirstContacts))
                {
                    Console.WriteLine("There are no contacts in your contactlist.(Lonly much?)");

                }
                else
                {

                    List<Contact> allContact = JsonSerializer.Deserialize<List<Contact>>(viewFirstContacts);



                    Contact contact = allContact.First();


                    Console.WriteLine($"Contact \r\nFirstname: {contact.FirstName} \r\nLastName: {contact.LastName} \r\nEmail: {contact.EmailAdress} \r\nPhonenumber: {contact.PhoneNumber} \r\nAddress: {contact.Address} \r\nClick any button to go back to menu");

                    Console.ReadKey();


                }
            }
            
        }
    }
}
