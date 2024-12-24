using ParkingSystemApp.Constant;

namespace ParkingSystemApp.Models;

public abstract class Vehicle
{
    public string RegistrationNumber {get; protected set;}
    public VehicleType Type {get; protected set;}
    public string Color {get; protected set;}
    public int ParkedHours {get; protected set;}

    public Vehicle(string registrationNumber, VehicleType type, string color, int parkedHours)
    {
        RegistrationNumber = registrationNumber;
        Type = type;
        Color = color;
        ParkedHours = parkedHours;
    }
    
    public abstract decimal CalculateTotalParkingFee();
}