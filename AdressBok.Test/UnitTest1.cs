using AdressBok;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace AdressBok.Test
{
    [TestClass]
    public class AdressBok_Test
    {
        [TestMethod]
        public void Should_Add_Contact_To_List()
        {
            //arrange
            ContactService contactService = new ContactService();
            Contact contact = new Contact();


            //act 

            ContactService.ContactList.Add(contact);
            //assert
            Assert.AreEqual(1, ContactService.ContactList.Count);
        }
    }
}