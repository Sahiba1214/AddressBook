﻿using System;

namespace AddressBookSystem
{
    class Program
    {
        private static object addressbook;
        private static object addressBook;

        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to the Address Book Program");   
                Console.WriteLine("Enter what you want to do : \n 1. Create Contacts \n 2. Add Contact \n 3. Edit Contact \n 4. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the Contact details of FirstName, LastName, Address, City, State, Zip, Ph.no, Email : ");
                        Contact contact = new Contact()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Console.ReadLine(),
                            PhoneNumber = Console.ReadLine(),
                            Email = Console.ReadLine(),
                        };
                        break;
                    case 2:
                   
                        Console.WriteLine("Enter the Contact Information to be Add in form of FirstName, LastName, Addr, City, State, Zip, Ph.No, Email.");
                        contact = new Contact()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Console.ReadLine(),
                            PhoneNumber = Console.ReadLine(),
                            Email = Console.ReadLine(),
                        };
                        addressbook.AddContact(contact);
                        addressbook.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter the Contact Name to be Edited: ");
                        string name = Console.ReadLine();
                        addressbook.EditContact(name);
                        addressbook.Display();
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}



