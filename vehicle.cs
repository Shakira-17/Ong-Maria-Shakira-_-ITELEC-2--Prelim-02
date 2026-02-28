using System;

public abstract class Vehicle
{
    public string VehicleID { get; private set; }
    public string ModelName { get; private set; }

    public Vehicle(string id, string name)
    {
        VehicleID = id;
        ModelName = name;
    }

    public abstract double CalculateRange();
}
