using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschäft
{
    class Item
    {
        public decimal price { get; set; }
        public int stock { get; set; }
        public string Title { get; set; }

        public Item (decimal price, int stock, string Title)
        {
            this.price = price;
            this.stock = stock;
            this.Title = Title;
        }

        public bool TryPurchase(int number)
        {
            stock += number;
            return true;
        }


        public bool TrySell(int number)
        {
            if (number > stock)
            {
                return false;
            }
            else if (number <= stock)
            {
                stock -= number;
                return true;
            }
            else
                return false;
        }


    }
}
