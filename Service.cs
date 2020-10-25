using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment
{
    public enum WhatToEdit { NAME, EMAIL, HOMEADRESS, PRIVATEPHONE, WORKPHONE }
    class Service
    {
        IDataInput dataInput;
        IAdressBook adressBook;
        public Service(IDataInput data, IAdressBook adressBook) 
        {
            dataInput = data;
            this.adressBook = adressBook;
        }

        public void UserChoice()
        {
            switch (dataInput.GetNextAction())
            {
                case Action.Create:
                    adressBook.CreatePerson(dataInput.GetPerson());
                    break;
                case Action.Find:
                 adressBook.FindPerson(dataInput.Find());
                    break;
                case Action.ListAll:
                    adressBook.ListAllContacts();
                    break;
                case Action.Delete:
                    adressBook.RemovePersonFromList(dataInput.Delete());
                    break;
                case Action.Edit:
                    var userInput = dataInput.Edit();
                    WhatToEdit();
                    

            }

            
        }

        public WhatToEdit WhatToEdit()
        {
          
        }
        public void IfNull(Person person)
        {
           
        }
        
     
    }
}
