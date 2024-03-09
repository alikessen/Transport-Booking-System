using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Documents.DocumentStructures;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sprint3
{
    public partial class MainWindow : Window
    {
        // Variables for the booking system, vehicles, and current user
        private BookingSystem bookingSystem;
        private List<Vehicle> vehicles;
        private User currentUser;

        public MainWindow()
        {
            InitializeComponent();

            // Initialize the BookingSystem and vehicle list
            bookingSystem = BookingSystem.GetInstance();
            vehicles = new List<Vehicle>();

            // Initialize the current user
            currentUser = new User("Kesen"); // Replace "YourUserName" with the desired name
            UpdateUserInfo(); // Update user information in the UI
        }

        // Method to update user information in the UI
        private void UpdateUserInfo()
        {
            txtUserName.Text = $"User: {currentUser.Name}"; // Display the user's name
            txtTotalPoints.Text = $"Points: {currentUser.GetTotalPoints()}"; // Display the user's total points
        }

        // Event handler for adding items to the UI elements
        private void AddItems_Click(object sender, RoutedEventArgs e)
        {
            // Clear existing items in the ListBox and ComboBox
            ListVehicles.Items.Clear();
            vehicleComboBox.Items.Clear();

            // Create instances of vehicles and add them to the list
            ElectricBike bike1 = new ElectricBike(111, "Park A", true, false, true);
            Scooter scooter1 = new Scooter(253, "Park B", true, true, false);
            Skateboard skateboard1 = new Skateboard(3754, "Park C", false, true, false);

            vehicles.Add(bike1);
            vehicles.Add(scooter1);
            vehicles.Add(skateboard1);

            //Add the vehicles to the GUI Listbox
            ListVehicles.Items.Add(bike1.GetInformation());
            ListVehicles.Items.Add(scooter1.GetInformation());
            ListVehicles.Items.Add(skateboard1.GetInformation());

            // Populate ListBox and ComboBox with vehicles
            foreach (var vehicle in vehicles)
            {
                // Add items to the ComboBox with dynamic display and value
                vehicleComboBox.Items.Add(vehicle.GetInformation());
            }

        }

        private void BookButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string selectedValue = vehicleComboBox.SelectedItem as string;

                if (selectedValue != null)
                {
                    Vehicle selectedVehicle = GetVehicleByDisplayValue(selectedValue);

                    if (selectedVehicle != null)
                    {
                        Booking(selectedVehicle);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string selectedValue = vehicleComboBox.SelectedItem as string;

                if (selectedValue != null)
                {
                    Vehicle selectedVehicle = GetVehicleByDisplayValue(selectedValue);

                    if (selectedVehicle != null)
                    {
                        Returning(selectedVehicle);
                    }
                }
             }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // Method to book the vehicle
        private void Booking(Vehicle vehicle)
        {
            Booking existingBooking = bookingSystem.GetBookingByVehicle(vehicle);

            if (existingBooking == null)
            {
                currentUser.AddLoyaltyPoints(10); // Award 10 loyalty points directly to the user
                UpdateUserInfo(); // Update user information after earning points

                //User user = new User("Ali"); 

                // Create a new booking
                Booking newBooking = new Booking(vehicle, currentUser);
                bookingSystem.Bookings.Add(newBooking);

                // Update availability status of the vehicle
                vehicle.Available = false;

                MessageBox.Show("You booked " + vehicle.GetInformation());
            }
            else
            {
                MessageBox.Show(vehicle.GetInformation() + " is already booked.");
            }
        }

        // Method to return the vehicle
        private void Returning(Vehicle vehicle)
        {
            Booking existingBooking = bookingSystem.GetBookingByVehicle(vehicle);

            if (existingBooking != null)
            {
                // Remove the booking
                bookingSystem.Bookings.Remove(existingBooking);

                // Update availability status of the vehicle
                vehicle.Available = true;

                MessageBox.Show("You returned " + vehicle.GetInformation());
            }
            else
            {
                MessageBox.Show(vehicle.GetInformation() + " is already returned.");
            }
        }

        // Helper method to get vehicle by its display value
        private Vehicle GetVehicleByDisplayValue(string displayValue)
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle.GetInformation() == displayValue)
                {
                    return vehicle;
                }
            }
            return null;
        }


    }
}