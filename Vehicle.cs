
namespace NeedForSpeed
{
    public class Vehicle
    {

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }
        public int HorsePower { get; set; }
        public double  Fuel { get; set; }
        public const double DefaultFuelConsumption = 1.25;
        public virtual double FuelConsumption
        { 
            get
            {
                return DefaultFuelConsumption;
            } 
           
        }
        public virtual void Drive(double kilometers)
        {
            Fuel -=  FuelConsumption * kilometers;
        }
    }
}
