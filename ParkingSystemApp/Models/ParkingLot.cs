using ParkingSystemApp.Constant;

namespace ParkingSystemApp.Models;

public class ParkingLot
{
    public int Capacity { get; private set; }
    public Dictionary<int, Vehicle> Slots { get; set; }

    public ParkingLot(int capacity)
    {
        Capacity = capacity;
        Slots = new Dictionary<int, Vehicle>();
    }

    public string Park(string vehicleData)
    {
        if (Slots.Count >= Capacity)
            return "Sorry, parking lot is full";
        
        string[] vehicleSplit = vehicleData.Split(" ");
        Vehicle vehicle; 
        
        if (vehicleSplit[2].ToLower().Equals("mobil"))
            vehicle = new Car(vehicleSplit[0], vehicleSplit[1], 1);
        else if (vehicleSplit[2].ToLower().Equals("motor"))
            vehicle = new Motorcycle(vehicleSplit[0], vehicleSplit[1], 1);
        else 
            return "Invalid vehicle type";
        
        if (Slots.Values.Any(item => item.RegistrationNumber == vehicle.RegistrationNumber))
            return "Vehicle with this registration number already parked"; ;
        
        int slotNumber = Enumerable.Range(1, Capacity).First(item => !Slots.ContainsKey(item));
        Slots.Add(slotNumber, vehicle);
        
        return $"Allocated slot number: {slotNumber}";
    }

    public string Leave(int slotNumber)
    {
        if (!Slots.ContainsKey(slotNumber))
            return "Slot is already free";
        
        Slots.Remove(slotNumber);
        return $"Slot number {slotNumber} is free";
    }

    public string Status()
    {
        if (Slots.Count == 0) 
            return "Parking Lot is empty";
        
        var status = "Slot No.   Registration Number     Type    Color\n";
        foreach (var slot in Slots)
        {
            var vehicle = slot.Value;
            status += $"{slot.Key}          {vehicle.RegistrationNumber}              {vehicle.Type}     {vehicle.Color}\n";
        }
        
        return status;
    }

    public string CountVehicleType(string type)
    {
        if (type != "motor" && type != "mobil") return "Invalid vehicle type";
        
        int motorcycleCount = 0;
        int carCount = 0;
        
        foreach (var slot in Slots)
        {
            if (slot.Value.Type.Equals(VehicleType.Motorcycle))
                motorcycleCount++;
            else 
                carCount++;
        }
        
        return type == "motor" ? motorcycleCount.ToString() : carCount.ToString();
    }

    public string OddRegistrationNumber()
    {
        List<string> oddRegistrationNumber = new List<string>();
        
        foreach (var slot in Slots)
        {
            if (int.Parse(slot.Value.RegistrationNumber.Split("-")[1]) % 2 == 1)
            {
                oddRegistrationNumber.Add(slot.Value.RegistrationNumber);
            }
        }
        
        if (oddRegistrationNumber.Count == 0) return "There is no odd registration";

        return string.Join(",", oddRegistrationNumber);
    }
    
    public string EvenRegistrationNumber()
    {
        List<string> evenRegistrationNumber = new List<string>();
        
        foreach (var slot in Slots)
        {
            if (int.Parse(slot.Value.RegistrationNumber.Split("-")[1]) % 2 == 0)
            {
                evenRegistrationNumber.Add(slot.Value.RegistrationNumber);
            }
        }
        
        if (evenRegistrationNumber.Count == 0) return "There is no even registration";

        return string.Join(",", evenRegistrationNumber);
    }
    
    public string ColorRegistrationNumber(string color)
    {
        List<string> registrationNumber = new List<string>();
        
        foreach (var slot in Slots)
        {
            if (slot.Value.Color.ToLower() == color)
                registrationNumber.Add(slot.Value.RegistrationNumber);
        }
        
        if (registrationNumber.Count == 0) return "There is no vehicle with that color registered";

        return string.Join(",", registrationNumber);
    }

    public string ColorSlotNumber(string color)
    {
        List<string> slotNumbers = new List<string>();
        
        foreach (var slot in Slots)
        {
            if (slot.Value.Color.ToLower() == color)
                slotNumbers.Add(slot.Key.ToString());
        }
        
        if (slotNumbers.Count == 0) return "There is no vehicle with that color registered";

        return string.Join(",", slotNumbers);
    }

    public string FindRegistrationNumber(string registrationNumber)
    {
        foreach (var slot in Slots)
        {
            if(slot.Value.RegistrationNumber.ToLower().Equals(registrationNumber.ToLower()))
                return slot.Key.ToString();
        }

        return $"Vehicle with {registrationNumber} Not found!";
    }
}