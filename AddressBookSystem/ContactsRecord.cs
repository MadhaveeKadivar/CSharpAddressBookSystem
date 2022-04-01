using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class ContactsRecord
    {
        public void Input() //Creating class method
        {
            //Declaring Variable
            string fName,lName,address,city,state ,email ;
            int zip, phoneNumber;
            Console.WriteLine("Enter your First Name : ");
            fName = Console.ReadLine(); //Read firstname as input which is provided by user
            Console.WriteLine("Enter your Last Name : ");
            lName = Console.ReadLine(); //Read lastname as input which is provided by user
            Console.WriteLine("Enter your Address : ");
            address = Console.ReadLine(); //Read address as input which is provided by user
            Console.WriteLine("Enter your City Name : ");
            city = Console.ReadLine(); //Read city name as input which is provided by user
            Console.WriteLine("Enter your State Name : ");
            state = Console.ReadLine(); //Read state name as input which is provided by user
            Console.WriteLine("Enter your Zip Code : ");
            zip = Convert.ToInt32(Console.ReadLine()); //Read zip code as input which is provided by user
            Console.WriteLine("Enter your Phone Number : ");
            phoneNumber = Convert.ToInt32(Console.ReadLine()); //Read phone number as input which is provided by user
            Console.WriteLine("Enter your Email Address: ");
            email = Console.ReadLine(); //Read email as input which is provided by user
        }
    }
}
