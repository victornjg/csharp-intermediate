using System;

namespace CSharpIntermediate
{
    partial class Program
    {

        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle() { Brand = "Boeing", Model = "777", MaxSpeed = 1037.232 };
            Flyable flyable = new Flyable();
            flyable.MaxHeight = 13716;
            Airplane airplane = new Airplane(vehicle1, flyable);

            airplane.Flyable.Fly();

            Vehicle vehicle2 = new Vehicle() { Brand = "Bugatti", Model = "Veyron", MaxSpeed = 431.072 };
            Walkable walkable = new Walkable();
            Car car = new Car(vehicle2, walkable);

            car.Walkable.Walk();
        }
    }
}
