using ParkingSystemApp.Constant;
using ParkingSystemApp.Models;

namespace ParkingSystemApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            // ParkingLot parkingLot = new ParkingLot(6);
            //
            // Console.WriteLine(
            //         parkingLot.Park("B-1234-XYZ Putih Mobil")
            //     );
            //
            // Console.WriteLine(
            //     parkingLot.Park("B-1234-XYZ Putih Mobil")
            // );
            //
            // // Console.WriteLine(parkingLot.Leave(1));
            // Console.WriteLine(parkingLot.Status());
            // Console.WriteLine(parkingLot.CountVehicleType("motor"));
            // Console.WriteLine(parkingLot.CountVehicleType("mobil"));
            // Console.WriteLine(parkingLot.OddRegistrationNumber());
            // Console.WriteLine(parkingLot.EvenRegistrationNumber());
            // Console.WriteLine(parkingLot.ColorRegistrationNumber("putih"));
            // Console.WriteLine(parkingLot.ColorSlotNumber("putih"));
            // Console.WriteLine(parkingLot.FindRegistrationNumber("b-1234-xyza"));
            //
            Menu menu = new Menu();
            menu.DisplayMenu();
        }
    }
}