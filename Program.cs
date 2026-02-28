using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("--- Fleet Management Input System ---");


            Console.Write("Enter Bus ID (e.g., EB-01): ");
            string busId = Console.ReadLine();

            Console.Write("Enter Bus Model Name: ");
            string busName = Console.ReadLine();

            Console.Write("Enter Battery Percentage (0-100): ");
            if (!double.TryParse(Console.ReadLine(), out double battery))
                throw new FormatException("Please enter a valid number for energy levels.");

            Vehicle bus = new ElectricBus(busId, busName, battery);
            Console.WriteLine($"Bus {busName} (ID: {busId}) can travel {bus.CalculateRange()} km.");

            Console.WriteLine("\n-------------------------------");

            Console.Write("Enter Van ID (e.g., GV-05): ");
            string vanId = Console.ReadLine();

            Console.Write("Enter Van Model Name: ");
            string vanName = Console.ReadLine();

            Console.Write("Enter Fuel Level (Liters): ");
            if (!double.TryParse(Console.ReadLine(), out double fuel))
                throw new FormatException("Please enter a valid number for energy levels.");

            Vehicle van = new GasPoweredVan(vanId, vanName, fuel);
            Console.WriteLine($"Van {vanName} (ID: {vanId}) can travel {van.CalculateRange()} km.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Input Error: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Validation Error: {ex.Message}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"System Alert: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\nSession Ended. System Shutdown.");
        }
    }
}
