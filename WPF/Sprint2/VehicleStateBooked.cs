internal class VehicleStateBooked : IBookingState
{

    // Method to handle booking when the vehicle is already booked
    public void Book(Booking booking)
    {
        Console.WriteLine($"{booking.BookedVehicle.Type} {booking.BookedVehicle.ID} is already booked.");
    }

    // Method to return the vehicle
    public void Return(Booking booking)
    {
        booking.BookedVehicle.Available = true; // Set the vehicle's availability to true (returned)
        booking.ChangeState(new VehicleStateReturned()); // Change the state to 'VehicleStateReturned'
        Console.WriteLine($"{booking.BookedVehicle.Type} {booking.BookedVehicle.ID} is returned by {booking.User.Name}.");
    }
}
