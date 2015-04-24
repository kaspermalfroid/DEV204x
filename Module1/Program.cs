using System;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = String.Empty;
            string lastName;
            DateTime birthDate;
            string addressLine1;
            string addressLine2;
            string city;
            string province;
            int postalCode;
            string country;
            string major;
            bool studentClubMember;
            
            Console.WriteLine("Enter one or more first names (press Enter to exit):");
            string tempName = String.Empty;
            do
            {
                Console.Write("\t");
                tempName = Console.ReadLine();
                if (!String.IsNullOrEmpty(tempName) && String.IsNullOrEmpty(firstName))
                    firstName = tempName; // If firstName is still empty and a valid string is provided, initialize firstName
                else if (!String.IsNullOrEmpty(tempName))
                    firstName = firstName + ' ' + tempName; // For more first names we need a space
            } while (String.IsNullOrEmpty(firstName) || !String.IsNullOrEmpty(tempName)); // Keep on going until you run out of first names
            Console.WriteLine("Enter last name:");
            Console.Write("\t");
            lastName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Your first name(s) is/are {0} and your last name is {1}.", firstName, lastName);
            Console.ReadKey(); // Keep console open until key is pressed
        }
    }
}
