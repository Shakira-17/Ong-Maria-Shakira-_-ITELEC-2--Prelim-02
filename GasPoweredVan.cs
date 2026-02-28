using System;

public class GasPoweredVan : Vehicle
{
    private double fuel;
    public double Fuel
    {
        get => fuel;
        set
        {
            if (value < 0 || value > 100)
                throw new ArgumentException("Fuel level must be between 0-100.");
            fuel = value;
        }
    }

    public GasPoweredVan(string id, string name, double fuel) : base(id, name)
    {
        Fuel = fuel;
    }

    public override double CalculateRange()
    {
        if (Fuel < 5)
            throw new InvalidOperationException("Fuel too low!");
        return Fuel * 100; // Example logic
    }
}
