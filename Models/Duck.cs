using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Duck
    {
        public string Color { get; set; }

        public string Race { get; set; }

        public Duck(string color = default, string race = default)
        {
            Color = color;
            Race = race;
        }

        public override string ToString()
        {
            return $"Color: {Color}, Race: {Race}";
        }
    }
}
