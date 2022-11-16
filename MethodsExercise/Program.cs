using System.Drawing;

namespace MethodsExercise
{
    public class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("What is your name?");
            string Name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string FavoriteColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string FavoriteAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string FavoriteBand = Console.ReadLine();

            Console.WriteLine($"{Name} had a dream that a {FavoriteColor} {FavoriteAnimal} was playing {FavoriteBand} at Coachella.");

        }
    }
}
