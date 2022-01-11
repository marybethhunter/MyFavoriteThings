using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings.FavThings
{
    public class Kid
    {
        // constructor for a kid - giving default values for new Kids
        public Kid(string name, string haircolor, string schoollevel)
        {
            Name = name;
            HairColor = haircolor;
            SchoolLevel = schoollevel;
        }

        public string Name { get; set; }
        public string HairColor { get; set; }
        public string SchoolLevel { get; set; }
        public void Speak()
        {
            Console.WriteLine($"{Name} says, \'MOM\' all day long.");
        }
        public void FallDown()
        {
            Console.WriteLine($"{Name} trips over their toys and falls down.");
        }
    }
}
