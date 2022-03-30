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
            Console.WriteLine("Welcome to Address Book System");
            AddressBook records = new AddressBook();
            Console.WriteLine("1. Add a new Record");
            Console.WriteLine("Enter your choice : ");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    records.AddRecords();
                    records.PrintRecords();
                    Console.ReadLine();
                    break;
            }
            
            
        }
    }
}
