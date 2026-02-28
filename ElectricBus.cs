using System;

public class ElectricBus : Vehicle
{
    private double battery;
    public double Battery
    {
        get => battery;
        set
        {
            if (value < 0 || value > 100)
                throw new ArgumentException("Battery % must be between 0-100.");
            battery = value;
        }
    }

    public ElectricBus(string id, string name, double battery) : base(id, name)
    {
        Battery = battery;
    }

    public override double CalculateRange()
    {
        if (Battery < 5)
            throw new InvalidOperationException("Battery too low!");
        return Battery * 2; // Example logic
    }
}
