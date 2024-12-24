using ParkingSystemApp.Constant;

namespace ParkingSystemApp.Models;

public class Motorcycle : Vehicle
{
    private static decimal ParkingFeePerHour { get; set; } = 3000;
    
    public Motorcycle(string registrationNumber, string color, int parkedHours)
        : base(registrationNumber, VehicleType.Motorcycle, color, parkedHours)
    {
    }

    public override decimal CalculateTotalParkingFee()
    {
        return ParkedHours * ParkingFeePerHour;
    }

    public static void SetParkingFeePerHour(decimal parkingFeePerHour)
    {
        ParkingFeePerHour = parkingFeePerHour;
    }
    
    public override string ToString()
    {
        return $"\nRegistration Number: {RegistrationNumber}" +
               $"\nType: {Type}" +
               $"\nColor: {Color}" + 
               $"\nParked Hours: {ParkedHours}" +
               $"\nParking Fee: {ParkingFeePerHour}" + 
               $"\nTotal Parking Fee: {CalculateTotalParkingFee()}";
    }
}