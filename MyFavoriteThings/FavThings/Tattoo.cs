using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings.FavThings
{
    public class Tattoo
    {

        public Tattoo(string name, string bodypart, string shop, bool isfavorite)
        {
            Name = name;
            BodyPart = bodypart;
            Shop = shop;
            IsFavorite = isfavorite;
        }
        public string Name { get; set; }
        public string BodyPart { get; set; }
        public string Shop { get; set; }
        public bool IsFavorite { get; set; }
        public void GetTattoo()
        {
            Console.WriteLine($"{Shop} is open Tuesday through Saturday. Schedule your appointment now!");
        }
        public void RevealFavorite()
        {
            if (IsFavorite == true)
            {
                Console.WriteLine($"My {Name} tattoo on my {BodyPart} is my favorite.");
            } else
            {
                Console.WriteLine("This is not my favorite tattoo.");
            }
        }

    }
}
