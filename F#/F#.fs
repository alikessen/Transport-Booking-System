// Define a base class 'Vehicle' with common properties and a default print method
type Vehicle(id : int, typ : string, location : string, available : bool) =
    member this.ID = id
    member this.Type = typ
    member this.Location = location
    member this.Available = available
    abstract member printA: unit
    default this.printA = printfn $"PrintDefault: {this.Type} with ID {this.ID}, located at {this.Location}, available: {this.Available}"

// Define derived classes for specific vehicle types

type ElectricBike(id : int, location : string, helmetRequired : bool, kneePadsRequired : bool, glovesRequired : bool) =
    inherit Vehicle(id, "Electric Bike", location, true)
    member this.HelmetRequired = helmetRequired
    member this.KneePadsRequired = kneePadsRequired
    member this.GlovesRequired = glovesRequired
    override this.printA = printfn $"ElectricBike: ID {this.ID}, Location: {this.Location}, Availability: {this.Available}, Helmet Required: {this.HelmetRequired}, Knee Pads Required: {this.KneePadsRequired}, Gloves Required: {this.GlovesRequired}"

type Scooter(id : int, location : string, helmetRequired : bool, kneePadsRequired : bool, glovesRequired : bool) =
    inherit Vehicle(id, "Scooter", location, true)
    member this.HelmetRequired = helmetRequired
    member this.KneePadsRequired = kneePadsRequired
    member this.GlovesRequired = glovesRequired
    override this.printA = printfn $"Scooter: ID {this.ID}, Location: {this.Location}, Availability: {this.Available}, Helmet Required: {this.HelmetRequired}, Knee Pads Required: {this.KneePadsRequired}, Gloves Required: {this.GlovesRequired}"

type Skateboard(id : int, location : string, helmetRequired : bool, kneePadsRequired : bool, glovesRequired : bool) =
    inherit Vehicle(id, "Skateboard", location, true)
    member this.HelmetRequired = helmetRequired
    member this.KneePadsRequired = kneePadsRequired
    member this.GlovesRequired = glovesRequired
    override this.printA = printfn $"Skateboard: ID {this.ID}, Location: {this.Location}, Availability: {this.Available},  Helmet Required: {this.HelmetRequired}, Knee Pads Required: {this.KneePadsRequired}, Gloves Required: {this.GlovesRequired}"

// Create instances of each vehicle type

let bike1 = ElectricBike(111, "Park A", true, false, true)
let scooter1 = Scooter(253, "Park B", true, true, false)
let skateboard1 = Skateboard(3754, "Park C", false, true, false)

// Print details of each vehicle using their overridden printA method

bike1.printA
scooter1.printA
skateboard1.printA


