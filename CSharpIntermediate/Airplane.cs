namespace CSharpIntermediate
{
    partial class Program
    {
        public class Airplane
        {
            public readonly Vehicle Vehicle;
            public readonly Flyable Flyable;

            public Airplane(Vehicle vehicle, Flyable flyable)
            {
                this.Vehicle = vehicle;
                this.Flyable = flyable;
            }
        }
    }
}
