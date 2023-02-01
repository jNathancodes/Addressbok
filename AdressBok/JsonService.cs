using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace AdressBok
{
    internal class JsonService
    {
        public static void ConvertContactToJson(Contact contact)
        {
            string urlJson = @".\JsonSaveFile.Json";

            if (File.Exists(urlJson))
            {

                string oldContactsText = File.ReadAllText(urlJson);
                List<Contact> oldContacts = JsonSerializer.Deserialize<List<Contact>>(oldContactsText);
                oldContacts.Add(contact);


                string contactInJson = JsonSerializer.Serialize(oldContacts);
                File.WriteAllText(urlJson, contactInJson);
            }
            else
            {
                
                var contacts = new List<Contact>();
                contacts.Add(contact);
                string contacsInJson = JsonSerializer.Serialize(contacts);
                File.WriteAllText(urlJson, contacsInJson);


            }

            //static void ConvertJsonToContact()
            //{
            //    var cus = CreateContact();

            //    var jsonFormattedContent = Newtonsoft.Json.JsonConvert.SerializeObject(cus);

            //    string contact =

            //        if (File.Exists(contact) == )
            //    {
            //        File.WriteAllText(contact, jsonFormattedContent);
            //    }
            //    else
            //    {
            //        File.Delete(contact);
            //        File.WriteAllText(contact, jsonFormattedContent);
            //    }
            //}
        }
    }
}
