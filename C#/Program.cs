//Ali Kesen  KES22601948


class Program
{
    static void Main(string[] args)
    {
        ElectricBike bike1 = new ElectricBike(111, "Park A", true, false, true);
        Scooter scooter1 = new Scooter(253, "Park B", true, true, false);
        Skateboard skateboard1 = new Skateboard(3754, "Park C", false, true, false);

        //Creating users
        User user1 = new User("Ali");
        User user2 = new User("Melissa");
        User user3 = new User("Bob");

        // Creating bookings
        Booking booking1 = new Booking(bike1, user1);
        Booking booking2 = new Booking(scooter1, user2);
        Booking booking3 = new Booking(skateboard1, user3);

        BookingSystem bookingSystem = BookingSystem.GetInstance();
        bookingSystem.Bookings.Add(booking1);
        bookingSystem.Bookings.Add(booking2);
        bookingSystem.Bookings.Add(booking3);

        //Vehicle information
        bike1.Print();
        scooter1.Print();
        skateboard1.Print();

        Console.WriteLine($"*************************************************************************");

        //Booking and Returning
        booking1.Book();
        booking1.Book(); // Trying to book the same item
        booking1.Return();
        booking1.Book();

        booking2.Book();
        booking2.Return();

        booking3.Return(); // Trying to return before book
        booking3.Book();
        booking3.Return();

        Console.WriteLine($"************************************");

        //Getting current status of vehicles
        Console.WriteLine($"Status of bike1: {bike1.GetStatus()}");
        Console.WriteLine($"Status of scooter1: {scooter1.GetStatus()}");
        Console.WriteLine($"Status of skateboard1: {skateboard1.GetStatus()}");

        Console.WriteLine($"************************************");

        //Getting total points for users
        Console.WriteLine($"Total points for {user1.Name}: {user1.GetTotalPoints()}"); 
        Console.WriteLine($"Total points for {user2.Name}: {user2.GetTotalPoints()}"); 
        Console.WriteLine($"Total points for {user3.Name}: {user3.GetTotalPoints()}"); 

    }
}