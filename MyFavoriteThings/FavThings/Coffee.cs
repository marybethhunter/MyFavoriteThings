using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings.FavThings
{
    public class Coffee
    {
        public string CoffeeType { get; set; }
        public string CoffeeShop { get; set; }
        public int CupsPerDay { get; set; }

        public void CoffeeShopHours()
        {
            Console.WriteLine($"{CoffeeShop} is open Monday through Friday from 6am-10pm.");
        }
        public void Spill()
        {
            Console.WriteLine($" Oh no! Mary Beth spilled her {CoffeeType} coffee!");
        }
    }
}
