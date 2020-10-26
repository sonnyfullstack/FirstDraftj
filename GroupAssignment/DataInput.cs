﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment
{
    public enum Action { Delete = 1, Create = 2, Edit = 3, Find = 4, ListAll = 5, Invalid }
    class DataInput : IDataInput
    {
        public Action GetNextAction()
        {
            Console.WriteLine("Do you want to do? \n 1. Create New Contact \n 2. Edit Contact \n 3. Remove Contact \n 4. Find Person \n 5.List All Contacts \n type x and enter to close the application");
            var userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    return Action.Create;
                case "2":
                    return Action.Edit;
                case "3":
                    return Action.Delete;
                case "4":
                    return Action.Find;
                case "5":
                    return Action.ListAll;
                case "x":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            return Action.Invalid;
        }

        public Person GetPerson()
        {
            int age;

            Console.WriteLine("Enter Name:");
            var name = Console.ReadLine().ToLower();

            while (true)
            {
                Console.WriteLine("Enter Age:");
                if (int.TryParse(Console.ReadLine(), out age))
                {
                    break;
                }
                Console.WriteLine("Please enter a valid age");
            }
            Person person = new Person(name, age);
            return person;
        }
        public string Delete()
        {
            Console.WriteLine("Who do you want to delete?");
            var userInput = Console.ReadLine().ToLower();
            return userInput;
        }

        public string Edit()
        {
            Console.WriteLine("Which person do you want to edit?");
            var userInput = Console.ReadLine().ToLower();
            return userInput;
        }
        public string Find()
        {
            Console.WriteLine("Search for contacts name, email, adress or age to find a contact that matches that information");
            var userInput = Console.ReadLine().ToLower();
            return userInput;
        }
        public Person ChangeName(Person person)
        {
            Console.WriteLine("Type the updated name ");
            var newName = Console.ReadLine();
            person.Name = newName;
            return person;
        }
        public Person ChangeEmail(Person person)
        {
            Console.WriteLine("Type the updated Email ");
            var newEmail = Console.ReadLine();
            person.EmailAdress = newEmail;
            return person;
        }
        public Person HomeAdress(Person person)
        {
            Console.WriteLine("Type the updated home adress ");
            var newHomeAdress = Console.ReadLine();
            person.HomeAdress = newHomeAdress;
            return person;
        }
        public Person PrivatePhoneNumber(Person person)
        {
            Console.WriteLine("Type the updated private phone number: ");
            var newPrivatePhone = Console.ReadLine();
            person.PrivatePhoneNumber = newPrivatePhone;
            return person;
        }
        public Person WorkPhoneNumber(Person person)
        {
            Console.WriteLine("Type the updated work phone number: ");
            var newWorkPhone = Console.ReadLine();
            person.WorkPhoneNumber = newWorkPhone;
            return person;
        }
}   }