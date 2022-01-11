using MyFavoriteThings.FavThings;
using System;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            Kid kid = new("Skye", "brown", "Pre-K");
            //{
            //    Name = "Skye",
            //    HairColor = "Brown",
            //    SchoolLevel = "Pre-K",
            //};

            Book book = new Book
            {
                Title = "A Little Life",
                Author = "Hanya Yanagihara",
                Review = "It may be dark and traumatic, but Hanya Yanagihara's second novel offers a refreshingly modern take on friendship in the age of anxiety",
            };

            Coffee coffee = new Coffee
            {
                CoffeeType = "iced",
                CoffeeShop = "Tupelo River",
                CupsPerDay = 3,
            };

            Tattoo tattoo1 = new Tattoo
            {
                Name = "peony",
                BodyPart = "inner bicep",
                Shop = "Ironclad Tattoo",
                IsFavorite = true,
            };

            Tattoo tattoo2 = new Tattoo
            {
                Name = "mom tattoo",
                BodyPart = "inner bicep",
                Shop = "Ironclad Tattoo",
                IsFavorite = false,
            };

            Console.WriteLine($"My son's name is {kid.Name}. He has {kid.HairColor.ToLower()} hair and is in {kid.SchoolLevel}.");
            kid.FallDown();
            Console.WriteLine($"My favorite book is called {book.Title} written by {book.Author}.");
            book.Recommendation();
            Console.WriteLine($"I drink way too much {coffee.CoffeeType} coffee. Like {coffee.CupsPerDay} cups before noon.");
            coffee.Spill();
            coffee.CoffeeShopHours();
            tattoo1.RevealFavorite();
            tattoo1.GetTattoo();
            tattoo2.RevealFavorite();

        }
    }
}
