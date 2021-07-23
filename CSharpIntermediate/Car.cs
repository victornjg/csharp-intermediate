namespace CSharpIntermediate
{
    partial class Program
    {
        public class Car
        {
            public readonly Vehicle Vehicle;
            public readonly Walkable Walkable;

            public Car(Vehicle vehicle, Walkable walkable)
            {
                this.Vehicle = vehicle;
                this.Walkable = walkable;
            }
        }
    }
}
