using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd2_trabalho_final.Classes
{
    class Finantial : Unique
    {
        private int discount;
        private double productPrice;
        private int quantity;
        private DateTime date;

        public Finantial(int id, int discount, double productPrice, int quantity) : base(id)
        {
            this.discount = discount;
            this.productPrice = productPrice;
            this.quantity = quantity;
        }

        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public double ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}
