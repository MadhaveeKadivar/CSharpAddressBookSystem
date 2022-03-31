using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBook
    {
        

        List<PersonInput> addressbook = new List<PersonInput>();
        public void AddRecords()
        {
            PersonInput input = new PersonInput();
            Details:            
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

            if(addressbook.Count==0)
            {
                addressbook.Add(input);
                Console.WriteLine("\nRecord Added successfully in Address Book");
            }
            else
            { 
                foreach(var record in addressbook)
                {
                    if (record.fName == input.fName)
                    {
                        Console.WriteLine("\nThis record is already present in AddressBook");
                        goto Details;
                    }
                    else
                    {
                        addressbook.Add(input);
                        Console.WriteLine("\nRecord Added successfully in Address Book");
                    }
                }
            }
                                
        }
        int i = 1;
        public void PrintRecords()
        {
            
            foreach (var record in addressbook)
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

        public void UpdateRecords(string fn,string ln)
        {
            foreach(var record in addressbook)
            {
                if (record.fName == fn && record.lName == ln)
                {
                    while (true)
                    {
                        Console.WriteLine("\n\nWhich field you want to update : ");
                        Console.WriteLine("\n1:First Name\n2.Last Name\n3.Address\n4.City\n5.State\n6.Email\n7.Zip Code\n8.PhoneNumber\n9.Exit");
                        Console.WriteLine("Enter your Choice : ");
                        int ch = Convert.ToInt32(Console.ReadLine());
                        switch (ch)
                        {
                            case 1:
                                Console.WriteLine("\nEnter new first name : ");
                                string f = Console.ReadLine();
                                record.fName = f;
                                Console.WriteLine("\nFirst Name Updated Successfully");
                                break;
                            case 2:
                                Console.WriteLine("\nEnter new last name : ");
                                string l = Console.ReadLine();
                                record.lName = l;
                                Console.WriteLine("\nLast Name Updated Successfully");
                                break;
                            case 3:
                                Console.WriteLine("\nEnter new address : ");
                                string a = Console.ReadLine();
                                record.address = a;
                                Console.WriteLine("\nAddress Updated Successfully");
                                break;
                            case 4:
                                Console.WriteLine("\nEnter new city name : ");
                                string c = Console.ReadLine();
                                record.city = c;
                                Console.WriteLine("\nCity Name Updated Successfully");
                                break;
                            case 5:
                                Console.WriteLine("\nEnter new state : ");
                                string s = Console.ReadLine();
                                record.state = s;
                                Console.WriteLine("\nState Name Updated Successfully");
                                break;
                            case 6:
                                Console.WriteLine("\nEnter new email : ");
                                string e = Console.ReadLine();
                                record.email = e;
                                Console.WriteLine("\nEmail Updated Successfully");
                                break;
                            case 7:
                                Console.WriteLine("\nEnter new Zip Code : ");
                                int z = Convert.ToInt32(Console.ReadLine());
                                record.zip = z;
                                Console.WriteLine("\nZip Code Updated Successfully");
                                break;
                            case 8:
                                Console.WriteLine("\nEnter new Phone Number : ");
                                int p = Convert.ToInt32(Console.ReadLine());
                                record.phoneNumber = p;
                                Console.WriteLine("\nPhone Number Updated Successfully");
                                break;
                            case 9:
                                System.Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Enter valid choice");
                                break;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Your entered details not match with any records");
                }
            }
        }
    }
}
