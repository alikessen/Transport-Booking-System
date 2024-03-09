internal class Booking
{
    public Vehicle BookedVehicle { get; set; }
    public User User { get; set; }
    private IBookingState currentState;


    public Booking(Vehicle vehicle, User user)
    {
        this.BookedVehicle = vehicle;
        this.User = user;
        this.currentState = new VehicleStateReturned();
    }

    // Method to change the state of the booking
    public void ChangeState(IBookingState newState)
    {
        currentState = newState;
    }

    public void Book()
    {
        if (currentState is VehicleStateReturned)
        {
            currentState.Book(this);
            User.AddLoyaltyPoints(10); // Award 10 loyalty points directly to the user
            Console.WriteLine($"{User.Name} has earned 10 loyalty points."); // Notify about earned points
        }
        else
        {
            currentState.Book(this);
        }
    }

    public void Return()
    {
        currentState.Return(this);
    }

}