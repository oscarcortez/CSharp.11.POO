namespace Models
{
    using System;
    public class Vehicle
    {
        public decimal MaxVelocity { get; set; }
        public int WheelQuantity { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public Vehicle()
        {
        }

        public Vehicle(decimal maxVelocity, int wheelQuantity, string brand, string model)
        {
            MaxVelocity = maxVelocity;
            WheelQuantity = wheelQuantity;
            Brand = brand;
            Model = model;
        }

        public override string ToString()
        {
            return $"MaxVelocity: {MaxVelocity}, WheelQuantity: {WheelQuantity}, Brand: {Brand}, Model: {Model}";
        }
    }
}

