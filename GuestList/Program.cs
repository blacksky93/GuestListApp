using GuestListMethods;


public class Program
{
    static void Main(string[] args)
    {
        GuestList.SayHelloToUser();
        List<(string name, int guestCount)> GuestLists = GuestList.GetListOfNamesAndGuestNumber();
        GuestList.PrintListOfNamesAndGuestNumbers(GuestLists);
        GuestList.PrintTotalNumberOfGuests(GuestLists);
        GuestList.SayGoodbyToUser();
    }
}

