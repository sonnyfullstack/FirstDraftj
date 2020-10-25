using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GroupAssignment
{
    class Adressbook : IAdressBook
    {

        public List<Person> AdressBookList = new List<Person>();

        public void CreatePerson(Person person)
        {
            AdressBookList.Add(person);
        }
        public void RemovePersonFromList(string userInput)
        {
          AdressBookList.RemoveAll(r => r.Name == userInput);
        }

        public void EditPersonInfo(string userInput)
        {
            Person person = AdressBookList.Find(f => f.Name == userInput);
            if (person != null)
            {
                Console.WriteLine($"What do you want to edit? \n 1. {person.Name}'s Name \n 2. {person.Name}'s Email Adress " +
               $"\n 3. {person.Name}'s Home Adress \n 4. {person.Name}'s Private Phone Number \n 5. {person.Name}'s Work Phone Number");
                var userInput1 = Console.ReadLine();
                switch (userInput1)
                {
                    case "1":
                        Console.WriteLine("Type the updated name");
                        var newValue = Console.ReadLine().ToLower();
                        person.Name = newValue;
                        break;

                    case "2":
                        Console.WriteLine("Type the updated email");
                        var newEmail = Console.ReadLine().ToLower();
                        person.EmailAdress = newEmail;
                        break;

                    case "3":
                        Console.WriteLine("Type the update adress");
                        var newAdress = Console.ReadLine().ToLower();
                        person.HomeAdress = newAdress;
                        break;

                    case "4":
                        Console.WriteLine("Type the updated private phone number");
                        var newPrivatePhone = Console.ReadLine();
                        person.PrivatePhoneNumber = newPrivatePhone;
                        break;

                    case "5":
                        Console.WriteLine("Type the update work phone number");
                        var newWorkPhone = Console.ReadLine();
                        person.WorkPhoneNumber = newWorkPhone;
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

        public void FindPerson(string userInput)
        {
            Person person = AdressBookList.Find(f => f.Name == userInput || f.HomeAdress == userInput
            || Convert.ToString(f.Age) == userInput || f.EmailAdress == userInput || f.PrivatePhoneNumber == userInput || f.WorkPhoneNumber == userInput);
           
            if (person != null)
            {
                Console.WriteLine($"{person.Name}, {person.Age}, {person.EmailAdress}, {person.HomeAdress}, {person.PrivatePhoneNumber}, {person.WorkPhoneNumber}");
                Console.ReadLine();
            }   
            else
            {
                Console.WriteLine("This person does not exist");
            }
        }

        public void ListAllContacts()
        {
            foreach(var person in AdressBookList)
            {
               Console.WriteLine($"{person.Name}, {person.Age}, {person.EmailAdress}, {person.HomeAdress}, {person.PrivatePhoneNumber}, {person.WorkPhoneNumber}");
            }
        }

       
        
    }
}
