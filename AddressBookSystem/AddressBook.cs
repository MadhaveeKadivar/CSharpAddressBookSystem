using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBook
    {
       
        List<string> addressBookName = new List<string>(); // Creating a list to maintain address book name
        List<string> cityName = new List<string>(); // Creating a list to maintain city name
        List<string> stateName = new List<string>(); // Creating a list to maintain state name
        Dictionary<string, List<PersonInput>> recordsByCity = new Dictionary<string, List<PersonInput>>(); // Creating dictionary to Maintain all the records by city name
        Dictionary<string, List<PersonInput>> recordsByState = new Dictionary<string,List<PersonInput>>(); // Creating dictionary to Maintain all the records by state name
        Dictionary<string, List<PersonInput>> dict = new Dictionary<string, List<PersonInput>>(); // Creating dictionary to Maintain all the address book 
        /// <summary>
        /// Creating a Multiple address book
        /// </summary>
        /// <param name="n"></param>
        public void CreateAddressBook(string n) // class method to create new address book and store it in dictionary
        {
            if (!(addressBookName.Contains(n)))
            { 
                addressBookName.Add(n); // Add address book name which is provided by user  in address book list
            }
            if (dict.Count == 0) // Checking that dictionary is empty or not
            {
                dict.Add(n.ToLower(), new List<PersonInput>()); // creating key value pair where address book name is key and all the redord of address book as value
            }
            else
            {
                if (dict.ContainsKey(n.ToLower())) // Checking that address book given by user is already present in dictionary or not
                {
                    Console.WriteLine("This AddressBook is also present");
                }
                else
                {
                    dict.Add(n.ToLower(), new List<PersonInput>()); // creating key value pair where address book name is key and all the redord of address book as value
                }               
            }            
        }
        /// <summary>
        /// Storing all unique city names in List
        /// </summary>
        /// <param name="city"></param>
        public void cityNames(string city)
        {
            if(cityName.Count == 0)
            {
                cityName.Add(city.ToLower());
            }
            else
            {
                if(cityName.Contains(city))
                {
                    return;
                }
                else
                {
                    cityName.Add(city.ToLower());
                }
            }
        }
        /// <summary>
        /// Storing all unique state names in List
        /// </summary>
        /// <param name="state"></param>
        public void stateNames(string state)
        {
            if (stateName.Count == 0)
            {
                stateName.Add(state.ToLower());
            }
            else
            {
                if (stateName.Contains(state.ToLower()))
                {
                    return;
                }
                else
                {
                    stateName.Add(state.ToLower());
                }
            }
        }

        public int temp = 0;
        /// <summary>
        /// Displaying all the address book
        /// </summary>
        public void DiplayListOfAddressBook() // Class method to display name Address book
        {
            if (addressBookName.Count == 0) // Checking that address book list is empty or not
            {
                Console.WriteLine("\nThere is no address book avilable");
                temp = 1;
            }
            else
            {
                Console.WriteLine("\n\nList of existing Address Book Are : ");
                foreach (string list in addressBookName) // Accessing all the names in address book
                {                    
                    Console.WriteLine(list);
                    Console.WriteLine();
                }
            }
        }
        public void RecordsDisplay(PersonInput value)
        {          
            Console.WriteLine("First Name : "+value.fName);
            Console.WriteLine("Last Name : "+value.lName);
            Console.WriteLine("Address : "+value.address);
            Console.WriteLine("City : "+value.city);
            Console.WriteLine("State : "+value.state);
            Console.WriteLine("Email : "+value.email);
            Console.WriteLine("Zip code : "+value.zip);
        }
        /// <summary>
        /// Displaying all the record by address book
        /// </summary>
        public void DisplayDictionary() // Class method to display all the records of all address book
        {            
            foreach (var content in dict.Keys) // Accessing all the address book name of dictionary
            {
                Console.WriteLine("\n\nAddress Book : "+content);
                int i = 1;
                foreach (var value in dict[content].ToList()) // Accessing all the address book records  by dictionary key
                {
                    Console.WriteLine("\nRecord - "+i);
                    RecordsDisplay(value);
                    i++;
                }
            }
        }
        /// <summary>
        /// Adding record in dictionary
        /// </summary>
        /// <param name="name"></param>
        public void AddRecords(string name) // Creating class method to add Person Record in List
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
            foreach (var content in dict.Keys) // Accessing all the address book name of dictionary
            {
                if (content == name) // Checking that address book name provied by user is matching with dictionary address book or not
                {
                    if (dict[content].Count == 0)
                    {
                        dict[name].Add(input);// Adding person record in Address book 
                        cityNames(input.city);
                        stateNames(input.state);
                        Console.WriteLine("\nRecord Added successfully in Address Book");
                    }
                    else
                    {
                        foreach (var value in dict[content].ToList()) // Accessing all the record of address book by dictionary key
                        {
                            if (value != input) // Checking that phone number provided by user is matching with Existing Reord or not
                            {
                                dict[name].Add(input);// Adding person record in Address book 
                                cityNames(input.city);
                                stateNames(input.state);
                                Console.WriteLine("\nRecord Added successfully in Address Book");
                            }
                            else
                            {
                                Console.WriteLine($"\nThis Record is already present in {content} Address Book");
                            }
                        }
                    }                   
                }
                else
                {
                    Console.WriteLine($"\n{content} Address Book not found");
                }             
            }                   
        }

        string fn, ln;
        /// <summary>
        /// Updating records in Dictionary 
        /// </summary>
        /// <param name="ab"></param>
        public void UpdateRecords(string ab) // Creating class method to update record which takes first name and last name as parameter
        {
            foreach (var content in dict.Keys)  // Accessing all the record of address book by dictionary key
            {
                if (content == ab) // Checking that address book name provied by user is matching with dictionary address book or not
                {
                    Console.WriteLine("\nEnter your First Name : ");
                    fn = Console.ReadLine(); // Store the user firstname in variable
                    Console.WriteLine("Enter your Last Name : ");
                    ln = Console.ReadLine(); // Store the user lastname in variable
                    foreach (var value in dict[content].ToList())
                    {
                        if (value.fName == fn && value.lName == ln) // Checking that first name and last name provided by user is matching with Existing Reord or not
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
                                    value.fName = f; // Update the first name of record in address book
                                    Console.WriteLine("\nFirst Name Updated Successfully");
                                    break;
                                case 2:
                                    Console.WriteLine("\nEnter new last name : ");
                                    string l = Console.ReadLine();
                                    value.lName = l;  // Update the last name of record in address book
                                    Console.WriteLine("\nLast Name Updated Successfully");
                                    break;
                                case 3:
                                    Console.WriteLine("\nEnter new address : ");
                                    string a = Console.ReadLine();
                                    value.address = a; // Update the address of record in address book
                                    Console.WriteLine("\nAddress Updated Successfully");
                                    break;
                                case 4:
                                    Console.WriteLine("\nEnter new city name : ");
                                    string c = Console.ReadLine();
                                    value.city = c; // Update the city name of record in address book
                                    Console.WriteLine("\nCity Name Updated Successfully");
                                    break;
                                case 5:
                                    Console.WriteLine("\nEnter new state : ");
                                    string s = Console.ReadLine();
                                    value.state = s; // Update the state name of record in address book
                                    Console.WriteLine("\nState Name Updated Successfully");
                                    break;
                                case 6:
                                    Console.WriteLine("\nEnter new email : ");
                                    string e = Console.ReadLine();
                                    value.email = e; // Update the email name of record in address book
                                    Console.WriteLine("\nEmail Updated Successfully");
                                    break;
                                case 7:
                                    Console.WriteLine("\nEnter new Zip Code : ");
                                    int z = Convert.ToInt32(Console.ReadLine());
                                    value.zip = z; // Update the zipcode of record in address book
                                    Console.WriteLine("\nZip Code Updated Successfully");
                                    break;
                                case 8:
                                    Console.WriteLine("\nEnter new Phone Number : ");
                                    int p = Convert.ToInt32(Console.ReadLine());
                                    value.phoneNumber = p; // Update the phone number of record in address book
                                    Console.WriteLine("\nPhone Number Updated Successfully");
                                    break;
                                default:
                                    Console.WriteLine("\nEnter valid choice");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Record not found");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Address book not found");
                }                                                
            }
        }
        public void DeleteRecord(string ab)  // Creating class method to delete record which takes first name as parameter
        {
            foreach (var content in dict.Keys) // Accessing address book name by dictionary key
            {
                if (content == ab)  // Checking that address book name provied by user is matching with dictionary address book or not
                {
                    Console.WriteLine("\nEnter your First Name : ");
                    fn = Console.ReadLine(); // Store the user firstname in variable
                    Console.WriteLine("Enter your Last Name : ");
                    ln = Console.ReadLine();
                    foreach (var value in dict[content].ToList())  // Accessing all the record of address book by dictionary key
                    {
                        if (value.fName == fn && value.lName == ln) // Checking that first name and last name provided by user is matching with Existing Reord or not
                        {
                            Console.WriteLine("\nEnter your first name which you want to delete : ");
                            string f = Console.ReadLine(); // Store the user firstname in variable
                            dict[content].Remove(value); // Deleting all the details of one user in Address Book
                            Console.WriteLine("\nRecord Deleted Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Record not found");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Address book not found");
                }
            }
        }
        /// <summary>
        /// Display all the persons by state name
        /// </summary>
        /// <param name="sName"></param>
        public void DisplayPersonsByStateName(string sName)
        {
            foreach (var state in stateName)
            {
                if (sName.Equals(state))
                {
                    Console.WriteLine($"\nAll records present in multiple address books where state name \"{state}\" are : ");
                    foreach (var content in dict.Keys) // Accessing all the address book name of dictionary
                    {
                        Console.WriteLine("\n\nAddress Book : "+content);
                        int i = 1;
                        foreach (var value in dict[content].ToList()) // Accessing all the address book records  by dictionary key
                        {
                            if (value.state == state)
                            {
                                Console.WriteLine("\nRecord - "+i);
                                RecordsDisplay(value);
                                i++;
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Display all the persons by city name
        /// </summary>
        /// <param name="cName"></param>
        public void DisplayPersonsByCityName(string cName) // Class method to display all the records of all address book
        {
            foreach (var city in cityName)
            {
                if (cName.Equals(city))
                {
                    Console.WriteLine($"\nAll records present in multiple address books where city name \"{city}\" are : ");
                    foreach (var content in dict.Keys) // Accessing all the address book name of dictionary
                    {
                        Console.WriteLine("\n\nAddress Book : "+content);
                        int i = 1;
                        foreach (var value in dict[content].ToList()) // Accessing all the address book records  by dictionary key
                        {
                            if (value.city == city)
                            {
                                Console.WriteLine("\nRecord - "+i);
                                RecordsDisplay(value);
                                i++;
                            }
                        }
                    }
                }
            }
        }
        public void CityDictionary(string city) // class method to create new address book and store it in dictionary
        {

            if (recordsByCity.Count == 0) // Checking that dictionary is empty or not
            {
                recordsByCity.Add(city.ToLower(), new List<PersonInput>()); // // creating key value pair where address book name is key and all the redord of address book as value
            }
            else
            {
                if (recordsByCity.ContainsKey(city.ToLower())) // Checking that address book given by user is already present in dictionary or not
                {
                    Console.WriteLine("This AddressBook is also present");
                }
                else
                {
                    recordsByCity.Add(city.ToLower(), new List<PersonInput>()); // creating key value pair where address book name is key and all the redord of address book as value
                }
            }
        }
        public void AddPersonsInDictionaryByCityName()
        {
            foreach (var city in cityName)
            {
                CityDictionary(city);
                foreach (var citykey in recordsByCity.Keys)
                {
                    if (recordsByCity[city].Count == 0)
                    {
                        foreach (var content in dict.Keys)
                        {
                            foreach (var value in dict[content].ToList())
                            {
                                if (value.city == city)
                                {
                                    recordsByCity[city].Add(value);
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (var content in dict.Keys)
                        {
                            foreach (var value in dict[content].ToList())
                            {
                                if (value.city == city)
                                {
                                    recordsByCity[city].Add(value);
                                }
                            }
                        }
                    }

                }
            }
        }
        public void StateDictionary(string state) // class method to create new address book and store it in dictionary
        {

            if (recordsByState.Count == 0) // Checking that dictionary is empty or not
            {
                recordsByState.Add(state.ToLower(), new List<PersonInput>()); // // creating key value pair where address book name is key and all the redord of address book as value
            }
            else
            {
                if (recordsByState.ContainsKey(state.ToLower())) // Checking that address book given by user is already present in dictionary or not
                {
                    Console.WriteLine("This AddressBook is also present");
                }
                else
                {
                    recordsByState.Add(state.ToLower(), new List<PersonInput>()); // creating key value pair where address book name is key and all the redord of address book as value
                }
            }
        }
        public void AddPersonsInDictionaryByStateName()
        {
            foreach (var state in stateName)
            {
                StateDictionary(state);
                foreach (var statekey in recordsByCity.Keys)
                {
                    if (recordsByState[state].Count == 0)
                    {
                        foreach (var content in dict.Keys)
                        {
                            foreach (var value in dict[content].ToList())
                            {
                                if (value.state == state)
                                {
                                    recordsByState[state].Add(value);
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (var content in dict.Keys)
                        {
                            foreach (var value in dict[content].ToList())
                            {
                                if (value.state == state)
                                {
                                    recordsByState[state].Add(value);
                                }
                            }
                        }
                    }

                }
            }
        }
        /// <summary>
        /// Count the total number of persons by city name
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int CountPersonsByCity(string c)
        {
            foreach (var city in recordsByCity.Keys)
            {
                if(city.Equals(c.ToLower()))
                {
                    return recordsByCity[city].Count;
                }
            }
            return 0; 
        }
        /// <summary>
        /// Count the total number of persons by state name
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int CountPersonsByState(string s)
        {
            foreach (var state in recordsByState.Keys)
            {
                if (state.Equals(s.ToLower()))
                {
                    return recordsByState[state].Count;
                }
            }
            return 0;
        }
        /// <summary>
        /// Display all the records in alphabetically order by person first name
        /// </summary>
        public void SortByPersonName()
        {
            foreach (var content in dict.Keys.ToList())
            {
                dict[content] = dict[content].OrderBy(x => x.fName).ToList();
            }
        }
        /// <summary>
        /// Display all the records in alphabetically order by person city name
        /// </summary>
        public void SortByCity()
        {
            foreach (var content in dict.Keys.ToList())
            {
                dict[content] = dict[content].OrderBy(x => x.city).ToList();
            }
        }
        /// <summary>
        /// Display all the records in alphabetically order by person state name
        /// </summary>
        public void SortByState()
        {
            foreach (var content in dict.Keys.ToList())
            {
                dict[content] = dict[content].OrderBy(x => x.state).ToList();
            }
        }
        /// <summary>
        /// Display all the records order by person Zip code
        /// </summary>
        public void SortByZip()
        {
            foreach (var content in dict.Keys.ToList())
            {
                dict[content] = dict[content].OrderBy(x => x.zip).ToList();
            }
        }

    }
}
