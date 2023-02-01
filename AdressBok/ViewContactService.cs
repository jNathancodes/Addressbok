using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AdressBok
{
    internal class ViewContactService
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

                    List<Contact> contactsList = JsonSerializer.Deserialize<List<Contact>>(viewContacts);

                    foreach (Contact contact in contactsList)
                    {
                        Console.WriteLine($"Contact: {contact.FirstName} {contact.LastName} {contact.EmailAdress}");
                    }


                }
                Console.WriteLine("Click any button to go back to menu");
                Console.ReadKey();
            }
        }


        public static Array ViewSpecificContact()
        {
            Console.Clear();

            Console.WriteLine("FirstName:Hans\r\nLastname:Mattin-Lassei\r\nAddress:Nordkapsvägen 1, 123 45 Stockholm\r\nEmailadress:hans@domain.com\r\nPhonenumber:073-123 45 67\r\n ");
            Console.ReadLine();
            return null;

        }
    }
}
