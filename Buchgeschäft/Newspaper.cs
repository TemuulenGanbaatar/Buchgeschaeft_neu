using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschäft
{
    class Newspaper  : Item
    {
        public DateTime dateOfIssue;

        public Newspaper(decimal price, int stock, string Title, DateTime dateOfIssue) : base(price, stock, Title)
        {
            this.price = price;
            this.stock = stock;
            this.Title = Title;
            this.dateOfIssue = dateOfIssue;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}: {Title} ({dateOfIssue}) ";
        }


    }
}
