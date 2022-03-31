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
            AddressBook records = new AddressBook();
            while (true)
            {
                Console.WriteLine("\n\nWelcome to Address Book System");               
                Console.WriteLine("1. Add a new Record");
                Console.WriteLine("2. Update a Record");
                Console.WriteLine("3. Delete a Record");
                Console.WriteLine("4.Exit");
                Console.WriteLine("\nEnter your choice : ");
                
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        records.AddRecords();
                        records.PrintRecords();
                        break;
                    case 2:
                        Console.WriteLine("\nEnter your First Name : ");
                        string fn = Console.ReadLine();
                        Console.WriteLine("Enter your Last Name : ");
                        string ln = Console.ReadLine();
                        records.UpdateRecords(fn, ln);
                        records.PrintRecords();
                        break;
                    case 3:
                        Console.WriteLine("\nEnter your first name which you want to delete : ");
                        string f = Console.ReadLine();
                        records.DeleteRecord(f);
                        records.PrintRecords();
                        break;
                    case 4:
                        System.Environment.Exit(0);
                        break;
                }
                Console.ReadLine();
            }

        }
    }
}
