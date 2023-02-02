using AdressBok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.IO;


namespace AdressBok
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("1. Create a new contact");
                    Console.WriteLine("2. Remove a contact");
                    Console.WriteLine("3. View a contact");
                    Console.WriteLine("4. View all contacts");
                    Console.WriteLine("Choose one of the options above \r\n(By number)");

                    var svar = int.Parse(Console.ReadLine());

                    switch (svar)
                    {
                        case 1:
                            ContactService.CreateContact();
                            break;
                        case 2:
                            ContactService.RemoveContact();
                            break;
                        case 3:
                            ViewContactService.ViewSpecificContact();
                            break;
                        case 4:
                            ViewContactService.ViewAllContacts();
                            Console.WriteLine("\r\nClick any button to go back to menu");
                            Console.ReadKey();
                            break;
                        default:
                            break;

                    }
                }
                catch (Exception e)
                {
                     Console.WriteLine($"Error: {e.Message}");
                    Console.ReadLine();
                }
            }
        }
    }
}

