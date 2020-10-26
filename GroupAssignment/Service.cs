using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment
{
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
                   Person person = adressBook.FindPerson(dataInput.Find());
                    IfNull(person);
                    break;
                case Action.ListAll:
                    adressBook.ListAllContacts();
                    break;
                case Action.Delete:
                 Person person1 = adressBook.FindPerson(dataInput.Delete());
                    adressBook.RemovePersonFromList(person1);
                    break;
                case Action.Edit:
                    Person person2 = adressBook.FindPerson(dataInput.Edit());
                    EditPerson(person2);
                    break;
            }
        }

      /*  public string StringCheck(Person userInput)
        {
            if(userInput == userInput.Empty)
            {
                Console.WriteLine();
            }
        }*/
        public void IfNull(Person person)
        {

            if (person != null)
            {
                Console.WriteLine($"Name:{person.Name} Age:{person.Age} Email:{person.EmailAdress} Home Adress:{person.HomeAdress}" +
                    $"Private Phone:{person.PrivatePhoneNumber} Work Phone:{person.WorkPhoneNumber}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("This person does not exist");
            }
        }

        public void EditPerson(Person person)
        {
            if (person != null)
            {
                Console.WriteLine($"What do you want to edit? \n 1. {person.Name}'s Name \n 2. {person.Name}'s Email Adress " +
               $"\n 3. {person.Name}'s Home Adress \n 4. {person.Name}'s Private Phone Number \n 5. {person.Name}'s Work Phone Number");
                var userInput1 = Console.ReadLine();
                switch (userInput1)
                {
                    case "1":
                        dataInput.ChangeName(person);
                        break;

                    case "2":
                        dataInput.ChangeEmail(person);
                        break;

                    case "3":
                        dataInput.HomeAdress(person);
                        break;

                    case "4":
                        dataInput.PrivatePhoneNumber(person);
                        break;

                    case "5":
                        dataInput.WorkPhoneNumber(person);
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Can't edit a person that doesn't exist");
            }
        }
    }
}
