class BookingSystem
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
}
