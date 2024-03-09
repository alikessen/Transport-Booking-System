class User
{
    public string Name { get; set; }
    public int LoyaltyPoints { get; set; }

    public User(string name)
    {
        this.Name = name;
    }

    // Method to add loyalty points to the user's total
    public void AddLoyaltyPoints(int points)
    {
        LoyaltyPoints += points;
    }

    // Method to get the total loyalty points of the user
    public int GetTotalPoints()
    {
        return LoyaltyPoints;
    }

}