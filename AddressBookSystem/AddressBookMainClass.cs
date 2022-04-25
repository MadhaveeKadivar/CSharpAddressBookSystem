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
            string ab;
            Again: 
            while (true)
            {
                Console.WriteLine("\n\nWelcome to Address Book System");               
                Console.WriteLine("1. Add a new Record");
                Console.WriteLine("2. Update a Record");
                Console.WriteLine("3. Delete a Record");
                Console.WriteLine("4. Display all persons by City name");
                Console.WriteLine("5. Display all persons by State name");
                Console.WriteLine("6. Store the All Persons by city and state name in Dictionary");
                Console.WriteLine("7. Numbers of persons count by City name");
                Console.WriteLine("8. Numbers of persons count by State name");
                Console.WriteLine("9. Display All the records in Alphabetically order By person first name");
                Console.WriteLine("10. Display all the records by City,State or Zip code");
                Console.WriteLine("11. Exit");
                Console.WriteLine("\nEnter your choice : ");
                
                int ch = Convert.ToInt32(Console.ReadLine());// Storing a user choice in variable
                switch (ch)
                {
                    case 1:
                        string n;
                        Console.WriteLine("\nDo you want to add records in new Address Book ?\nIf yes then press 1 otherwise press any key to displaying existing address book : ");
                        string c = Console.ReadLine(); // Storing a user choice in variable
                        if (c == "1")
                        {
                            Console.WriteLine("\nEnter name of address book which you want to create : ");
                            n = Console.ReadLine(); // Storing a address book name which is provided by user
                            records.CreateAddressBook(n); // Calling a method to Create a new Address Book 
                            records.AddRecords(n); // Calling a method of AddressBook class to add a new record to Address Book
                            records.DisplayDictionary(); // Displaying all records of All Address book
                            
                        }
                        else
                        {
                            records.DiplayListOfAddressBook();// Displaying existing address book name
                            if (records.temp == 1) //Checking that address book is empty or not
                            {
                                Console.WriteLine("\nPlease Add Address Book First by entering choice 1");
                                goto Again;
                            }
                            else
                            {                               
                                Console.WriteLine("\nSelect any one address book from above list : ");
                                ab = Console.ReadLine(); // Storing a address book name which is provided by user
                                records.AddRecords(ab); // Calling a method of AddressBook class to add a new record to Address Book
                                records.DisplayDictionary(); // Displaying all records of All Address book
                            }                                                       
                        }
                        break;
                    case 2:
                        records.DiplayListOfAddressBook();// Displaying existing address book name
                        if (records.temp == 1)//Checking that address book is empty or not
                        {
                            Console.WriteLine("\nPlease Add Address Book First by entering choice 1");
                            goto Again;
                        }
                        else
                        {
                            Console.WriteLine("\nSelect any one address book from above list : ");
                            ab = Console.ReadLine();// Storing a address book name which is provided by user
                            records.UpdateRecords(ab); // Calling a method of AddressBook class to update record to Address Book
                            records.DisplayDictionary(); // Displaying all records of All Address book
                        }                                            
                        break;
                    case 3:
                        records.DiplayListOfAddressBook(); // Displaying existing address book name
                        if (records.temp == 1) //Checking that address book is empty or not
                        {
                            Console.WriteLine("\nPlease Add Address Book First by entering choice 1");
                            goto Again;
                        }
                        else
                        {
                            Console.WriteLine("\nSelect any one address book from above list : ");
                            ab = Console.ReadLine(); // Storing a address book name which is provided by user                  
                            records.DeleteRecord(ab);// Calling a method of AddressBook class to delete record of address book
                            records.DisplayDictionary(); // Displaying all records of All Address book
                        }                        
                        break;
                    case 4:
                        Console.WriteLine("\nEnter any city name : ");
                        string city = Console.ReadLine();
                        records.DisplayPersonsByCityName(city);
                        break;
                    case 5:
                        Console.WriteLine("\nEnter any state name : ");
                        string state = Console.ReadLine();
                        records.DisplayPersonsByStateName(state);
                        break;
                    case 6:
                        records.AddPersonsInDictionaryByStateName();
                        records.AddPersonsInDictionaryByCityName();
                        break;
                    case 7:
                        records.AddPersonsInDictionaryByCityName();
                        Console.WriteLine("\nEnter any city name : ");
                        string cn = Console.ReadLine();
                        int cc = records.CountPersonsByCity(cn);
                        Console.WriteLine($"Total number of records where city name is {cn} are : {cc} ");
                        break;
                    case 8:
                        records.AddPersonsInDictionaryByStateName();
                        Console.WriteLine("\nEnter any state name : ");
                        string sn = Console.ReadLine();
                        int sc = records.CountPersonsByState(sn);
                        Console.WriteLine($"Total number of records where city name is {sn} are : {sc} ");
                        break;
                    case 9:
                        records.SortByPersonName();
                        records.DisplayDictionary();
                        break;
                    case 10:
                        Console.WriteLine("How you want to sort all the records Address book vise : ");
                        Console.WriteLine("1.By City\n2.By State\n3.By ZipCode");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch(choice)
                        {
                            case 0:
                                records.SortByCity();
                                records.DisplayDictionary();
                                break;
                            case 1:
                                records.SortByState();
                                records.DisplayDictionary();
                                break;
                            case 2:
                                records.SortByZip();
                                records.DisplayDictionary();
                                break;
                        }
                        break;
                    case 11:
                        System.Environment.Exit(0); // Exit
                        break;
                }
                Console.WriteLine("\n\nPlease enter to continue....Otherwise press any key to exit");
                string e = Console.ReadLine();
                if(e != String.Empty)
                {
                    System.Environment.Exit(0);
                }
            }
        }
    }
}
