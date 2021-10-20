using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCardGameConsoleApp
{
    class Card
    {
        public string Face { get; set; }
            = "Number";
        public string Type { get; set; }
            = "Category";
        public int Value { get; set; }
            = 0;

        public Card(string face = "Number",
            string type = "Category",
            int value = 0)
        {
            Face = face;
            Type = type;
            Value = value;
        }

        public override string ToString()
        {
            return "The " + Face + " of " + Type + " with a value of " + Value;
        }
    }
}
