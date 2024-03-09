# Transport-Booking-System
Developed Shared Transport Booking System in C#, applying OOP principles, iterative development, and professional planning. Utilized WPF for GUI, integrated F# for bookable items, and introduced a loyalty points system for enhanced user engagement.

# Shared Transport Booking System - C# Part

## Overview

This C# part of the Shared Transport Booking System is a comprehensive solution for managing bookings of electric transport items. The system utilizes object-oriented principles, emphasizing readability, maintainability, and adherence to coding standards.

## Features

- Booking class to manage reservations, users, and booking states.
- BookingSystem class as a singleton instance to store and manage bookings.
- Interface (IBookingState) to define booking states.
- ElectricBike, Scooter, and Skateboard classes representing different types of vehicles.
- Loyalty points system to enhance user engagement.
- Main Program demonstrating the functionality of booking, returning, and checking status.

## How to Use

1. **Instantiate Vehicles:**
   - Create instances of ElectricBike, Scooter, and Skateboard with relevant details.

2. **Create Users:**
   - Instantiate User objects with unique names.

3. **Initialize Bookings:**
   - Use the Booking class to create bookings by associating vehicles with users.

4. **Access Booking System:**
   - Utilize the BookingSystem class to store and manage bookings.

5. **Run the Program:**
   - Execute the Program class to observe booking, returning, and status checking functionality.

## Code Structure

- **Booking.cs:** Manages the booking process, including states and user loyalty points.
- **BookingSystem.cs:** Singleton class for managing bookings within the system.
- **IBookingState.cs:** Interface defining methods for booking states.
- **ElectricBike.cs, Scooter.cs, Skateboard.cs:** Vehicle classes with specific details and status methods.
- **User.cs:** Class representing system users with loyalty points.
- **VehicleStateBooked.cs, VehicleStateReturned.cs:** Classes implementing the IBookingState interface for different booking states.
- **Vehicle.cs:** Base class representing common properties and methods for all types of vehicles.

## Execution

Run the Program class to see a demonstration of the booking system in action, including vehicle information, booking, returning, and status checking.

## Contributors

- Ali Kesen

