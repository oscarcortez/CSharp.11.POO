using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class DuckToy
    {
        public Duck Duck { get; set; }
        public Toy Toy { get; set; }

        public DuckToy(Duck duck = default, Toy toy = default)
        {            
            Duck = duck;
            Toy = toy;            
        }

        public DuckToy(string color, string race, string material, int quantityBateries)
        {
            Duck = new Duck()
            {
                Color = color,
                Race = race                
            };

            Toy = new Toy()
            {
                Material = material,
                QuantityBateries = quantityBateries
            };            
        }

        public override string ToString()
        {
            return $"duck: {Duck.ToString()}, toy: {Toy.ToString()}";
        }
    }
}
