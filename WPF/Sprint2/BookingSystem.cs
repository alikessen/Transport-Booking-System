internal class BookingSystem
{
    private static BookingSystem instance;

    // List to store bookings within the booking system
    public List<Booking> Bookings { get; set; }

    private BookingSystem()
    {
        Bookings = new List<Booking>();
    }

    // Method to get the singleton instance of BookingSystem
    public static BookingSystem GetInstance()
    {
        if (instance == null)
        {
            instance = new BookingSystem();
        }
        return instance;
    }

    // Method to get a booking based on the provided vehicle
    public Booking GetBookingByVehicle(Vehicle vehicle)
    {
        foreach (var booking in Bookings)
        {
            if (booking.BookedVehicle == vehicle)
            {
                return booking;
            }
        }
        return null; // Return null if no booking is found for the provided vehicle
    }
}
