using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprocketOrderForm
{
    public abstract class Sprocket
    {
        private int numItems;
        private int numTeeth;
        private int itemID;
        private decimal price;

        public int ItemID { get { return itemID; } set { itemID = value; } }
        public int NumTeeth { get { return numTeeth; } set { numTeeth = value; } }
        public int NumItems { get { return numItems; } set { numItems = value; } }
        public decimal Price { get { return price; } protected set { price = value; } }

        public Sprocket() {}

        public Sprocket(int itemID, int numItems, int numTeeth)
        {
            ItemID = itemID;
            NumItems = numItems;
            NumTeeth = numTeeth;
        }

        protected abstract void Calculate();

    }
}
