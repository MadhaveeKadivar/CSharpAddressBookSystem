using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class ContactsRecord
    {
        public void Input()
        {
            string fName,lName,address,city,state ,email ;
            int zip, phoneNumber;
            Console.WriteLine("Enter your First Name : ");
            fName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name : ");
            lName = Console.ReadLine();
            Console.WriteLine("Enter your Address : ");
            address = Console.ReadLine();
            Console.WriteLine("Enter your City Name : ");
            city = Console.ReadLine();
            Console.WriteLine("Enter your State Name : ");
            state = Console.ReadLine();
            Console.WriteLine("Enter your Zip Code : ");
            zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Phone Number : ");
            phoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Email Address: ");
            email = Console.ReadLine();
        }
    }
}
