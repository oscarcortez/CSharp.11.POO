using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Motorcycle : Vehicle
    {
        public int Displacement { get; set; }

        public Motorcycle(): base()
        {
        }

        public Motorcycle(int displacement, decimal maxVelocity, int wheelQuantity, string brand, string model) : base(maxVelocity, wheelQuantity, brand, model)
        {
            Displacement = displacement;
        }

        public override string ToString()
        {
            return $"MaxVelocity: {MaxVelocity}, WheelQuantity: {WheelQuantity}, Brand: {Brand}, Model: {Model}, Displacement: {Displacement}";
        }
    }
}
