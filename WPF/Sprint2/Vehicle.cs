internal class Vehicle
{
    public int ID { get; set; }
    public string Type { get; set; }
    public string Location { get; set; }
    public bool Available { get; set; }

    public Vehicle(int id, string type, string location)
    {
        this.ID = id;
        this.Type = type;
        this.Location = location;
        this.Available = true;
    }

    // Virtual method to print details of the vehicle
    public virtual void Print()
    {
        Console.WriteLine($"ID: {ID}, Type: {Type}, Location: {Location}, Available: {Available}");
    }

    public string GetInformation()
    {
        return $"Vehicle ID: {ID}, Type: {Type}, Location: {Location}";
    }
}
