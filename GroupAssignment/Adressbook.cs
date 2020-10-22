using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment
{
    class Adressbook
    {
        List<Person> AdressBookList = new List<Person>();

        public void UserChoice()
        {
            Console.WriteLine("Do you want to do? \n 1. Create New Contact \n 2. Edit Contact \n 3. Remove Contact \n 4. Find Person \n List All Contacts");
            var userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    CreatePerson();
                    break;

                case "2":
                    EditPersonInfo();
                    break;

                case "3":
                    RemovePersonFromList();
                    break;

                case "4":
                    FindPerson();
                    break;

                case "5":
                    ListAllContacts();
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
        public void CreatePerson()
        {
            Console.WriteLine("Enter Name:");
            var name = Console.ReadLine();

            Console.WriteLine("Enter Age:");
            var age = Convert.ToInt32(Console.ReadLine());
        
            Person person = new Person(name, age);
            AdressBookList.Add(person);
        }

        public void RemovePersonFromList()
        {
            Console.WriteLine("Who do you want to remove from your list?");
            var userInput = Console.ReadLine();
            AdressBookList.RemoveAll(r => r.Name == userInput);
        }

        public void EditPersonInfo()
        {
            
        }

        public void FindPerson()
        {
            Console.WriteLine("Who do you want to find?");
            var userInput = Console.ReadLine();
            Person person = AdressBookList.Find(f => f.Name == userInput);
            Console.WriteLine(person.Age);
            Console.ReadLine();
        }

        public void ListAllContacts()
        {
            foreach(var person in AdressBookList)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }
        }
    }
}
