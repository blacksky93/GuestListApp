using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestListMethods
{
    public class GuestList
    {
        public static (string name, int guestCount) AskUserForNameAndGuestNumber()
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            if (name == "")
            {
                return ("", 0);
            }
            int guestCount = validateGuestCount();
            return (name, guestCount);
        }

        public static int validateGuestCount()
        {
            Console.Write("Please enter number of members in your party: ");
            bool isValid = int.TryParse(Console.ReadLine(), out int guestCount);
            while (isValid != true)
            {
                Console.WriteLine("Please enter a valid integer");
                isValid = int.TryParse(Console.ReadLine(), out guestCount);
            }
            return guestCount;
        }

        public static List<(string name, int guestCount)> GetListOfNamesAndGuestNumber()
        {
            string answer = string.Empty;
            List<(string name, int guestCount)> guestAndCount = new List<(string name, int guestCount)>();
            do
            {
                (string name, int guestCount) guest = AskUserForNameAndGuestNumber();
                if (guest.name == "")
                {
                    answer = guest.name;
                    break;
                }
                answer = guest.name;
                guestAndCount.Add(guest);
                answer = IsThatAllGuests();
            }
            while (answer != "yes");
            return guestAndCount;
        }

        public static void PrintListOfNamesAndGuestNumbers(List<(string name, int guestCount)> listOfGuests)
        {
            foreach (var guest in listOfGuests)
            {
                Console.WriteLine($"{guest.name}, party of {guest.guestCount}. Your table is ready.");
            }
        }

        public static void PrintTotalNumberOfGuests(List<(string name, int guestCount)> listOfGuests)
        {
            int guestTotal = 0;
            foreach (var guest in listOfGuests)
            {
                guestTotal = guest.guestCount + guestTotal;
            }
            Console.WriteLine($"Total Guests is {guestTotal}");
        }

        public static string IsThatAllGuests()
        {
            Console.WriteLine("Is that all guests? Write yes/no.");
            string answer = Console.ReadLine().ToLower();
            while (answer != "yes" && answer != "no")
            {
                Console.WriteLine("Please answer with yes or no.");
                Console.WriteLine("Is that all guests? Write yes/no.");
                answer = Console.ReadLine().ToLower();
            }
            return answer;
        }

        public static void SayHelloToUser()
        {
            Console.WriteLine("Hello user, welcome to Guest List app.");
        }

        public static void SayGoodbyToUser()
        {
            Console.WriteLine("Goodbye user, thanks for using the Guest List app.");
        }
    }
}
