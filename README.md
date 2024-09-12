# Simple Vehicle Management System

This project demonstrates a simple, object-oriented vehicle management system in C#. 
It includes various types of vehicles, such as cars and trucks, with a common interface and shared behavior. 
It uses features like interfaces, inheritance, and polymorphism to create a flexible and extensible code structure.

# Features

Interface (IVehicle): Defines common behavior for vehicles, including displaying information and starting the vehicle.

Abstract Class (Vehicle): Implements common features for all vehicles, such as brand, model, and year.

Inheritance: Different types of vehicles (e.g., Car, Truck) inherit from the Vehicle class and add their own unique attributes.

Polymorphism: The system uses polymorphism to handle different types of vehicles in a uniform way.
Error Handling: Basic error handling is implemented using try-catch blocks.

# How It Works

The IVehicle interface defines the basic structure for all vehicles, with properties for the brand, model, and year, as well as methods to display information and start the vehicle.

The Vehicle class implements the common properties and methods that all vehicles share. It is an abstract class, meaning it cannot be instantiated directly but serves as a base for other vehicle types.

The Car and Truck classes inherit from Vehicle and extend it by adding their own specific attributes, like color and engine type for cars, and load capacity for trucks.

The Program class contains the main logic for creating and interacting with the vehicles.


# Usage


    git clone https://github.com/yourusername/vehicle-management-system.git


## Compile and Run
Open the project in your preferred IDE (e.g., Visual Studio, VS Code) or navigate to the project folder using the terminal and run the following command:

    dotnet run
    
The program will display information about the car and truck, and simulate starting both vehicles.




















