using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment
{
    interface IAdressBook
    {
        void CreatePerson(Person person);
        void RemovePersonFromList(string userInput);
        void EditPersonInfo(string userInput);
        void FindPerson(string userInput);
        void ListAllContacts();
    }
}
