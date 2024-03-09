internal class Scooter : Vehicle
{
    public bool HelmetRequired { get; set; }
    public bool KneePadsRequired { get; set; }
    public bool GlovesRequired { get; set; }

    public Scooter(int id, string location, bool helmetRequired, bool kneePadsRequired, bool glovesRequired)
        : base(id, "Scooter", location)
    {
        this.HelmetRequired = helmetRequired;
        this.KneePadsRequired = kneePadsRequired;
        this.GlovesRequired = glovesRequired;
    }

    // Method to get the status of the scooter (Available or Booked)
    public string GetStatus()
    {
        return Available ? "Available" : "Booked";
    }

    public string GetInformation()
    {
        string status = GetStatus();
        string requiredGear = $"Helmet {(HelmetRequired ? "Required" : "Not Required")}, Knee Pads {(KneePadsRequired ? "Required" : "Not Required")}, Gloves {(GlovesRequired ? "Required" : "Not Required")}";

        return $"Scooter ID: {ID}, Type: {Type}, Location: {Location}, Status: {status}, Gear: {requiredGear}";
    }

    // Override the Print method of the base class (Vehicle) to include Scooter specific information
    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Helmet Required: {HelmetRequired}, Knee Pads Required: {KneePadsRequired}, Gloves Required: {GlovesRequired}");
    }
}
