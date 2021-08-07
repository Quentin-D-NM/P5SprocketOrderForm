using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprocketOrderForm
{
    class PlasticSprocket : Sprocket
    {
        protected override void Calculate()
        {
            Price = (decimal)0.02 * NumTeeth * NumItems;
        }

        public override string ToString()
        {
            Calculate();
            return "Order #" + ItemID + " Quantity: " + NumItems + " Num Teeth: " + NumTeeth + " Material: Plastic Price: $" + Price;
        }
    }
}
