using ParkingSystemApp.Models;

namespace ParkingSystemApp;

public class Menu
{
    public void DisplayMenu()
    {
        ParkingLot parkingLot = null;
        
        while (true)
        {
            Console.WriteLine("===================================== Menu =====================================");
            Console.WriteLine("[1]. Buat Tempat Parkir");
            Console.WriteLine("[2]. Kendaraan Parkir");
            Console.WriteLine("[3]. Kendaraan Keluar");
            Console.WriteLine("[4]. Status Tempat Parkir");
            Console.WriteLine("[5]. Hitung Kendaraan Motor yang Parkir");
            Console.WriteLine("[6]. Hitung Kendaraan Mobil yang Parkir");
            Console.WriteLine("[7]. Tampilkan Semua Kendaraan Dengan Nomor Polisi Ganjil");
            Console.WriteLine("[8]. Tampilkan Semua Kendaraan Dengan Nomor Polisi Genap");
            Console.WriteLine("[9]. Tampilkan Semua Kendaraan Berdasarkan Nomor Polisi Berdasarkan Warna");
            Console.WriteLine("[10]. Tampilkan Semua Kendaraan Berdasarkan Nomor Slot Berdasarkan Warna");
            Console.WriteLine("[11]. Cari Kendaraan Berdasarkan Nomor Polisi");
            Console.WriteLine("[99]. Keluar");
            Console.WriteLine("================================================================================");

            
            Console.Write("=> Pilih Menu: ");
            var input = Console.ReadLine()?.Trim();
            
            switch (input)
            {
                case "1":
                    if (parkingLot != null)
                    {
                        Console.WriteLine("Tempat Parkir Sudah Dibuat, Keluar Untuk Membuat Yang Baru!");
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("[1]. Buat Tempat Parkir");
                    Console.Write("Masukkan Jumlah Slot Parkiran: ");
                    var capacity = Console.ReadLine()?.Trim();
                    Console.WriteLine(capacity);
                    parkingLot = new ParkingLot(int.Parse(capacity));
                    Console.WriteLine($"Created a parking lot with {capacity} slots");
                    break;
                case "2":
                    if (parkingLot == null)
                    {
                        Console.WriteLine("Buat Tempat Parkir Dulu");
                        break;
                    };
                    Console.Clear();
                    Console.WriteLine("[2]. Kendaraan Parkir");
                    Console.WriteLine("Masukkan Data Kendaraan Anda");
                    Console.Write("Masukkan Nomor Polisi [B-8080-YY]: ");
                    var registrationNumber = Console.ReadLine()?.Trim();
                    Console.Write("Masukkan Warna Kendaraan: ");
                    var color = Console.ReadLine()?.Trim();
                    Console.Write("Masukkan Tipe Kendaraan [Mobil/Motor]: ");
                    var type = Console.ReadLine()?.Trim();
                    Console.WriteLine(parkingLot.Park($"{registrationNumber} {color} {type}"));
                    break;
                case "3":
                    if (parkingLot == null)
                    {
                        Console.WriteLine("Buat Tempat Parkir Dulu");
                        break;
                    };
                    Console.Clear();
                    Console.WriteLine("[3]. Kendaraan Keluar");
                    Console.WriteLine("Masukkan Slot Parkir Kendaraan Yang Keluar: ");
                    var leave = Console.ReadLine()?.Trim();
                    Console.WriteLine(parkingLot.Leave(int.Parse(leave)));
                    break;
                case "4":
                    if (parkingLot == null)
                    {
                        Console.WriteLine("Buat Tempat Parkir Dulu");
                        break;
                    };
                    Console.Clear();
                    Console.WriteLine("[4]. Status Tempat Parkir");
                    Console.WriteLine(parkingLot.Status());
                    break;
                case "5":
                    if (parkingLot == null)
                    {
                        Console.WriteLine("Buat Tempat Parkir Dulu");
                        break;
                    };
                    Console.Clear();
                    Console.WriteLine("[5]. Hitung Kendaraan Motor yang Parkir");
                    Console.WriteLine(parkingLot.CountVehicleType("motor"));
                    break;
                case "6":
                    if (parkingLot == null)
                    {
                        Console.WriteLine("Buat Tempat Parkir Dulu");
                        break;
                    };
                    Console.Clear();
                    Console.WriteLine("[6]. Hitung Kendaraan Mobil yang Parkir");
                    Console.WriteLine(parkingLot.CountVehicleType("mobil"));
                    break;
                case "7":
                    if (parkingLot == null)
                    {
                        Console.WriteLine("Buat Tempat Parkir Dulu");
                        break;
                    };
                    Console.Clear();
                    Console.WriteLine("[7]. Tampilkan Semua Kendaraan Dengan Nomor Polisi Ganjil");
                    Console.WriteLine(parkingLot.OddRegistrationNumber());
                    break;
                case "8":
                    if (parkingLot == null)
                    {
                        Console.WriteLine("Buat Tempat Parkir Dulu");
                        break;
                    };
                    Console.Clear();
                    Console.WriteLine("[8]. Tampilkan Semua Kendaraan Dengan Nomor Polisi Genap");
                    Console.WriteLine(parkingLot.EvenRegistrationNumber());
                    break;
                case "9":
                    if (parkingLot == null)
                    {
                        Console.WriteLine("Buat Tempat Parkir Dulu");
                        break;
                    };
                    Console.Clear();
                    Console.WriteLine("[9]. Tampilkan Semua Kendaraan Berdasarkan Nomor Polisi Berdasarkan Warna");
                    Console.Write("Masukkan Warna Yang Ingin Dicari: ");
                    var findColor = Console.ReadLine()?.Trim();
                    Console.WriteLine(parkingLot.ColorRegistrationNumber(findColor));
                    break;
                case "10":
                    if (parkingLot == null)
                    {
                        Console.WriteLine("Buat Tempat Parkir Dulu");
                        break;
                    };
                    Console.Clear();
                    Console.WriteLine("[10]. Tampilkan Semua Kendaraan Berdasarkan Nomor Slot Berdasarkan Warna");
                    Console.Write("Masukkan Warna Yang Ingin Dicari: ");
                    var findColorSlot = Console.ReadLine()?.Trim();
                    Console.WriteLine(parkingLot.ColorSlotNumber(findColorSlot));
                    break;
                case "11":
                    if (parkingLot == null)
                    {
                        Console.WriteLine("Buat Tempat Parkir Dulu");
                        break;
                    };
                    Console.Clear();
                    Console.WriteLine("[11]. Cari Kendaraan Berdasarkan Nomor Polisi");
                    Console.Write("Masukkan Nomor Polisi Yang Ingin Dicari: ");
                    var regNumber = Console.ReadLine()?.Trim();
                    Console.WriteLine(parkingLot.FindRegistrationNumber(regNumber));
                    break;
                case "99":
                    return;
                default:
                    Console.WriteLine("Menu tidak valid");
                    break;
            }
        }
    }
}