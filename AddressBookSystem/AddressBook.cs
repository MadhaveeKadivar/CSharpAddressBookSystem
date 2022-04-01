using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBook
    {
        List<PersonInput> addressbook = new List<PersonInput>(); // Creating List having PersonInput Class Object Datatype
        public void AddRecords() // Creating class method to add Person Record in List
        {
            PersonInput input = new PersonInput(); // Creating a object of PersonInput Class
            // Getting all the details from user and store it in PersonInput Class variales through object  
            Console.WriteLine("\nEnter your First Name : ");
            input.fName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name : ");
            input.lName = Console.ReadLine();
            Console.WriteLine("Enter your Address : ");
            input.address = Console.ReadLine();
            Console.WriteLine("Enter your City Name : ");
            input.city = Console.ReadLine();
            Console.WriteLine("Enter your State Name : ");
            input.state = Console.ReadLine();
            Console.WriteLine("Enter your Zip Code : ");
            input.zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Phone Number : ");
            input.phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Email Address: ");
            input.email = Console.ReadLine();
            addressbook.Add(input); // Adding all the details of user as a one record in List
            Console.WriteLine("Record Added successfully in Address Book"); 
        }
        public void PrintRecords() // Creating a class method to just display all the records of list
        {
            int i = 1;
            foreach (var record in addressbook) // Accessing all the records of list one by one using foreach loop
            {
                Console.WriteLine("\n\nRecord - "+i);
                Console.WriteLine("First Name : "+record.fName);
                Console.WriteLine("Last Name : "+record.lName);
                Console.WriteLine("Address : "+record.address);
                Console.WriteLine("City : "+record.city);
                Console.WriteLine("State : "+record.state);
                Console.WriteLine("Email : "+record.email);
                Console.WriteLine("Zip code : "+record.zip);
                Console.WriteLine("Phone Number : "+record.phoneNumber);
                i++;
            }
        }
        public void UpdateRecords(string fn, string ln) // Creating class method to update record which takes first name and last name as parameter
        {
            foreach (var record in addressbook.ToList()) // Accessing all the records of list one by one using foreach loop
            {
                if (record.fName == fn && record.lName == ln) // Checking that first name and last name provided by user is matching with Existing Reord or not
                {
                    Console.WriteLine("\n\nWhich field you want to update : ");
                    Console.WriteLine("\n1:First Name\n2.Last Name\n3.Address\n4.City\n5.State\n6.Email\n7.Zip Code\n8.PhoneNumber\n9.Exit");
                    Console.WriteLine("\nEnter your Choice : ");
                    int ch = Convert.ToInt32(Console.ReadLine()); // Store the user choice which want to update 
                    switch (ch)
                    {
                        case 1:
                            Console.WriteLine("\nEnter new first name : ");
                            string f = Console.ReadLine();
                            record.fName = f; // Update the first name of record in address book
                            Console.WriteLine("\nFirst Name Updated Successfully");
                            break;
                        case 2:
                            Console.WriteLine("\nEnter new last name : ");
                            string l = Console.ReadLine();
                            record.lName = l;  // Update the last name of record in address book
                            Console.WriteLine("\nLast Name Updated Successfully");
                            break;
                        case 3:
                            Console.WriteLine("\nEnter new address : ");
                            string a = Console.ReadLine();
                            record.address = a; // Update the address of record in address book
                            Console.WriteLine("\nAddress Updated Successfully");
                            break;
                        case 4:
                            Console.WriteLine("\nEnter new city name : ");
                            string c = Console.ReadLine();
                            record.city = c; // Update the city name of record in address book
                            Console.WriteLine("\nCity Name Updated Successfully");
                            break;
                        case 5:
                            Console.WriteLine("\nEnter new state : ");
                            string s = Console.ReadLine();
                            record.state = s; // Update the state name of record in address book
                            Console.WriteLine("\nState Name Updated Successfully");
                            break;
                        case 6:
                            Console.WriteLine("\nEnter new email : ");
                            string e = Console.ReadLine();
                            record.email = e; // Update the email name of record in address book
                            Console.WriteLine("\nEmail Updated Successfully");
                            break;
                        case 7:
                            Console.WriteLine("\nEnter new Zip Code : ");
                            int z = Convert.ToInt32(Console.ReadLine());
                            record.zip = z; // Update the zipcode of record in address book
                            Console.WriteLine("\nZip Code Updated Successfully");
                            break;
                        case 8:
                            Console.WriteLine("\nEnter new Phone Number : ");
                            int p = Convert.ToInt32(Console.ReadLine());
                            record.phoneNumber = p; // Update the phone number of record in address book
                            Console.WriteLine("\nPhone Number Updated Successfully");
                            break;
                        default:
                            Console.WriteLine("\nEnter valid choice");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nYour entered details not match with any records");
                }
            }
        }
        public void DeleteRecord(string fname)  // Creating class method to delete record which takes first name as parameter
        {
            foreach (var record in addressbook.ToList()) // Accessing all the records of list one by one using foreach loop
            {
                if (record.fName == fname)  // Checking that first name provided by user is matching with Existing Reord or not
                {
                    addressbook.Remove(record); // Deleting all the details of one user in Address Book
                    Console.WriteLine("\nRecord Deleted Successfully");
                }
            }
        }
    }
}
