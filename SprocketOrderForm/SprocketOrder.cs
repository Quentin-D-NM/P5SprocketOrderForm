using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprocketOrderForm
{
    class SprocketOrder
    {
        public List<Sprocket> items = new List<Sprocket>();

        public Address address { get; set; }
        //public List<Sprocket> Items { get { return items; } set { items.Add(value); } };
        public decimal TotalPrice { get; set; } 
        public string CustomerName { get; set; }

        public SprocketOrder()
        {

        }

        public SprocketOrder(Address address, string customerName)
        {
            this.address = address;
            CustomerName = customerName;

        }

        public void Add(Sprocket sprocket)
        {
            items.Add(sprocket);
        }

        public void Remove(int index)
        {
            items.RemoveAt(index);
        }

        private void Calc()
        {
            foreach(Sprocket s in items)
            {
                TotalPrice += s.Price;
            }
        }

        public override string ToString()
        {
            Calc();
            return CustomerName + " Item order count: " + items.Count + " Total Price: $" + TotalPrice;
        }
    }
}
