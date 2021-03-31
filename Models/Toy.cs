using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Toy
    {
        public int QuantityBateries { get; set; }
        public string Material { get; set; }

        public Toy(int quantityBateries = default, string material = default)
        {
            QuantityBateries = quantityBateries;
            Material = material;
        }

        public override string ToString()
        {
            return $"QuantityBateries: {QuantityBateries}, Material: {Material}";
        }
    }
}
