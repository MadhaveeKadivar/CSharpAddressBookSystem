using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBookMainClass
    {
        static void Main(string[] args)
        {
            AddressBook records = new AddressBook(); // Creating a object of AddressBook class
            while (true)
            {
                Console.WriteLine("\n\nWelcome to Address Book System");               
                Console.WriteLine("1. Add a new Record");
                Console.WriteLine("2. Update a Record");
                Console.WriteLine("3. Delete a Record");
                Console.WriteLine("4.Exit");
                Console.WriteLine("\nEnter your choice : ");
                
                int ch = Convert.ToInt32(Console.ReadLine());// Storing a user choice in variabl
                switch (ch)
                {
                    case 1:
                        records.AddRecords(); // Calling a method of AddressBook class to add record in address book
                        records.PrintRecords();// Calling a method of AddressBook class to display records of address book
                        break;
                    case 2:
                        Console.WriteLine("\nEnter your First Name : ");
                        string fn = Console.ReadLine(); // Store the user firstname in variable
                        Console.WriteLine("Enter your Last Name : ");
                        string ln = Console.ReadLine();// Store the user last name in variable
                        records.UpdateRecords(fn, ln); // Calling a method of AddressBook class to update records of address book with passing first name and last name as arguments
                        records.PrintRecords(); // Calling a method of AddressBook class to display records of address book
                        break;
                    case 3:
                        Console.WriteLine("\nEnter your first name which you want to delete : ");
                        string f = Console.ReadLine(); // Store the user firstname in variable
                        records.DeleteRecord(f);// Calling a method of AddressBook class to delete record of address book
                        records.PrintRecords();// Calling a method of AddressBook class to display records of address book
                        break;
                    case 4:
                        System.Environment.Exit(0); // Exit
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
