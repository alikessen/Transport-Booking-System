internal class VehicleStateReturned : IBookingState
{

    // Method to book the vehicle
    public void Book(Booking booking)
    {
        booking.BookedVehicle.Available = false; // Set the vehicle's availability to false (booked)
        booking.ChangeState(new VehicleStateBooked()); // Change the state to 'VehicleStateBooked'
        Console.WriteLine($"{booking.User.Name} has booked {booking.BookedVehicle.Type} {booking.BookedVehicle.ID}.");
    }

    // Method to handle returning when the vehicle is already returned
    public void Return(Booking booking)
    {
        Console.WriteLine($"{booking.BookedVehicle.Type} {booking.BookedVehicle.ID} is already returned.");
    }
}