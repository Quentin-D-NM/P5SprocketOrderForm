using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprocketOrderForm
{
    class SteelSprocket : Sprocket
    {
        protected override void Calculate()
        {
            Price = (decimal)0.05 * NumTeeth * NumItems;
        }

        public override string ToString()
        {
            Calculate();
            return "Order #" + ItemID + " Quantity: " + NumItems + " Num Teeth: " + NumTeeth + " Material: Steel Price: $" + Price;
        }
    }
}
