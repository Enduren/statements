using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draft
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 20);


            Console.WriteLine("Try to guess my Favorite number");
            var userInput = int.Parse(Console.ReadLine());


            if ( userInput <  favNumber )
            {
                Console.WriteLine("TOO LOW!!!");

            }else if ( userInput >  favNumber) {
                Console.WriteLine("Too High!!!");

            }
            else
            {
                Console.WriteLine("Nevermind");
            }

            Console.WriteLine("favorite school subject out of English, Math, Social Studies, Science, Gym , or Lunch");
            string FavoriteSchool = Console.ReadLine();
            


            switch (FavoriteSchool)
            {
                case "English":
                    Console.WriteLine("Reading is Fundamental");
                    break;
                case "Math":
                    Console.WriteLine("Mathematics is the art of giving the same name to different things.");
                    break;

                case "Social Studies":
                    Console.WriteLine("You want weapons? We’re in a library! Books! The best weapons in the world!");
                    break;


                case "Science":
                    Console.WriteLine("Science has proof without any certainty. Creationists have certainty without any proof");
                    break;

                case "Gym":
                    Console.WriteLine("Beast is what I become each and every time I step through those gym doors.");
                    break;

                case "Lunch":
                    Console.WriteLine("Life is like a sandwich, you have to fill it with the best ingredients.");
                    break;

                
            }






        }
    }
}



