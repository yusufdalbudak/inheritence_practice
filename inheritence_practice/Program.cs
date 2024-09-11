using System;

// Interface for vehicles
public interface IVehicle
{
    string Brand { get; set; }
    string Model { get; set; }
    int Year { get; set; }

    void DisplayInfo();
    void Start();
}

// Abstract class for common vehicle features
public abstract class Vehicle : IVehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    // Constructor for common vehicle initialization
    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    // Abstract method for start behavior
    public abstract void Start();

    // Common display info method
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Vehicle: {Brand} {Model} ({Year})");
    }
}

// Class for Car, inherits from Vehicle
public class Car : Vehicle
{
    public string Color { get; set; }
    public double Mileage { get; set; }
    public string EngineType { get; set; }

    // Constructor to initialize car-specific fields
    public Car(string brand, string model, int year, string color, double mileage, string engineType)
        : base(brand, model, year)
    {
        Color = color;
        Mileage = mileage;
        EngineType = engineType;
    }

    // Polymorphic implementation of Start method
    public override void Start()
    {
        Console.WriteLine($"{Brand} {Model} is starting with a {EngineType} engine.");
    }

    // Overriding the DisplayInfo method to include car-specific details
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Color: {Color}, Mileage: {Mileage} km, Engine: {EngineType}");
    }
}

// Class for Truck, another vehicle type
public class Truck : Vehicle
{
    public double LoadCapacity { get; set; }

    // Constructor for truck-specific fields
    public Truck(string brand, string model, int year, double loadCapacity)
        : base(brand, model, year)
    {
        LoadCapacity = loadCapacity;
    }

    // Polymorphic implementation of Start method
    public override void Start()
    {
        Console.WriteLine($"{Brand} {Model} truck is starting with a load capacity of {LoadCapacity} tons.");
    }

    // Overriding the DisplayInfo method
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Load Capacity: {LoadCapacity} tons");
    }
}

// Program class for running the application
public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            // Create and display information for a car
            IVehicle myCar = new Car("Toyota", "Corolla", 2021, "Red", 15000.5, "Hybrid");
            myCar.DisplayInfo();
            myCar.Start();

            // Create and display information for a truck
            IVehicle myTruck = new Truck("Mercedes", "Actros", 2019, 18.0);
            myTruck.DisplayInfo();
            myTruck.Start();
        }
        catch (Exception ex)
        {
            // Exception handling for any runtime issues
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
