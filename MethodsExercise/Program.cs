using System.Drawing;
using System.Reflection;

namespace MethodsExercise
{
    public class Program
    {
        public static void StoryTime()
        {
            Console.WriteLine("What is your name?");
            string Name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string FavoriteColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string FavoriteAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string FavoriteBand = Console.ReadLine();

            Console.WriteLine($"Thank you for that information, {Name}! I heard that you had a dream that a {FavoriteColor} {FavoriteAnimal} was performing with {FavoriteBand} at Coachella. Oh, not you? It must have been a different {Name}.");
        }
        public static int Add (int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello There!");

            StoryTime();

            Console.WriteLine("However, now that we have gotten to know each other a little bit, let's test your math skills.");

            Console.WriteLine("What is 109 + 78?");
            int AddAnswer = int.Parse(Console.ReadLine());

            if (AddAnswer == 187)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine($"You answered {AddAnswer}, and the correct answer was {Add(109, 78)}.");
            }

            Console.WriteLine("What is 32 - 8?");
            int SubtractAnswer = int.Parse(Console.ReadLine());

            if(SubtractAnswer == 24)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine($"You answered {SubtractAnswer}, and the correct answer was {Subtract(32, 8)}.");
            }

            Console.WriteLine("What is 34 * 21?");
            int MultiplyAnswer = int.Parse(Console.ReadLine());

            if(MultiplyAnswer == 714)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine($"You answered {MultiplyAnswer}, and the correct answer was {Multiply(34, 21)}.");
            }

            Console.WriteLine("What is 125 / 5?");
            int DivideAnswer = int.Parse(Console.ReadLine());

            if(DivideAnswer == 25)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine($"You answered {DivideAnswer}, and the correct answer was {Divide(125, 5)}.");
            }

            Console.WriteLine("What is the module/remainder of 100 mod 9?");
            int ModulusAnswer = int.Parse(Console.ReadLine());

            if(ModulusAnswer == 1)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine($"You answered {ModulusAnswer}, and the correct answer was {Modulus(100, 9)}.");
            }

            Console.WriteLine("Great Job! Thank you for participating!");

        }
    }
}
