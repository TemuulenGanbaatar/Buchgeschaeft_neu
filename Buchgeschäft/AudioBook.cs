using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchgeschäft
{
    class AudioBook : Book
    {
        public int duration;

        public AudioBook(decimal price, int stock, string titel, string author, string isbn, int duration, Category category) : base(price, stock, titel, isbn, author, category)
        {
            this.price = price;
            this.stock = stock;
            this.Title = Title;
            this.author = author;
            this.isbn = isbn;
            this.duration = duration;

        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {Title} ({this.author}, {duration} minutes ({(int)this.category})) ";
        }

    }
}
