using System;

namespace SelectionStatementsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //favoritenum();

            var r = new Random();
            var favNumber = r.Next(1, 10);
            Console.WriteLine("Try to guess my favorite number. Hint: it is between 1-10");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Too Low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too High");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }

            // SwitchCaseFavSchoolSubjectEx2

            Console.WriteLine("what is your favorite subject to take in school?");
            string userfavsubject = Console.ReadLine();

            switch (userfavsubject.ToLower())
            {
                case "organic chemistry":
                    Console.WriteLine("ugh, too many carbons. that is known as the weedout class to get into medical school.");
                    break;
                case "physics":
                    Console.WriteLine("you must be sheldon cooper smart!");
                    break;
                case "calculus":
                    Console.WriteLine("letters as numbers, i do not like that kind of math.");
                    break;
                case "computer science":
                    Console.WriteLine("you are offically my new best friend.that is my favorite class too! i love computers.");
                    break;
                case "spanish":
                    Console.WriteLine("i struggled in that class. i cannot roll my rs to speak that language well.");
                    break;
                default:
                    Console.WriteLine($"oh, i have not taken {userfavsubject}. sounds like fun!");
                    break;
            }






        }   
    }
}

