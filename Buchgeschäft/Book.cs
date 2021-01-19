using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschäft
{
    enum Category
    {
        History = 1,
        Thriller = 2,
        Fantasy = 3,
        Child = 4,
        Food = 5,
    }

    class Book : Item
    {
        public string author;
        public string isbn;
        protected Category category;

        public Book (decimal price, int stock, string title, string author, string isbn, Category category) : base(price, stock, title)
        {
            this.price = price;
            this.stock = stock;
            this.Title = title;
            this.author = author;
            this.isbn = isbn;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {Title} ({author} ({(int)this.category}))";
        }
    }
}
