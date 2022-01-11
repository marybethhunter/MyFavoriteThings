using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings.FavThings
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Review { get; set; }

        public void GiveAuthor()
        {
            Console.WriteLine($"{Title} was written by {Author}.");
        }
        public void Recommendation()
        {
            Console.WriteLine($"Here's what the NYT had to say about {Title}: {Review}.");
        }
    }
}
